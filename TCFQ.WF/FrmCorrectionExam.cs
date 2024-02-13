using TCFQ.CO;
using TCFQ.Domain;
using TCFQ.Repository.Context;
using TCFQ.WF.Util;

namespace TCFQ.WF
{
    public partial class FrmCorrectionExam : Form
    {
        const string DATA_SAVED = "Dados salvos com sucesso!";
        const string DATA_SAVE_ERROR = "Erro ao salvar os resultados do exame na base de dados";

        private readonly AppDbContext _context;

        public ExamCO Exam { get; set; } = default!;
        public string UserName { get; set; } = default!;

        public FrmCorrectionExam(AppDbContext appDbContext)
        {
            this._context = appDbContext;
            InitializeComponent();
        }

        private async void FrmCorrectionExam_Shown(object sender, EventArgs e)
        {
            if (Exam is not null)
            {
                await this.EnableControlsAsync(_context, btnSave);

                lblExamName.Text = Exam.LevelResult();
                ucCorrectionExam.RenderCorrection(Exam);
            }
            else
            {
                btnCopyResult.Enabled = false;
                btnSave.Enabled = false;
                lblExamName.Text = string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                new Database(_context).SaveResult(EntityForSave());

                MessageBox.Show(DATA_SAVED, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{DATA_SAVE_ERROR}: {Environment.NewLine}{ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ucCorrectionExam.Content);
        }

        private Result EntityForSave()
        {
            Result resultEntity = new Result()
            {
                Name = UserName,
                ExamId = Exam.Id,
                Level = Exam.Level,
                Points = Exam.Points,
                Answers = new List<Answer>()
            };

            foreach (var question in Exam.Questions)
            {
                resultEntity.Answers.Add(new Answer()
                {
                    QuestionId = question.Number,
                    UserAnswer = question.UserAnswer
                });
            }
            return resultEntity;
        }
    }
}
