namespace TCFQ.WF
{
    partial class FrmOldResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOldResults));
            dgvResults = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            grbResult = new GroupBox();
            btnReviewEachAnswer = new Button();
            btnCopy = new Button();
            ucCorrection = new UserControls.UcAnswers();
            lblExamId = new Label();
            label9 = new Label();
            lblCreatedAt = new Label();
            label7 = new Label();
            lblPoints = new Label();
            label5 = new Label();
            lblLevel = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            panel1.SuspendLayout();
            grbResult.SuspendLayout();
            SuspendLayout();
            // 
            // dgvResults
            // 
            dgvResults.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(5, 41);
            dgvResults.Name = "dgvResults";
            dgvResults.Size = new Size(994, 201);
            dgvResults.TabIndex = 0;
            dgvResults.CellClick += dgvResults_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 35);
            panel1.TabIndex = 1;
            panel1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtros";
            // 
            // grbResult
            // 
            grbResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grbResult.Controls.Add(btnReviewEachAnswer);
            grbResult.Controls.Add(btnCopy);
            grbResult.Controls.Add(ucCorrection);
            grbResult.Controls.Add(lblExamId);
            grbResult.Controls.Add(label9);
            grbResult.Controls.Add(lblCreatedAt);
            grbResult.Controls.Add(label7);
            grbResult.Controls.Add(lblPoints);
            grbResult.Controls.Add(label5);
            grbResult.Controls.Add(lblLevel);
            grbResult.Controls.Add(label2);
            grbResult.Location = new Point(7, 250);
            grbResult.Name = "grbResult";
            grbResult.Size = new Size(990, 333);
            grbResult.TabIndex = 2;
            grbResult.TabStop = false;
            grbResult.Text = "[NOME_USUARIO]";
            // 
            // btnReviewEachAnswer
            // 
            btnReviewEachAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReviewEachAnswer.Location = new Point(851, 16);
            btnReviewEachAnswer.Name = "btnReviewEachAnswer";
            btnReviewEachAnswer.Size = new Size(133, 29);
            btnReviewEachAnswer.TabIndex = 11;
            btnReviewEachAnswer.Text = "Rever cada resposta";
            btnReviewEachAnswer.UseVisualStyleBackColor = true;
            btnReviewEachAnswer.Click += btnReviewEachAnswer_Click;
            // 
            // btnCopy
            // 
            btnCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopy.Location = new Point(765, 14);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(80, 31);
            btnCopy.TabIndex = 10;
            btnCopy.Text = "Copiar";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // ucCorrection
            // 
            ucCorrection.BackColor = Color.FromArgb(255, 255, 192);
            ucCorrection.Location = new Point(23, 60);
            ucCorrection.Name = "ucCorrection";
            ucCorrection.Size = new Size(943, 256);
            ucCorrection.TabIndex = 9;
            // 
            // lblExamId
            // 
            lblExamId.AutoSize = true;
            lblExamId.Location = new Point(91, 31);
            lblExamId.Name = "lblExamId";
            lblExamId.Size = new Size(19, 15);
            lblExamId.TabIndex = 8;
            lblExamId.Text = "99";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 31);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 7;
            label9.Text = "Exame Nº:";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Location = new Point(485, 31);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(110, 15);
            lblCreatedAt.TabIndex = 5;
            lblCreatedAt.Text = "31/12/2023 00:00:00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 31);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 4;
            label7.Text = "Realizado em:";
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Location = new Point(317, 31);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(25, 15);
            lblPoints.TabIndex = 3;
            lblPoints.Text = "699";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 31);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 2;
            label5.Text = "Pontuação:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(189, 31);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(23, 15);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "AA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 31);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "Nível:";
            // 
            // FrmOldResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 588);
            Controls.Add(grbResult);
            Controls.Add(panel1);
            Controls.Add(dgvResults);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmOldResults";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados anteriores";
            Shown += FrmOldResults_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbResult.ResumeLayout(false);
            grbResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResults;
        private Panel panel1;
        private Label label1;
        private GroupBox grbResult;
        private Label lblCreatedAt;
        private Label label7;
        private Label lblPoints;
        private Label label5;
        private Label lblLevel;
        private Label label2;
        private Label lblExamId;
        private Label label9;
        private UserControls.UcAnswers ucCorrection;
        private Button btnCopy;
        private Button btnReviewEachAnswer;
    }
}