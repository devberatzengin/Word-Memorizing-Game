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
    public partial class SettingsForm : Form
    {
        User currentUser;
        public SettingsForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
       

        private void logoutButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(currentUser);
            mainMenuForm.Show();
            this.Hide();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            currentUser.setMaxQuestionCount((int)numericUpDown1.Value);
        }

        private void resetProgressButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=BERATZ\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True"))
            {
                connection.Open();
                string query = "update tblWordProgress set CorrectCount = 0 , IsLearned = 0 where UserID = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", currentUser.UserId);
                command.ExecuteNonQuery();
                MessageBox.Show($"Kullanici adi:{currentUser.UserName}\n Kullanici Id:{currentUser.UserId} \n" +
                    $"Ilerlemesi başarıyla sıfırlandı.");
            }

        }
    }
}
