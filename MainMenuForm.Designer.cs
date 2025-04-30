namespace Word_Memorizing_Game
{
    partial class MainMenuForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userDetails = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.addNewWordButton = new System.Windows.Forms.Button();
            this.examButton = new System.Windows.Forms.Button();
            this.wordleGameButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Main Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.userDetails);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 67);
            this.panel1.TabIndex = 1;
            // 
            // userDetails
            // 
            this.userDetails.AutoSize = true;
            this.userDetails.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userDetails.Location = new System.Drawing.Point(249, 18);
            this.userDetails.Name = "userDetails";
            this.userDetails.Size = new System.Drawing.Size(73, 31);
            this.userDetails.TabIndex = 3;
            this.userDetails.Text = "label1";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutButton.Location = new System.Drawing.Point(532, 18);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(127, 38);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // addNewWordButton
            // 
            this.addNewWordButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNewWordButton.Location = new System.Drawing.Point(12, 82);
            this.addNewWordButton.Name = "addNewWordButton";
            this.addNewWordButton.Size = new System.Drawing.Size(249, 71);
            this.addNewWordButton.TabIndex = 2;
            this.addNewWordButton.Text = "Add New Word";
            this.addNewWordButton.UseVisualStyleBackColor = true;
            this.addNewWordButton.Click += new System.EventHandler(this.addNewWordButton_Click);
            // 
            // examButton
            // 
            this.examButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.examButton.Location = new System.Drawing.Point(12, 186);
            this.examButton.Name = "examButton";
            this.examButton.Size = new System.Drawing.Size(249, 71);
            this.examButton.TabIndex = 3;
            this.examButton.Text = "Exam";
            this.examButton.UseVisualStyleBackColor = true;
            this.examButton.Click += new System.EventHandler(this.examButton_Click);
            // 
            // wordleGameButton
            // 
            this.wordleGameButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordleGameButton.Location = new System.Drawing.Point(12, 285);
            this.wordleGameButton.Name = "wordleGameButton";
            this.wordleGameButton.Size = new System.Drawing.Size(249, 71);
            this.wordleGameButton.TabIndex = 4;
            this.wordleGameButton.Text = "Wordle Game";
            this.wordleGameButton.UseVisualStyleBackColor = true;
            this.wordleGameButton.Click += new System.EventHandler(this.wordleGameButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingsButton.Location = new System.Drawing.Point(365, 83);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(249, 71);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(671, 448);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.wordleGameButton);
            this.Controls.Add(this.examButton);
            this.Controls.Add(this.addNewWordButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button addNewWordButton;
        private System.Windows.Forms.Label userDetails;
        private System.Windows.Forms.Button examButton;
        private System.Windows.Forms.Button wordleGameButton;
        private System.Windows.Forms.Button settingsButton;
    }
}