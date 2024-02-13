namespace TCFQ.WF.UserControls
{
    partial class ucQuestion
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
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(2, 14);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(47, 21);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "99.";
            lblQuestion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.Location = new Point(48, 8);
            txtAnswer.Margin = new Padding(3, 2, 3, 2);
            txtAnswer.MaxLength = 1;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(84, 32);
            txtAnswer.TabIndex = 1;
            txtAnswer.Leave += txtAnswer_Leave;
            // 
            // ucQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(143, 48);
            MinimumSize = new Size(143, 48);
            Name = "ucQuestion";
            Size = new Size(143, 48);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private TextBox txtAnswer;
    }
}
