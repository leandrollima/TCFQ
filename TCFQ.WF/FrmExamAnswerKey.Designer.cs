namespace TCFQ.WF
{
    partial class FrmExamAnswerKey
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
            btnClose = new Button();
            btnCopyResult = new Button();
            ucExAnsKey = new UserControls.UcAnswers();
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
            panel1.Size = new Size(957, 42);
            panel1.TabIndex = 7;
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
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Controls.Add(btnCopyResult);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 409);
            pnlFooter.Margin = new Padding(3, 2, 3, 2);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(957, 41);
            pnlFooter.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(847, 7);
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
            btnCopyResult.Location = new Point(739, 7);
            btnCopyResult.Margin = new Padding(3, 2, 3, 2);
            btnCopyResult.Name = "btnCopyResult";
            btnCopyResult.Size = new Size(102, 27);
            btnCopyResult.TabIndex = 1;
            btnCopyResult.Text = "Copiar";
            btnCopyResult.UseVisualStyleBackColor = true;
            btnCopyResult.Click += btnCopyResult_Click;
            // 
            // ucExAnsKey
            // 
            ucExAnsKey.BackColor = Color.FromArgb(255, 255, 192);
            ucExAnsKey.Dock = DockStyle.Fill;
            ucExAnsKey.Location = new Point(0, 42);
            ucExAnsKey.Name = "ucExAnsKey";
            ucExAnsKey.Size = new Size(957, 367);
            ucExAnsKey.TabIndex = 10;
            // 
            // FrmExamAnswerKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 450);
            Controls.Add(ucExAnsKey);
            Controls.Add(panel1);
            Controls.Add(pnlFooter);
            MaximizeBox = false;
            Name = "FrmExamAnswerKey";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gabarito do Exame";
            Shown += FrmExamAnswerKey_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        protected Label lblExamName;
        protected Panel pnlFooter;
        private Button btnClose;
        private Button btnCopyResult;
        private UserControls.UcAnswers ucExAnsKey;
    }
}