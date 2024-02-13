using System.ComponentModel;
using TCFQ.CO;
using TCFQ.WF.Events.UserControls;

namespace TCFQ.WF.UserControls
{
    public partial class UcQuestionSlider : UserControl
    {
        ExamCO exam = default!;
        ushort currentQuestionNumber = default!;
        ushort maxQuestionNumber = default!;
        bool _finishExam;

        [Browsable(true)]
        public event EventHandler<EventArgsFinishExam>? ExamFinished;

        [Browsable(true)]
        public event EventHandler<EventArgsChangeQuestion>? ChangeQuestion;

        [Browsable(true)]
        public bool ParcialResultVisible
        {
            get { return lblParcialResult.Visible; }
            set { lblParcialResult.Visible = value; }
        }

        public bool FinishExam { get { return _finishExam; } }
        public ushort CurrentQuestionNumber { get { return currentQuestionNumber; } }

        public UcQuestionSlider()
        {
            InitializeComponent();
            lblQuestionNumber.Text = string.Empty;
            btnNext.Visible = false;
            _finishExam = false;
        }

        public void StartQuestions(ushort examId)
        {
            exam = new ExamCO((ushort)examId);
            maxQuestionNumber = exam.Questions.Max(x => x.Number);
            LoadQuestionInformation(exam.Questions[0]);

            btnNext.Visible = true;
        }

        public void CancelExam()
        {
            exam = default!;
            lblQuestionNumber.Text = string.Empty;
            btnNext.Visible = false;
            _finishExam = false;
            currentQuestionNumber = default!;
            maxQuestionNumber = default!;
            flpAnswers.Controls.Clear();
        }

        public ExamCO GetExamWithUserAnswers()
        {
            return exam;
        }

        public void Answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char enter = Convert.ToChar(Keys.Enter);
            if(e.KeyChar == enter)
            {
                btnNext_Click(new object(), new EventArgs());
                return;
            }

            char answer = char.ToUpper(e.KeyChar);

            if (!exam.AcceptableAnswers.Contains(answer))
                return;

            foreach (var control in flpAnswers.Controls)
            {
                if (control is RadioButton)
                {
                    if(Convert.ToChar(((RadioButton)control).Tag) == answer)
                    {
                        ((RadioButton)control).Checked = !((RadioButton)control).Checked;
                    }
                }
            }
        }

        protected virtual void OnExamFinished()
        {
            ExamFinished?.Invoke(this, new EventArgsFinishExam(_finishExam));
        }

        protected virtual void OnChangeQuestion()
        {
            ChangeQuestion?.Invoke(this, new EventArgsChangeQuestion(currentQuestionNumber));
        }


        private void LoadQuestionInformation(QuestionCO questionCO)
        {
            flpAnswers.Controls.Clear();

            currentQuestionNumber = questionCO.Number;
            lblQuestionNumber.Text = questionCO.Number.ToString();

            foreach (char answer in exam.AcceptableAnswers)
            {
                RadioButton rb = new RadioButton();
                rb.Font = new Font("Arial", 24, FontStyle.Bold);
                rb.Tag = answer;
                rb.Text = answer.ToString();
                rb.AutoSize = true;

                this.Invoke(new Action(() =>
                {
                    flpAnswers.Controls.Add(rb);
                    rb.BringToFront();
                }));

                this.Update();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //bool answered = false;

            foreach (var control in flpAnswers.Controls)
            {
                if (control is RadioButton && ((RadioButton)control).Checked)
                {
                    QuestionCO question = exam.Questions.Single(x => x.Number == currentQuestionNumber);
                    question.UserAnswer = Convert.ToChar(((RadioButton)control).Tag);
                    //answered = true;
                }
            }

            if (currentQuestionNumber < maxQuestionNumber)
            {
                LoadQuestionInformation(exam.Questions[currentQuestionNumber]);
                lblParcialResult.Text = exam.LevelResult();
                ParcialResultVisible = false;
                OnChangeQuestion();
            }
            else
            {
                btnNext.Enabled = false;
                _finishExam = true;
                OnExamFinished();
            }
        }

    }
}
