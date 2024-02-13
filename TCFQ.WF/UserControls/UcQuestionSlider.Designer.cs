namespace TCFQ.WF.UserControls
{
    partial class UcQuestionSlider
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
            btnNext = new Button();
            lblQuestionNumber = new Label();
            flpAnswers = new FlowLayoutPanel();
            lblParcialResult = new Label();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Location = new Point(108, 304);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(5);
            btnNext.Size = new Size(86, 31);
            btnNext.TabIndex = 2;
            btnNext.Text = "Próxima";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.Dock = DockStyle.Top;
            lblQuestionNumber.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestionNumber.Location = new Point(0, 0);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(206, 38);
            lblQuestionNumber.TabIndex = 0;
            lblQuestionNumber.Text = "99.";
            lblQuestionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpAnswers
            // 
            flpAnswers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpAnswers.FlowDirection = FlowDirection.BottomUp;
            flpAnswers.Location = new Point(12, 41);
            flpAnswers.Name = "flpAnswers";
            flpAnswers.Size = new Size(182, 257);
            flpAnswers.TabIndex = 1;
            // 
            // lblParcialResult
            // 
            lblParcialResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblParcialResult.AutoSize = true;
            lblParcialResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParcialResult.Location = new Point(12, 338);
            lblParcialResult.Name = "lblParcialResult";
            lblParcialResult.Size = new Size(169, 19);
            lblParcialResult.TabIndex = 3;
            lblParcialResult.Text = "                                        ";
            // 
            // UcQuestionSlider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblParcialResult);
            Controls.Add(flpAnswers);
            Controls.Add(btnNext);
            Controls.Add(lblQuestionNumber);
            MinimumSize = new Size(206, 318);
            Name = "UcQuestionSlider";
            Size = new Size(206, 366);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private Label lblQuestionNumber;
        private FlowLayoutPanel flpAnswers;
        private Label lblParcialResult;
    }
}
