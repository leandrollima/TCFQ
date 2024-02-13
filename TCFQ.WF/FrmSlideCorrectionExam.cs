using TCFQ.CO;

namespace TCFQ.WF
{
    public partial class FrmSlideCorrectionExam : Form
    {
        public ExamCO Exam { get; set; } = default!;
        public FrmSlideCorrectionExam()
        {
            InitializeComponent();
        }

        private void FrmSlideCorrectionExam_Shown(object sender, EventArgs e)
        {
            ucAnswersSlider1.Start(Exam);
        }
    }
}
