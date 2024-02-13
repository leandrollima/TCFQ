namespace TCFQ.WF.UserControls
{
    partial class UcAnswersSlider
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestionNumber = new Label();
            lblAnswerLetter = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            lblUserAnswer = new Label();
            SuspendLayout();
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.Dock = DockStyle.Top;
            lblQuestionNumber.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestionNumber.Location = new Point(0, 0);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(311, 38);
            lblQuestionNumber.TabIndex = 0;
            lblQuestionNumber.Text = "99.";
            lblQuestionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnswerLetter
            // 
            lblAnswerLetter.Dock = DockStyle.Fill;
            lblAnswerLetter.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswerLetter.Location = new Point(29, 38);
            lblAnswerLetter.Name = "lblAnswerLetter";
            lblAnswerLetter.Size = new Size(253, 167);
            lblAnswerLetter.TabIndex = 1;
            lblAnswerLetter.Text = "A";
            lblAnswerLetter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            btnPrevious.Dock = DockStyle.Left;
            btnPrevious.Location = new Point(0, 38);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Padding = new Padding(5);
            btnPrevious.Size = new Size(29, 167);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Dock = DockStyle.Right;
            btnNext.Location = new Point(282, 38);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(5);
            btnNext.Size = new Size(29, 167);
            btnNext.TabIndex = 3;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblUserAnswer
            // 
            lblUserAnswer.BackColor = Color.FromArgb(255, 192, 192);
            lblUserAnswer.Dock = DockStyle.Bottom;
            lblUserAnswer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserAnswer.Location = new Point(0, 205);
            lblUserAnswer.Name = "lblUserAnswer";
            lblUserAnswer.Padding = new Padding(5);
            lblUserAnswer.Size = new Size(311, 40);
            lblUserAnswer.TabIndex = 4;
            lblUserAnswer.Text = "Sua resposta: B";
            lblUserAnswer.TextAlign = ContentAlignment.MiddleCenter;
            lblUserAnswer.Visible = false;
            // 
            // UcAnswersSlider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAnswerLetter);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(lblUserAnswer);
            Controls.Add(lblQuestionNumber);
            MinimumSize = new Size(311, 245);
            Name = "UcAnswersSlider";
            Size = new Size(311, 245);
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestionNumber;
        private Label lblAnswerLetter;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblUserAnswer;
    }
}
