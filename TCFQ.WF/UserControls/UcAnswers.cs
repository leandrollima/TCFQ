using System.Text;
using TCFQ.CO;
using TCFQ.WF.Util;

namespace TCFQ.WF.UserControls
{
    public partial class UcAnswers : UserControl
    {
        ushort lines = 1;
        StringBuilder resultStrB = new StringBuilder();
        LabelTemplate labelTemplate = new LabelTemplate();

        public ushort Columns = 4;
        public string Content { get { return resultStrB.ToString(); } }

        public UcAnswers()
        {
            InitializeComponent();
        }

        public void RenderCorrection(ExamCO exam)
        {
            Clear();

            string levelResult = exam.LevelResult();
            resultStrB.AppendLine(levelResult);

            lines = (ushort)Math.Ceiling((double)exam.Questions.Length / Columns);

            int lastYPosition = 0;
            for (int y = 0; y < lines; y++) // linhas são eixo Y
            {
                int lastXPosition = 10;
                for (int x = 0; x < Columns; x++) // colunas são eixo X
                {
                    int index = y + x * lines;
                    if (index < exam.Questions.Length)
                    {
                        Label lbl = labelTemplate.Correction(exam.Questions[index]);

                        lastYPosition = (y * 30) + lbl.Height;

                        if (x != 0)
                            lastXPosition = lastXPosition + lbl.Width + 20;

                        lbl.Location = new Point(lastXPosition, lastYPosition);

                        this.Invoke(new Action(() =>
                        {
                            this.Controls.Add(lbl);
                            lbl.BringToFront();
                        }));

                        resultStrB.Append(lbl.Text).Append("\t");
                    }
                }
                resultStrB.AppendLine();
            }
        }

        public void RenderAnswerKey(ExamCO Exam)
        {
            Clear();

            resultStrB.AppendLine(Exam.Name);

            lines = (ushort)Math.Ceiling((double)Exam.Questions.Length / Columns);

            int lastYPosition = 0;
            for (int y = 0; y < lines; y++) // linhas são eixo Y
            {
                int lastXPosition = 10;
                for (int x = 0; x < Columns; x++) // colunas são eixo X
                {
                    int index = y + x * lines;
                    if (index < Exam.Questions.Length)
                    {
                        Label lbl = labelTemplate.Answer(Exam.Questions[index].Number, Exam.Questions[index].CorrectAnswer);

                        
                        lastYPosition = (y * 30) + lbl.Height;

                        if (x != 0)
                            lastXPosition = lastXPosition + lbl.Width + 20;

                        lbl.Location = new Point(lastXPosition, lastYPosition);

                        this.Invoke(new Action(() =>
                        {
                            this.Controls.Add(lbl);
                            lbl.BringToFront();
                        }));

                        this.Refresh();
                        this.Update();

                        resultStrB.Append(lbl.Text).Append("\t");
                    }
                }
                resultStrB.AppendLine();
            }
        }

        public void HighlightAnswer(ushort questionNumber)
        {
            switch (questionNumber)
            {
                case 0: return;
                case 1:
                    this.Invoke(new Action(() =>
                    {
                        Label? label = GetLabel(questionNumber);
                        if(label is not null)
                            labelTemplate.HighlightColor(label);

                        this.Refresh();
                    }));
                    return;
                default:
                    this.Invoke(new Action(() =>
                    {
                        Label? label = GetLabel(questionNumber);
                        if (label is not null)
                            labelTemplate.HighlightColor(label);

                        Label? labelPrevious = GetLabel((ushort)(questionNumber - 1));
                        if (labelPrevious is not null)
                            labelTemplate.DisabledColor(labelPrevious);

                        this.Refresh();
                    }));
                    return;
            }
        }

        internal void DisabledAllLabels()
        {
            foreach (Control controle in Controls)
            {
                if (controle is Label label && label.Tag != null)
                    labelTemplate.DisabledColor((Label)controle);
            }
        }

        private Label? GetLabel(ushort questionNumber)
        {
            foreach (Control controle in Controls)
            {
                if (controle is Label label && label.Tag != null && label.Tag.ToString() == questionNumber.ToString())
                    return (Label)controle;
            }
            return null;
        }

        private void Clear()
        {
            this.Controls.Clear();
            resultStrB = new StringBuilder();
        }
    }
}
