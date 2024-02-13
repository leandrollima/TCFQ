using System.Text;

namespace TCFQ.CO
{
    public class ExamCO
    {
        const string OUT_OF_RANGE_EXCEPTION_MESSAGE = "Expected '{0}' beetween 1 and {1}";
        const string SERIE_STR = "Serie";
        const string LEVEL_STR = "Level";
        const string POINTS_STR = "Points";

        const ushort MAX_POINTS = 699;
        const int TOTAL_NUMBER_OF_QUESTIONS = 39;

        readonly AnswersFromJson _answersFromJson;
        readonly char[] _acceptableAnswers;
        readonly string[] _levels;

        public IReadOnlyCollection<char> AcceptableAnswers { get; private set; }

        public QuestionCO[] Questions { get; private set; } = default!;
        public ushort Id { get; private set; }
        public string Name { get { return $"{SERIE_STR} {Id}"; } }
        public ushort Points { get { return (ushort)Questions.Where(x => x.IsCorrect).Sum(x => x.Point); } }
        public string Level { get { return GetLevel(); } }

        public ExamCO(ushort id)
        {
            Id = id;
            _answersFromJson = new AnswersFromJson(id);

            var hashAnswers = new HashSet<char>(_answersFromJson.Answers);
            var lstAnswers = hashAnswers.ToList();
            lstAnswers.Sort();

            AcceptableAnswers = lstAnswers;
            _acceptableAnswers = AcceptableAnswers.ToArray();
            _levels = ["A0", "A1", "A2", "B1", "B2", "C1", "C2"];

            InitializeQuestions();
        }

        public string LevelResult()
        {
            return $"{LEVEL_STR}: {Level} ({POINTS_STR}: {Points}/{MAX_POINTS})";
        }


        #region PRIVATE METHODS

        void InitializeQuestions()
        {
            char[] answers = [.. _answersFromJson.Answers];

            Questions = new QuestionCO[TOTAL_NUMBER_OF_QUESTIONS];
            for (short i = 0; i < TOTAL_NUMBER_OF_QUESTIONS; i++)
            {
                Questions[i] = CreateQuestion((ushort)(i + 1), answers[i]);
            }
        }

        QuestionCO CreateQuestion(ushort number, char correctAnswer)
        {
            ushort point = 0;

            switch (number)
            {
                case >= 1 and <= 4:
                    point = 3; break;
                case >= 5 and <= 10:
                    point = 9; break;
                case >= 11 and <= 19:
                    point = 15; break;
                case >= 20 and <= 29:
                    point = 21; break;
                case >= 30 and <= 35:
                    point = 26; break;
                case >= 36 and <= 39:
                    point = 33; break;
                default:
                    throw new ArgumentOutOfRangeException(string.Format(OUT_OF_RANGE_EXCEPTION_MESSAGE, nameof(number), TOTAL_NUMBER_OF_QUESTIONS));
            }

            return new QuestionCO(number, point, correctAnswer, _acceptableAnswers);
        }

        string GetLevel()
        {
            switch (Points)
            {
                case >= 101 and <= 199:
                    return _levels[1];
                case >= 200 and <= 299:
                    return _levels[2];
                case >= 300 and <= 399:
                    return _levels[3];
                case >= 400 and <= 499:
                    return _levels[4];
                case >= 500 and <= 599:
                    return _levels[5];
                case >= 600 and <= 699:
                    return _levels[6];
                default:
                    return _levels[0];
                    //throw new ArgumentOutOfRangeException($"Expected '{nameof(Points)}' beetween 101 and 699, value: {Points}");
            }
        }

        #endregion PRIVATE METHODS
    }
}
