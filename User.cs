using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Word_Memorizing_Game
{
    public class User
    {
        public int UserId { get; private set; }
        public string UserName { get; private set; }
        public string UserPassword { get; private set; }

        public int maxQuestionCount = 10;

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

        public void startGame(WordleForm wordleForm)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string maxwordcountQuery = "SELECT COUNT(*) FROM tblWords";
                SqlCommand maxwordcountCommand = new SqlCommand(maxwordcountQuery, connection);
                int maxWordCount = (int)maxwordcountCommand.ExecuteScalar();

                Random rnd = new Random();
                int randomWordId = rnd.Next(1, maxWordCount);
                wordleForm.CurrentWordId = randomWordId;

                string wordQuery = "SELECT WordID, EngWordName, len(EngWordName) as 'lenght' FROM tblWords WHERE WordID = @wordid";
                SqlCommand wordCommand = new SqlCommand(wordQuery, connection);
                wordCommand.Parameters.AddWithValue("@wordid", randomWordId);

                SqlDataReader reader = wordCommand.ExecuteReader();

                string engWord = "";
                string engWordLenght = "";
                int wordLenght = 0;
                if (reader.Read())
                {
                    engWord = reader["EngWordName"].ToString();
                    engWordLenght = reader["lenght"].ToString();
                }
                wordLenght = Convert.ToInt32(engWordLenght);

                reader.Close();

                // FlowLayoutPanel'in boyutunu kelime uzunluğuna göre ayarla
                wordleForm.flowLayoutPanel1.Width = wordLenght * 65 + 10;

                int attempts = 0;

                // Button click event
                wordleForm.submitButton.Click += (sender, e) =>
                {
                    if (attempts >= 5) return; 

                    string userInput = wordleForm.inputTb.Text.ToUpper();  
                    if (userInput.Length == wordLenght)
                    {
                        for (int i = 0; i < wordLenght; i++)
                        {
                            TextBox textBox = (TextBox)wordleForm.flowLayoutPanel1.Controls[attempts * wordLenght + i];
                            char userChar = userInput[i];
                            char actualChar = char.ToUpper(engWord[i]); 

                            // if letter and pozission is correct
                            if (userChar == actualChar)
                            {
                                if (textBox.BackColor != Color.FromArgb(11, 163, 0))
                                {
                                    textBox.BackColor = Color.FromArgb(11, 163, 0);
                                    textBox.Text = userChar.ToString();  
                                }
                            }
                            // if correct letter wrong position 
                            else if (engWord.ToUpper().Contains(userChar.ToString()))
                            {
                                textBox.BackColor = Color.FromArgb(255, 213, 61);
                                textBox.Text = userChar.ToString();
                            }
                            // if letter isnt correct
                            else
                            {
                                textBox.BackColor = Color.Gray;
                                textBox.Text = "";  
                            }
                        }

                        attempts++; 

                        if (userInput.Equals(engWord, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Tebrikler! Doğru tahmin!");
                        }

                        if (attempts < 5)
                        {
                            CreateNewTextBoxes(wordleForm, wordLenght, attempts);
                        }
                    }
                };

                CreateNewTextBoxes(wordleForm, wordLenght, attempts);
            }
        }

        private void CreateNewTextBoxes(WordleForm wordleForm, int wordLength, int attempts)
        {
            int count = attempts * wordLength + 1;

            for (int i = 1; i <= wordLength; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Name = "textBox" + count;
                textBox.Size = new Size(60, 60);
                textBox.Font = new Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
                textBox.MaxLength = 1;
                textBox.TextAlign = HorizontalAlignment.Center;
                textBox.BackColor = Color.LightGray;
                textBox.BorderStyle = BorderStyle.None;
                textBox.Location = new Point(10 + (i - 1) * 60, 10 + attempts * 60); // Yeni satır
                textBox.ReadOnly = false;  // Kullanıcının yazabilmesi için false
                textBox.Text = " ";
                textBox.Visible = true;
                textBox.Enabled = true;  // Kullanıcı girebilir
                wordleForm.flowLayoutPanel1.Controls.Add(textBox);
                count++;
            }
        }

        public void setMaxQuestionCount(int maxQuestionCount)
        {
            if (maxQuestionCount < 1 || maxQuestionCount > 100)
            {
                MessageBox.Show("Lütfen 1 ile 100 arasında bir değer girin.");
                return;
            }else
            {
                this.maxQuestionCount = maxQuestionCount;
                MessageBox.Show("Soru sayısı başarıyla ayarlandı.");
            }
        }

    }
}
