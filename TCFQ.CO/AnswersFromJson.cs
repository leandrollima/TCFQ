using System.Reflection;
using System.Text.Json;

namespace TCFQ.CO
{
    internal class AnswersFromJson
    {
        const string LISTENING_COMPREHENSION = "CO";
        const string JSON_FILE = "answers.json";
        const string JSON_NOT_FOUND = "The JSON file was not found in the executable directory.";
        const string JSON_NODE_NOT_FOUND = "The object '{0}' does not found in JSON file.";

        private AnswerJsonModel[] answers;

        public IReadOnlyCollection<int> AvailableExams { get; private set; }
        public IReadOnlyCollection<char> Answers { get; private set; }
        public readonly int MaxExamId;

        public AnswersFromJson(int examId)
        {
            string directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
            string jsonFilePath = Path.Combine(directoryPath, JSON_FILE);

            if (File.Exists(jsonFilePath))
            {
                string jsonContent = File.ReadAllText(jsonFilePath);

                using (JsonDocument jsonDocument = JsonDocument.Parse(jsonContent))
                {
                    JsonElement meuObjetoElement;
                    if (jsonDocument.RootElement.TryGetProperty(LISTENING_COMPREHENSION, out meuObjetoElement))
                    {
                        answers = JsonSerializer.Deserialize<AnswerJsonModel[]>(meuObjetoElement.GetRawText())!;
                        Answers = answers.Where(x => x.Id == examId).SelectMany(x => x.Answers).ToArray();
                        MaxExamId = examId;
                        AvailableExams = answers.Select(x => x.Id).ToArray();
                    }
                    else
                    {
                        throw new JsonException(string.Format(JSON_NODE_NOT_FOUND, LISTENING_COMPREHENSION));
                    }
                }
            }
            else
            {
                throw new FileNotFoundException(JSON_NOT_FOUND);
            }
        }

        public AnswersFromJson()
        {
            string directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
            string jsonFilePath = Path.Combine(directoryPath, JSON_FILE);

            if (File.Exists(jsonFilePath))
            {
                string jsonContent = File.ReadAllText(jsonFilePath);

                using (JsonDocument jsonDocument = JsonDocument.Parse(jsonContent))
                {
                    JsonElement meuObjetoElement;
                    if (jsonDocument.RootElement.TryGetProperty(LISTENING_COMPREHENSION, out meuObjetoElement))
                    {
                        answers = JsonSerializer.Deserialize<AnswerJsonModel[]>(meuObjetoElement.GetRawText())!;
                        MaxExamId = answers.Max(x=> x.Id);
                        AvailableExams = answers.Select(x => x.Id).ToArray();
                    }
                    else
                    {
                        throw new JsonException($"The object '{LISTENING_COMPREHENSION}' does not found in JSON file.");
                    }
                }
            }
            else
            {
                throw new FileNotFoundException(JSON_NOT_FOUND);
            }
        }
    }
}
