using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Memorizing_Game
{
    public partial class WordleForm : Form
    {


        private User currentUser;
        public int CurrentWordId { get; set; }
        public WordleForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            currentUser.startGame(this);
            //test Code
            //this.textBox1.Text = " " + currentUser.UserName[0].ToString();
        }

        private void WordleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(currentUser);
            mainMenuForm.Show();
            this.Hide();
        }

        
    }
}
