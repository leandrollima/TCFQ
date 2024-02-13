namespace TCFQ.CO
{
    public class ExamInfo
    {
        public readonly int MaxId;
        public readonly IReadOnlyCollection<int> AvailableExam;
        public ExamInfo()
        {
            AnswersFromJson answersFromJson = new AnswersFromJson();
            MaxId = answersFromJson.MaxExamId;
            AvailableExam = answersFromJson.AvailableExams;
        }
    }
}
