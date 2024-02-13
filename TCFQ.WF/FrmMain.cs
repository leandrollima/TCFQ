using TCFQ.CO;
using TCFQ.Repository.Context;
using TCFQ.WF.Util;
using TCFQ.WF.Events.UserControls;

namespace TCFQ.WF
{
    public partial class FrmMain : Form
    {
        const string ANONYMOUS_USER = "Anonimo";
        const string FINISH_EXAM_TO_SEE_RESULT_WARNING = "Finalize o exame para ver o resultado";
        const string LOAD_EXAM_ERROR = "Erro ao carregar o Exame número {0}, é possível que ele não tenha sido fornecido para esta versão do sistema, tente outro exame: {1}{2}";

        bool started = false;
        bool _databaseConnectionSuccessfull;
        FrmExamAnswerKey? _frmExamAnswerKeyHighlightAnswers;
        ushort _questionNumber = 1;

        private readonly AppDbContext _context;

        public FrmMain(AppDbContext dbContext)
        {
            this._context = dbContext;

            InitializeComponent();

            ExamInfo examInfo = new ExamInfo();

            var lst = examInfo.AvailableExam.ToList();

            cmbExams.DataSource = lst;
            this.KeyPreview = true;
            btnCancel.Visible = false;
            btnCancel.Location = btnLoad.Location;

            btnOldResults.Enabled = false;
        }

        private void CancelExam()
        {
            txtUserName.Enabled = true;
            cmbExams.Enabled = true;
            btnLoad.Enabled = true;
            started = false;
            ucQuestionSlider1.CancelExam();
            ucQuestionSlider1.ParcialResultVisible = true;
            btnCancel.Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ucQuestionSlider1.StartQuestions((ushort)Convert.ToInt16(cmbExams.SelectedValue));

                txtUserName.Enabled = false;
                cmbExams.Enabled = false;
                btnLoad.Enabled = false;
                txtUserName.Text = txtUserName.Text.Length == 0 ? ANONYMOUS_USER : txtUserName.Text;
                btnCancel.Visible = true;

                started = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(LOAD_EXAM_ERROR, cmbExams.SelectedValue, Environment.NewLine, ex.Message), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (!ucQuestionSlider1.FinishExam)
            {
                MessageBox.Show(FINISH_EXAM_TO_SEE_RESULT_WARNING, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowCorrectionExam();
        }

        private void ShowCorrectionExam()
        {
            FrmCorrectionExam frmResult = new FrmCorrectionExam(_context);
            frmResult.UserName = txtUserName.Text.Length == 0 ? ANONYMOUS_USER : txtUserName.Text;
            frmResult.Exam = ucQuestionSlider1.GetExamWithUserAnswers();
            frmResult.Show();
        }

        private void btnTestAnswer_Click(object sender, EventArgs e)
        {
            new FrmExamAnswerKey() { Exam = new ExamCO((ushort)Convert.ToInt16(cmbExams.SelectedValue)), ModeHighlight = false }.Show();
        }

        private void btnOldResults_Click(object sender, EventArgs e)
        {
            FrmOldResults old = new FrmOldResults(_context);
            old.Show();
        }

        private void ucQuestionSlider1_ExamFinished(object sender, EventArgsFinishExam e)
        {
            if (e.Finished)
                ShowCorrectionExam();
        }

        private void ucQuestionSlider1_ChangeQuestion(object sender, EventArgsChangeQuestion e)
        {
            if(_frmExamAnswerKeyHighlightAnswers is not null)
            {
                _questionNumber = e.Question;
                _frmExamAnswerKeyHighlightAnswers.Highlight(e.Question);
            }
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (started)
                ucQuestionSlider1.Answer_KeyPress(sender, e);
        }

        private void btnViewPartialResult_Click(object sender, EventArgs e)
        {
            ucQuestionSlider1.ParcialResultVisible = !ucQuestionSlider1.ParcialResultVisible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelExam();
        }

        private async void FrmMain_Shown(object sender, EventArgs e)
        {
            await this.EnableControlsAsync(_context, btnOldResults);
        }
                
        private void btnResultWithHighlight_Click(object sender, EventArgs e)
        {
            _frmExamAnswerKeyHighlightAnswers = new FrmExamAnswerKey() 
            {
                Exam = new ExamCO((ushort)Convert.ToInt16(cmbExams.SelectedValue)), 
                ModeHighlight = true,
                QuestionNumber = ucQuestionSlider1.CurrentQuestionNumber
            };  
            
            _frmExamAnswerKeyHighlightAnswers.Show();
            _frmExamAnswerKeyHighlightAnswers.FormClosed += (s, args) => _frmExamAnswerKeyHighlightAnswers = null;
        }
    }
}
