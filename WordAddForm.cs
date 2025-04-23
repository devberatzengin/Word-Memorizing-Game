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



        private readonly string connectionString = "Data Source=BERATZ\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True";





        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(engWordNameTb.Text) || string.IsNullOrWhiteSpace(turWordNameTb.Text) || string.IsNullOrWhiteSpace(wordPicLocationTb.Text) || string.IsNullOrWhiteSpace(sampleSentTb.Text))
            {
                MessageBox.Show("Lütfen hicbir alanı bos birakmayiniz!");
                return;
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand checkWordCommand = new SqlCommand("SELECT COUNT(*) FROM tblWords WHERE EngWordName = @wordName", connection);
                checkWordCommand.Parameters.AddWithValue("@wordName", engWordNameTb.Text);

                int wordExists = (int)checkWordCommand.ExecuteScalar();

                if (wordExists > 0)
                {
                    MessageBox.Show("Bu kelime zaten mevcut!");
                    return;
                }

                SqlCommand getMaxIdCommand = new SqlCommand("SELECT ISNULL(MAX(WordID), 0) FROM tblWords", connection);
                int nextId = (int)getMaxIdCommand.ExecuteScalar() + 1;
                
                
                SqlCommand insertCommand = new SqlCommand("INSERT INTO tblWords (WordID, EngWordName, TurWordName, Picture) VALUES (@id, @engWordName, @turWordName, @wordPicLocation)", connection);
                insertCommand.Parameters.AddWithValue("@id", nextId);
                insertCommand.Parameters.AddWithValue("@engWordName", engWordNameTb.Text);
                insertCommand.Parameters.AddWithValue("@turWordName", turWordNameTb.Text);
                insertCommand.Parameters.AddWithValue("@wordPicLocation", wordPicLocationTb.Text);


                SqlCommand insertSampleCommand = new SqlCommand("INSERT INTO tblWordSamples (Samples, WordID) VALUES (@sampleSentence, @wordId)", connection);
                insertSampleCommand.Parameters.AddWithValue("@sampleSentence", sampleSentTb.Text);
                insertSampleCommand.Parameters.AddWithValue("@wordId", nextId);



                int result = insertCommand.ExecuteNonQuery();
                int sampleResult = insertSampleCommand.ExecuteNonQuery();


                if (result > 0)
                {
                    MessageBox.Show("Kelime başarıyla eklendi!");
                }
                else
                {
                    MessageBox.Show("Kelime eklenirken bir hata oluştu.");
                }
                
                if (sampleResult > 0)
                {
                    MessageBox.Show("Örnek cümle başarıyla eklendi!");
                }
                else
                {
                    MessageBox.Show("Örnek cümle eklenirken bir hata oluştu.");
                }





            }
            
        }
    }
}

