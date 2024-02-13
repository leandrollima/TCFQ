namespace TCFQ.WF
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnLoad = new Button();
            label1 = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            cmbExams = new ComboBox();
            txtUserName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            btnResultWithHighlight = new Button();
            btnViewPartialResult = new Button();
            btnOldResults = new Button();
            btnTestAnswer = new Button();
            btnResult = new Button();
            ucQuestionSlider1 = new UserControls.UcQuestionSlider();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(151, 45);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 28);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Iniciar";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 52);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Exame:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cmbExams);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 89);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(163, 56);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 28);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbExams
            // 
            cmbExams.FormattingEnabled = true;
            cmbExams.Location = new Point(74, 49);
            cmbExams.Name = "cmbExams";
            cmbExams.Size = new Size(60, 23);
            cmbExams.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(74, 12);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(152, 23);
            txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 14);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnResultWithHighlight);
            panel2.Controls.Add(btnViewPartialResult);
            panel2.Controls.Add(btnOldResults);
            panel2.Controls.Add(btnTestAnswer);
            panel2.Controls.Add(btnResult);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 470);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 109);
            panel2.TabIndex = 2;
            // 
            // btnResultWithHighlight
            // 
            btnResultWithHighlight.Location = new Point(10, 8);
            btnResultWithHighlight.Margin = new Padding(3, 2, 3, 2);
            btnResultWithHighlight.Name = "btnResultWithHighlight";
            btnResultWithHighlight.Size = new Size(224, 28);
            btnResultWithHighlight.TabIndex = 4;
            btnResultWithHighlight.Text = "Acompanhar com gabarito";
            btnResultWithHighlight.UseVisualStyleBackColor = true;
            btnResultWithHighlight.Click += btnResultWithHighlight_Click;
            // 
            // btnViewPartialResult
            // 
            btnViewPartialResult.Location = new Point(10, 41);
            btnViewPartialResult.Margin = new Padding(3, 2, 3, 2);
            btnViewPartialResult.Name = "btnViewPartialResult";
            btnViewPartialResult.Size = new Size(109, 28);
            btnViewPartialResult.TabIndex = 0;
            btnViewPartialResult.Text = "Result. parcial";
            btnViewPartialResult.UseVisualStyleBackColor = true;
            btnViewPartialResult.Click += btnViewPartialResult_Click;
            // 
            // btnOldResults
            // 
            btnOldResults.Location = new Point(125, 73);
            btnOldResults.Name = "btnOldResults";
            btnOldResults.Size = new Size(109, 28);
            btnOldResults.TabIndex = 3;
            btnOldResults.Text = "Anteriores";
            btnOldResults.UseVisualStyleBackColor = true;
            btnOldResults.Click += btnOldResults_Click;
            // 
            // btnTestAnswer
            // 
            btnTestAnswer.Location = new Point(10, 73);
            btnTestAnswer.Name = "btnTestAnswer";
            btnTestAnswer.Size = new Size(109, 28);
            btnTestAnswer.TabIndex = 2;
            btnTestAnswer.Text = "Gabarito";
            btnTestAnswer.UseVisualStyleBackColor = true;
            btnTestAnswer.Click += btnTestAnswer_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(125, 40);
            btnResult.Margin = new Padding(3, 2, 3, 2);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(109, 28);
            btnResult.TabIndex = 1;
            btnResult.Text = "Correção";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // ucQuestionSlider1
            // 
            ucQuestionSlider1.BorderStyle = BorderStyle.Fixed3D;
            ucQuestionSlider1.Dock = DockStyle.Fill;
            ucQuestionSlider1.Location = new Point(0, 89);
            ucQuestionSlider1.MinimumSize = new Size(206, 318);
            ucQuestionSlider1.Name = "ucQuestionSlider1";
            ucQuestionSlider1.ParcialResultVisible = true;
            ucQuestionSlider1.Size = new Size(243, 381);
            ucQuestionSlider1.TabIndex = 1;
            ucQuestionSlider1.ExamFinished += ucQuestionSlider1_ExamFinished;
            ucQuestionSlider1.ChangeQuestion += ucQuestionSlider1_ChangeQuestion;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 579);
            Controls.Add(ucQuestionSlider1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TCFQ Compreensão Oral";
            Shown += FrmMain_Shown;
            KeyPress += FrmMain_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnLoad;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnResult;
        private TextBox txtUserName;
        private Label label2;
        private Button btnTestAnswer;
        private Button btnOldResults;
        private UserControls.UcQuestionSlider ucQuestionSlider1;
        private Button btnViewPartialResult;
        private ComboBox cmbExams;
        private Button btnCancel;
        private Button btnResultWithHighlight;
    }
}