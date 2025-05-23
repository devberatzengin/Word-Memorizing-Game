namespace Word_Memorizing_Game
{
    partial class ExamForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.engWordLabel = new System.Windows.Forms.Label();
            this.exampleSentenceLabel = new System.Windows.Forms.Label();
            this.option1Rb = new System.Windows.Forms.RadioButton();
            this.option2Rb = new System.Windows.Forms.RadioButton();
            this.option3Rb = new System.Windows.Forms.RadioButton();
            this.option4Rb = new System.Windows.Forms.RadioButton();
            this.checkAnswerButton = new System.Windows.Forms.Button();
            this.wordPictureBox = new System.Windows.Forms.PictureBox();
            this.CorrectCounter = new System.Windows.Forms.Label();
            this.WrongCounter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.mainMenuButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 3;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainMenuButton.Location = new System.Drawing.Point(650, 15);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(138, 38);
            this.mainMenuButton.TabIndex = 2;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time to Learn";
            // 
            // engWordLabel
            // 
            this.engWordLabel.AutoSize = true;
            this.engWordLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18.8F, System.Drawing.FontStyle.Bold);
            this.engWordLabel.Location = new System.Drawing.Point(20, 103);
            this.engWordLabel.Name = "engWordLabel";
            this.engWordLabel.Size = new System.Drawing.Size(213, 45);
            this.engWordLabel.TabIndex = 4;
            this.engWordLabel.Text = "English Word";
            // 
            // exampleSentenceLabel
            // 
            this.exampleSentenceLabel.AutoSize = true;
            this.exampleSentenceLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.exampleSentenceLabel.Location = new System.Drawing.Point(23, 168);
            this.exampleSentenceLabel.Name = "exampleSentenceLabel";
            this.exampleSentenceLabel.Size = new System.Drawing.Size(303, 25);
            this.exampleSentenceLabel.TabIndex = 6;
            this.exampleSentenceLabel.Text = "Example sentence for english word";
            // 
            // option1Rb
            // 
            this.option1Rb.AutoSize = true;
            this.option1Rb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.option1Rb.Location = new System.Drawing.Point(28, 230);
            this.option1Rb.Name = "option1Rb";
            this.option1Rb.Size = new System.Drawing.Size(202, 35);
            this.option1Rb.TabIndex = 8;
            this.option1Rb.TabStop = true;
            this.option1Rb.Text = "Turkish Option 1";
            this.option1Rb.UseVisualStyleBackColor = true;
            // 
            // option2Rb
            // 
            this.option2Rb.AutoSize = true;
            this.option2Rb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.option2Rb.Location = new System.Drawing.Point(28, 271);
            this.option2Rb.Name = "option2Rb";
            this.option2Rb.Size = new System.Drawing.Size(206, 35);
            this.option2Rb.TabIndex = 9;
            this.option2Rb.TabStop = true;
            this.option2Rb.Text = "Turkish Option 2";
            this.option2Rb.UseVisualStyleBackColor = true;
            // 
            // option3Rb
            // 
            this.option3Rb.AutoSize = true;
            this.option3Rb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.option3Rb.Location = new System.Drawing.Point(28, 312);
            this.option3Rb.Name = "option3Rb";
            this.option3Rb.Size = new System.Drawing.Size(206, 35);
            this.option3Rb.TabIndex = 10;
            this.option3Rb.TabStop = true;
            this.option3Rb.Text = "Turkish Option 3";
            this.option3Rb.UseVisualStyleBackColor = true;
            // 
            // option4Rb
            // 
            this.option4Rb.AutoSize = true;
            this.option4Rb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.option4Rb.Location = new System.Drawing.Point(28, 353);
            this.option4Rb.Name = "option4Rb";
            this.option4Rb.Size = new System.Drawing.Size(206, 35);
            this.option4Rb.TabIndex = 11;
            this.option4Rb.TabStop = true;
            this.option4Rb.Text = "Turkish Option 4";
            this.option4Rb.UseVisualStyleBackColor = true;
            // 
            // checkAnswerButton
            // 
            this.checkAnswerButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkAnswerButton.Location = new System.Drawing.Point(418, 390);
            this.checkAnswerButton.Name = "checkAnswerButton";
            this.checkAnswerButton.Size = new System.Drawing.Size(331, 48);
            this.checkAnswerButton.TabIndex = 12;
            this.checkAnswerButton.Text = "Check and next question";
            this.checkAnswerButton.UseVisualStyleBackColor = true;
            this.checkAnswerButton.Click += new System.EventHandler(this.checkAnswerButton_Click);
            // 
            // wordPictureBox
            // 
            this.wordPictureBox.Location = new System.Drawing.Point(418, 168);
            this.wordPictureBox.Name = "wordPictureBox";
            this.wordPictureBox.Size = new System.Drawing.Size(331, 196);
            this.wordPictureBox.TabIndex = 13;
            this.wordPictureBox.TabStop = false;
            // 
            // CorrectCounter
            // 
            this.CorrectCounter.AutoSize = true;
            this.CorrectCounter.BackColor = System.Drawing.Color.Silver;
            this.CorrectCounter.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CorrectCounter.ForeColor = System.Drawing.Color.ForestGreen;
            this.CorrectCounter.Location = new System.Drawing.Point(415, 103);
            this.CorrectCounter.Name = "CorrectCounter";
            this.CorrectCounter.Size = new System.Drawing.Size(116, 31);
            this.CorrectCounter.TabIndex = 14;
            this.CorrectCounter.Text = "Correct: 0";
            // 
            // WrongCounter
            // 
            this.WrongCounter.AutoSize = true;
            this.WrongCounter.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WrongCounter.ForeColor = System.Drawing.Color.Tomato;
            this.WrongCounter.Location = new System.Drawing.Point(595, 103);
            this.WrongCounter.Name = "WrongCounter";
            this.WrongCounter.Size = new System.Drawing.Size(110, 31);
            this.WrongCounter.TabIndex = 15;
            this.WrongCounter.Text = "Wrong: 0";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WrongCounter);
            this.Controls.Add(this.CorrectCounter);
            this.Controls.Add(this.wordPictureBox);
            this.Controls.Add(this.checkAnswerButton);
            this.Controls.Add(this.option4Rb);
            this.Controls.Add(this.option3Rb);
            this.Controls.Add(this.option2Rb);
            this.Controls.Add(this.option1Rb);
            this.Controls.Add(this.exampleSentenceLabel);
            this.Controls.Add(this.engWordLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label exampleSentenceLabel;
        public System.Windows.Forms.Label engWordLabel;
        public System.Windows.Forms.RadioButton option1Rb;
        public System.Windows.Forms.RadioButton option2Rb;
        public System.Windows.Forms.RadioButton option3Rb;
        public System.Windows.Forms.RadioButton option4Rb;
        public System.Windows.Forms.PictureBox wordPictureBox;
        public System.Windows.Forms.Button checkAnswerButton;
        private System.Windows.Forms.Label CorrectCounter;
        private System.Windows.Forms.Label WrongCounter;
    }
}