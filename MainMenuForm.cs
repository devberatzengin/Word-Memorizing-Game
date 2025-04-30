using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word_Memorizing_Game.Properties;


namespace Word_Memorizing_Game
{
    public partial class MainMenuForm : Form
    {


        public User currentUser;


        public MainMenuForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            userDetails.Text = $"{user.UserName}       ID:{user.UserId}";
        }


            
        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginAndRegistrationForm loginForm = new LoginAndRegistrationForm();
            loginForm.Show();
            this.Hide();
        }
        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addNewWordButton_Click(object sender, EventArgs e)
        {
            WordAddForm wordAddForm = new WordAddForm(currentUser);
            wordAddForm.Show();
            this.Hide();

        }

        private void examButton_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm(currentUser);
            examForm.Show();
            this.Hide();
        }

        private void wordleGameButton_Click(object sender, EventArgs e)
        {
            WordleForm wordleForm = new WordleForm(currentUser);
            wordleForm.Show();  
            this.Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(currentUser);
            settingsForm.Show();
            this.Hide();
        } 
    }
}
