namespace TCFQ.WF
{
    partial class FrmSlideCorrectionExam
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSlideCorrectionExam));
            ucAnswersSlider1 = new UserControls.UcAnswersSlider();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // ucAnswersSlider1
            // 
            ucAnswersSlider1.Dock = DockStyle.Fill;
            ucAnswersSlider1.Location = new Point(0, 13);
            ucAnswersSlider1.MinimumSize = new Size(311, 245);
            ucAnswersSlider1.Name = "ucAnswersSlider1";
            ucAnswersSlider1.Size = new Size(381, 382);
            ucAnswersSlider1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 13);
            panel1.TabIndex = 1;
            // 
            // FrmSlideCorrectionExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 395);
            Controls.Add(ucAnswersSlider1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSlideCorrectionExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exame";
            Shown += FrmSlideCorrectionExam_Shown;
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UcAnswersSlider ucAnswersSlider1;
        private Panel panel1;
    }
}