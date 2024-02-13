using System.Text;
using TCFQ.CO;
using TCFQ.Domain;
using TCFQ.Repository.Context;
using TCFQ.WF.Util;

namespace TCFQ.WF
{
    public partial class FrmOldResults : Form
    {
        private readonly AppDbContext _context;
        ExamCO exam = default!;

        public FrmOldResults(AppDbContext dbContext)
        {
            this._context = dbContext;
            InitializeComponent();
            grbResult.Text = string.Empty;
        }

        private async Task LoadResultsAsync()
        {
            try
            {
                await Task.Run(async () =>
                {
                    ICollection<Result> results = await new Database(_context).GetAllResults();

                    this.Invoke(new Action(() =>
                    {
                        lblExamId.Text = string.Empty;
                        lblLevel.Text = string.Empty;
                        lblPoints.Text = string.Empty;
                        lblCreatedAt.Text = string.Empty;
                        btnCopy.Enabled = false;
                        btnReviewEachAnswer.Enabled = false;

                        dgvResults.DataSource = results;

                        dgvResults.Columns["Name"].HeaderText = "Usuário";
                        dgvResults.Columns["ExamId"].HeaderText = "Exame Nº";
                        dgvResults.Columns["Level"].HeaderText = "Nível";
                        dgvResults.Columns["Points"].HeaderText = "Pontos";
                        dgvResults.Columns["Answers"].HeaderText = "Respostas";
                        dgvResults.Columns["CreateAt"].HeaderText = "Realizado em";
                        dgvResults.Columns["Id"].HeaderText = "Id";

                        dgvResults.Columns["Answers"].Visible = false;
                        dgvResults.Columns["Id"].Visible = false;

                        dgvResults.Columns["CreateAt"].Width = 200;
                    }));                    
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar os resultados do exame na base de dados: {Environment.NewLine}{ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FrmOldResults_Shown(object sender, EventArgs e)
        {
            await LoadResultsAsync();
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvResults.Rows[e.RowIndex];

                grbResult.Text = row.Cells["Name"].Value.ToString();
                lblExamId.Text = row.Cells["ExamId"].Value.ToString();
                lblLevel.Text = row.Cells["Level"].Value.ToString();
                lblPoints.Text = row.Cells["Points"].Value.ToString();
                lblCreatedAt.Text = row.Cells["CreateAt"].Value.ToString();

                List<Answer> answers = ((ICollection<Answer>)row.Cells["Answers"].Value).ToList()!;

                exam = new ExamCO(ushort.Parse(row.Cells["ExamId"].Value.ToString()!));
                foreach (var question in exam.Questions)
                {
                    question.UserAnswer = answers.Single(x => x.QuestionId == question.Number).UserAnswer;
                }

                ucCorrection.RenderCorrection(exam);

                btnCopy.Enabled = true;
                btnReviewEachAnswer.Enabled = true;
            }
            else
            {
                btnReviewEachAnswer.Enabled = false;
                btnCopy.Enabled = false;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(grbResult.Text);
            str.AppendLine($"Exame Nº: {lblExamId.Text}, realizado em: {lblCreatedAt.Text.Split(' ')[0]}");
            str.AppendLine();
            str.AppendLine(ucCorrection.Content);

            Clipboard.SetText(str.ToString());
        }

        private void btnReviewEachAnswer_Click(object sender, EventArgs e)
        {
            if(exam is null)
            {
                return;
            }

            FrmSlideCorrectionExam slides = new FrmSlideCorrectionExam();
            slides.Exam = exam; 
            slides.Show();
        }
    }
}
