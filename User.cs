using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

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

            
        public void startExam()
        {
            
        }
    

    
    
    
    
    
    
    
    }
}
