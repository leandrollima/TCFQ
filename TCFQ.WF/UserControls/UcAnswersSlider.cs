using TCFQ.CO;

namespace TCFQ.WF.UserControls
{
    public partial class UcAnswersSlider : UserControl
    {
        const string YOUR_ANSWER_WAS = "Sua resposta foi";
        ExamCO exam = default!;
        ushort currentQuestionNumber = default!;
        ushort maxQuestionNumber = default!;

        public UcAnswersSlider()
        {
            InitializeComponent();
        }

        public void Start(ExamCO examCO)
        {
            exam = examCO;
            maxQuestionNumber = exam.Questions.Max(x => x.Number);
            LoadQuestionInformation(exam.Questions[0]);
        }

        private void LoadQuestionInformation(QuestionCO questionCO)
        {
            currentQuestionNumber = questionCO.Number;
            lblQuestionNumber.Text = questionCO.Number.ToString();
            lblAnswerLetter.Text = questionCO.CorrectAnswer.ToString();
            lblUserAnswer.Text = $"{YOUR_ANSWER_WAS}: {questionCO.UserAnswer}";
            lblUserAnswer.Visible = !questionCO.IsCorrect;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionNumber < maxQuestionNumber)
            {
                LoadQuestionInformation(exam.Questions[currentQuestionNumber]);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuestionNumber > 1)
            {
                int indexPreviousQuestion = currentQuestionNumber - 2;
                LoadQuestionInformation(exam.Questions[indexPreviousQuestion]);
            }
        }
    }
}
