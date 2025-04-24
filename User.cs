using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Drawing;

namespace Word_Memorizing_Game
{
    public class User
    {
        public int UserId { get; private set; }
        public string UserName { get; private set; }
        public string UserPassword { get; private set; }

        private readonly string connectionString = "Data Source=BERATZ\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True";

        public bool Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId, UserName, UserPassword FROM tblUser WHERE UserName = @username AND UserPassword = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.UserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                    this.UserName = dt.Rows[0]["UserName"].ToString();
                    this.UserPassword = dt.Rows[0]["UserPassword"].ToString();
                    return true;
                }

                return false;
            }
        }

        public bool Register(string username, string password, out string message)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM tblUser WHERE UserName = @username", connection);
                checkUser.Parameters.AddWithValue("@username", username);

                int exists = (int)checkUser.ExecuteScalar();
                if (exists > 0)
                {
                    message = "Bu kullanıcı adı zaten alınmış!";
                    return false;
                }

                SqlCommand getMaxId = new SqlCommand("SELECT ISNULL(MAX(UserId), 0) FROM tblUser", connection);
                int nextId = (int)getMaxId.ExecuteScalar() + 1;

                SqlCommand insert = new SqlCommand("INSERT INTO tblUser (UserId, UserName, UserPassword) VALUES (@id, @username, @password)", connection);
                insert.Parameters.AddWithValue("@id", nextId);
                insert.Parameters.AddWithValue("@username", username);
                insert.Parameters.AddWithValue("@password", password);

                int result = insert.ExecuteNonQuery();

                if (result > 0)
                {
                    message = "Kayıt başarılı!";
                    return true;
                }
                else
                {
                    message = "Kayıt başarısız. Lütfen tekrar deneyin.";
                    return false;
                }
            }
        }

        public void startExam(ExamForm form)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string maxwordcountQuery = "SELECT COUNT(*) FROM tblWords";
                SqlCommand maxwordcountCommand = new SqlCommand(maxwordcountQuery, connection);
                int maxWordCount = (int)maxwordcountCommand.ExecuteScalar();

                Random rnd = new Random();
                int randomWordId = rnd.Next(1, maxWordCount);
                form.CurrentWordId = randomWordId;

                string wordQuery = "SELECT WordID, EngWordName, TurWordName, Picture FROM tblWords WHERE WordID = @wordid";
                SqlCommand wordCommand = new SqlCommand(wordQuery, connection);
                wordCommand.Parameters.AddWithValue("@wordid", randomWordId);

                SqlDataReader reader = wordCommand.ExecuteReader();

                string picturePath = "";
                string engWord = "";
                string correctTurWord = "";

                if (reader.Read())
                {
                    engWord = reader["EngWordName"].ToString();
                    correctTurWord = reader["TurWordName"].ToString();
                    picturePath = reader["Picture"].ToString();
                }
                reader.Close();

                if (File.Exists(picturePath))
                {
                    form.wordPictureBox.Image = Image.FromFile(picturePath);
                }
                else
                {
                    form.wordPictureBox.Image = null; 
                }


                string sentenceQuery = "SELECT Samples FROM tblWordSamples WHERE WordID = @wordid";
                
                SqlCommand sentenceCommand = new SqlCommand(sentenceQuery, connection);
                sentenceCommand.Parameters.AddWithValue("@wordid", randomWordId);
                
                
                string sampleSentence = sentenceCommand.ExecuteScalar()?.ToString() ?? "No sample available.";

                string distractorsQuery = @"
                                            SELECT TOP 3 TurWordName 
                                            FROM tblWords 
                                            WHERE WordID != @wordid 
                                            ORDER BY NEWID()";

                SqlCommand distractorsCommand = new SqlCommand(distractorsQuery, connection);
                distractorsCommand.Parameters.AddWithValue("@wordid", randomWordId);

                List<string> options = new List<string>();
                
                SqlDataReader distractorReader = distractorsCommand.ExecuteReader();
                
                while (distractorReader.Read())
                {
                    options.Add(distractorReader["TurWordName"].ToString());
                }
                
                distractorReader.Close();


                int correctIndex = rnd.Next(0, 4);
                options.Insert(correctIndex, correctTurWord);

                form.engWordLabel.Text = engWord;
                form.exampleSentenceLabel.Text = sampleSentence;
                form.option1Rb.Text = options[0];
                form.option2Rb.Text = options[1];
                form.option3Rb.Text = options[2];
                form.option4Rb.Text = options[3];

                
                form.Tag = correctIndex;             
            }
        }

        public void SaveProgress(int userId, int wordId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT CorrectCount FROM tblWordProgress WHERE UserID = @uid AND WordID = @wid";
                SqlCommand selectCmd = new SqlCommand(selectQuery, connection);
                selectCmd.Parameters.AddWithValue("@uid", userId);
                selectCmd.Parameters.AddWithValue("@wid", wordId);

                SqlDataReader reader = selectCmd.ExecuteReader();
                bool exists = reader.HasRows;
                int count = 0;
                if (exists && reader.Read())
                {
                    count = Convert.ToInt32(reader["CorrectCount"]);
                }
                reader.Close();

                count += 1;
                DateTime now = DateTime.Now;


                int[] daySteps = { 1, 7, 30, 90, 180, 365 };
                DateTime nextDate = now.AddDays(daySteps[Math.Min(count - 1, 5)]);
                bool isLearned = count >= 6;

                if (exists)
                {
                    string update = @"UPDATE tblWordProgress SET 
                              CorrectCount = @cnt, 
                              LastCorrectDate = @now, 
                              NextTestDate = @next, 
                              IsLearned = @learned
                              WHERE UserID = @userid AND WordID = @wordid";
                    
                    SqlCommand cmd = new SqlCommand(update, connection);
                    
                    cmd.Parameters.AddWithValue("@cnt", count);
                    cmd.Parameters.AddWithValue("@now", now);
                    cmd.Parameters.AddWithValue("@next", nextDate);
                    cmd.Parameters.AddWithValue("@learned", isLearned);
                    cmd.Parameters.AddWithValue("@userid", userId);
                    cmd.Parameters.AddWithValue("@wordid", wordId);
                    
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string insert = @"INSERT INTO tblWordProgress 
                              (UserID, WordID, CorrectCount, LastCorrectDate, NextTestDate, IsLearned) 
                              VALUES (@userid, @wordid, @cnt, @now, @next, @learned)";
                    SqlCommand cmd = new SqlCommand(insert, connection);
                    cmd.Parameters.AddWithValue("@userid", userId);
                    cmd.Parameters.AddWithValue("@wordid", wordId);
                    cmd.Parameters.AddWithValue("@cnt", count);
                    cmd.Parameters.AddWithValue("@now", now);
                    cmd.Parameters.AddWithValue("@next", nextDate);
                    cmd.Parameters.AddWithValue("@learned", isLearned);
                    cmd.ExecuteNonQuery();
                }
            }
        }






    }
}
