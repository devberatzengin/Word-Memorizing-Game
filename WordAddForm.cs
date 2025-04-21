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
    public partial class WordAddForm : Form
    {
        public WordAddForm()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();

        }

        private void WordAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        
    }
}
