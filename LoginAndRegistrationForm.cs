using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Memorizing_Game
{
    public partial class LoginAndRegistrationForm : Form
    {

        public LoginAndRegistrationForm()
        {
            InitializeComponent();
        }

        private void LoginAndRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginUsernameTb.Text) || string.IsNullOrWhiteSpace(loginPasswordTb.Text))
            {
                MessageBox.Show("Lütfen boş bırakmayınız!");
                return;
            }

            User user = new User();
            bool isLoggedIn = user.Login(loginUsernameTb.Text.Trim(), loginPasswordTb.Text.Trim());

            if (isLoggedIn)
            {
                MessageBox.Show($"Giriş Başarılı! Hoş geldin, {user.UserName} (ID: {user.UserId})");
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız. Lütfen bilgileri kontrol ediniz.");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(registerUsernameTb.Text) || string.IsNullOrWhiteSpace(registerPasswordTb.Text))
            {
                MessageBox.Show("Lütfen boş bırakmayınız!");
                return;
            }

            User user = new User();
            bool isRegistered = user.Register(registerUsernameTb.Text.Trim(), registerPasswordTb.Text.Trim(), out string message);

            MessageBox.Show(message);
        }
    }
}
