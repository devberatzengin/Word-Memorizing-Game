﻿using System;
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
    public partial class ExamForm : Form
    {

        private User currentUser;
        public int CurrentWordId { get; set; }


        public ExamForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            currentUser.startExam(this);
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(currentUser);
            mainMenuForm.Show();
            this.Hide();
        }

        private void ExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkAnswerButton_Click(object sender, EventArgs e)
        {
            if (currentUser.maxQuestionCount > 1)
            {
                int selectedIndex = -1;

                if (option1Rb.Checked) selectedIndex = 0;
                else if (option2Rb.Checked) selectedIndex = 1;
                else if (option3Rb.Checked) selectedIndex = 2;
                else if (option4Rb.Checked) selectedIndex = 3;

                if (selectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir şık seçin.");
                    return;
                }

                int correctIndex = (int)this.Tag;

                if (selectedIndex == correctIndex)
                {
                    MessageBox.Show("Doğru cevap!");
                    currentUser.SaveProgress(currentUser.UserId, this.CurrentWordId);  
                    // Correct Counter ++
                    CorrectCounter.Text = "Correct: "+(int.Parse(CorrectCounter.Text.Split(':')[1]) + 1).ToString();
                }
                else
                {
                    MessageBox.Show("Yanlış cevap.");
                    // Wrong Counter ++
                    WrongCounter.Text = "Wrong: "+(int.Parse(WrongCounter.Text.Split(':')[1]) + 1).ToString();
                }

                currentUser.maxQuestionCount--; 
                currentUser.startExam(this);    
            }
            else
            {
                MessageBox.Show("Sınav tamamlandı.");
                checkAnswerButton.Enabled = false;
                option1Rb.Enabled = false;
                option2Rb.Enabled = false;
                option3Rb.Enabled = false;
                option4Rb.Enabled = false;
                return;
            }
        }

        
    }
}
