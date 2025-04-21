namespace Word_Memorizing_Game
{
    partial class LoginAndRegistrationForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPasswordTb = new System.Windows.Forms.TextBox();
            this.loginUsernameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerPasswordTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.registerUsernameTb = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login And Registration";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.loginPasswordTb);
            this.panel2.Controls.Add(this.loginUsernameTb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 343);
            this.panel2.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.Location = new System.Drawing.Point(164, 263);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(138, 48);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPasswordTb
            // 
            this.loginPasswordTb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginPasswordTb.Location = new System.Drawing.Point(164, 198);
            this.loginPasswordTb.Name = "loginPasswordTb";
            this.loginPasswordTb.Size = new System.Drawing.Size(162, 34);
            this.loginPasswordTb.TabIndex = 2;
            // 
            // loginUsernameTb
            // 
            this.loginUsernameTb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginUsernameTb.Location = new System.Drawing.Point(164, 105);
            this.loginUsernameTb.Name = "loginUsernameTb";
            this.loginUsernameTb.Size = new System.Drawing.Size(162, 34);
            this.loginUsernameTb.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 62);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.registerButton);
            this.panel3.Controls.Add(this.registerPasswordTb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.registerUsernameTb);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(420, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 343);
            this.panel3.TabIndex = 2;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerButton.Location = new System.Drawing.Point(156, 263);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(138, 48);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerPasswordTb
            // 
            this.registerPasswordTb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerPasswordTb.Location = new System.Drawing.Point(156, 200);
            this.registerPasswordTb.Name = "registerPasswordTb";
            this.registerPasswordTb.Size = new System.Drawing.Size(162, 34);
            this.registerPasswordTb.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password:";
            // 
            // registerUsernameTb
            // 
            this.registerUsernameTb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerUsernameTb.Location = new System.Drawing.Point(156, 105);
            this.registerUsernameTb.Name = "registerUsernameTb";
            this.registerUsernameTb.Size = new System.Drawing.Size(162, 34);
            this.registerUsernameTb.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 62);
            this.panel5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username:";
            // 
            // LoginAndRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginAndRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login And Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginAndRegistrationForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox loginPasswordTb;
        private System.Windows.Forms.TextBox loginUsernameTb;
        private System.Windows.Forms.TextBox registerPasswordTb;
        private System.Windows.Forms.TextBox registerUsernameTb;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
    }
}

