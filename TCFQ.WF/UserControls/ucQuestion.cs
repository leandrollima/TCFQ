using System.ComponentModel;

namespace TCFQ.WF.UserControls
{
    public partial class ucQuestion : UserControl
    {
        const string ANSWER_LETTERS_ACCEPTABLE = "Only these letters {0} are acceptable.";
        const string TITLE_ERROR = "Error";

        ushort questionNumber;
        char answer;

        [Browsable(true)]
        public ushort NumberOfQuestion
        {
            get => questionNumber;
            set
            {
                questionNumber = value;
                lblQuestion.Text = $"{questionNumber.ToString()}. ";
            }
        }

        [Browsable(true)]
        public char LetterOfAnswer
        {
            get => answer;
            set
            {
                char upperCaseValue = char.ToUpper(value);

                if (AcceptableAnswers.Contains(upperCaseValue))
                {
                    answer = upperCaseValue;
                }
                else
                {
                    throw new ArgumentException(string.Format(ANSWER_LETTERS_ACCEPTABLE, String.Join(',', AcceptableAnswers)));
                }

                txtAnswer.Text = answer.ToString();
            }
        }

        public IReadOnlyCollection<char> AcceptableAnswers { get; set; }

        public ucQuestion()
        {
            InitializeComponent();
        }

        private void txtAnswer_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtAnswer.Text.Length > 0)
                    LetterOfAnswer = txtAnswer.Text.ToCharArray()[0];
                else
                    LetterOfAnswer = '\0';
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
