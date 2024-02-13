using TCFQ.CO;

namespace TCFQ.WF.Util
{
    public class LabelTemplate
    {
        public Label Correction(QuestionCO question, int fontSize = 14)
        {
            Label lbl = new Label();
            lbl.Font = new Font("Arial", fontSize, FontStyle.Bold);
            lbl.Width = 250;
            lbl.Height = 30;

            string correctStr = $" - Correct: {question.CorrectAnswer} ";

            string lblText = $"{question.Number.ToString().PadLeft(2, '0')}. ";

            if (question.IsCorrect)
            {
                lbl.BackColor = Color.Green;
                lbl.ForeColor = Color.Black;
                correctStr = new string(' ', correctStr.Length);
            }
            else
            {
                lbl.BackColor = Color.DarkRed;
                lbl.ForeColor = Color.White;
            }

            lblText += $" {question.UserAnswer} ";
            lblText += $"{correctStr}" + "\t";

            lbl.Text = lblText;

            return lbl;
        }

        public Label Answer(int QuestionNumber, char CorrectAnswer)
        {
            Label lbl = new Label();
            lbl.Font = new Font("Arial", 14, FontStyle.Bold);
            lbl.Width = 250;
            lbl.Height = 30;
            lbl.Tag = QuestionNumber;

            lbl.Text = $"{QuestionNumber.ToString().PadLeft(2, '0')}.  {CorrectAnswer}";

            return lbl;
        }

        public void HighlightColor(Label lbl)
        {
            lbl.BackColor = Color.Yellow;
            lbl.ForeColor = Control.DefaultForeColor;
        }

        public void NormalColor(Label lbl)
        {
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Control.DefaultForeColor;
        }

        public void DisabledColor(Label lbl)
        {
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Color.FromArgb(240, 240, 204);
        }
    }
}
