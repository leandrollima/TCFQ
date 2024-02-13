using TCFQ.WF.UserControls;

namespace TCFQ.WF
{
    partial class FrmCorrectionExam
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
            panel1 = new Panel();
            lblExamName = new Label();
            pnlFooter = new Panel();
            btnSave = new Button();
            btnClose = new Button();
            btnCopyResult = new Button();
            ucCorrectionExam = new UcAnswers();
            panel1.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblExamName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 42);
            panel1.TabIndex = 4;
            // 
            // lblExamName
            // 
            lblExamName.AutoSize = true;
            lblExamName.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExamName.Location = new Point(10, 7);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(116, 27);
            lblExamName.TabIndex = 0;
            lblExamName.Text = "Exame #x";
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Controls.Add(btnCopyResult);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 409);
            pnlFooter.Margin = new Padding(3, 2, 3, 2);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(949, 41);
            pnlFooter.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(515, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 25);
            btnSave.TabIndex = 0;
            btnSave.Text = "Salvar resultados obtidos";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(835, 7);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(102, 27);
            btnClose.TabIndex = 2;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCopyResult
            // 
            btnCopyResult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyResult.Location = new Point(727, 7);
            btnCopyResult.Margin = new Padding(3, 2, 3, 2);
            btnCopyResult.Name = "btnCopyResult";
            btnCopyResult.Size = new Size(102, 27);
            btnCopyResult.TabIndex = 1;
            btnCopyResult.Text = "Copiar";
            btnCopyResult.UseVisualStyleBackColor = true;
            btnCopyResult.Click += btnCopyResult_Click;
            // 
            // ucCorrectionExam
            // 
            ucCorrectionExam.BackColor = Color.FromArgb(255, 255, 192);
            ucCorrectionExam.Dock = DockStyle.Fill;
            ucCorrectionExam.Location = new Point(0, 42);
            ucCorrectionExam.Name = "ucCorrectionExam";
            ucCorrectionExam.Size = new Size(949, 367);
            ucCorrectionExam.TabIndex = 7;
            // 
            // FrmCorrectionExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 450);
            Controls.Add(ucCorrectionExam);
            Controls.Add(pnlFooter);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCorrectionExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Correção";
            Shown += FrmCorrectionExam_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel1;
        private Button btnClose;
        private Button btnCopyResult;
        protected Label lblExamName;
        protected Panel pnlFooter;

        #endregion

        private UcAnswers ucCorrectionExam;
        private Button btnSave;
    }
}