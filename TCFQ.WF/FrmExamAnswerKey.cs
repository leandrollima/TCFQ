using TCFQ.CO;

namespace TCFQ.WF
{
    public partial class FrmExamAnswerKey : Form
    {
        public ExamCO Exam { get; set; } = default!;
        public ushort QuestionNumber { get; set; } = 1;
        public bool ModeHighlight { get; set; } = false;

        public FrmExamAnswerKey()
        {
            InitializeComponent();
        }

        public void Highlight(ushort questionNumber)
        {
            QuestionNumber = questionNumber;
            ucExAnsKey.HighlightAnswer(questionNumber);
        }

        private void FrmExamAnswerKey_Shown(object sender, EventArgs e)
        {
            lblExamName.Text = Exam.Name;
            ucExAnsKey.RenderAnswerKey(Exam);

            if (ModeHighlight)
            {
                ucExAnsKey.DisabledAllLabels();
                ucExAnsKey.HighlightAnswer(QuestionNumber);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ucExAnsKey.Content);
        }
    }
}
