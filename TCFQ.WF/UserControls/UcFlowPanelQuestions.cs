using TCFQ.CO;

namespace TCFQ.WF.UserControls
{
    public partial class UcFlowPanelQuestions : FlowLayoutPanel
    {
        ExamCO exam = default!;

        public bool HasQuestion { get { return this.Controls.Count > 0; } }
        public UcFlowPanelQuestions()
        {
            InitializeComponent();
        }

        public void StartQuestions(ushort examId)
        {
            this.Controls.Clear();
            exam = new ExamCO((ushort)examId);

            //var acceptableAnswers = exam.AcceptableAnswers.ToArray();
            //var random = new Random();

            foreach (var question in exam.Questions)
            {
                ucQuestion uc = new ucQuestion();
                uc.AcceptableAnswers = exam.AcceptableAnswers;
                uc.NumberOfQuestion = question.Number;
                //uc.LetterOfAnswer = acceptableAnswers[random.Next(0, acceptableAnswers.Length)];
                this.Controls.Add(uc);
            }
        }

        public ExamCO GetExamWithUserAnswers()
        {
            foreach (ucQuestion ucQuestion in this.Controls)
            {
                QuestionCO question = exam.Questions.Single(x => x.Number == ucQuestion.NumberOfQuestion);
                question.UserAnswer = ucQuestion.LetterOfAnswer;
            }
            return exam;
        }
    }
}
