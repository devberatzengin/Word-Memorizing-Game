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

            SqlConnection sqlConnection = new SqlConnection("Data Source=BERATZ\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT UserName, UserPassword FROM tblUser WHERE UserName = @username AND UserPassword = @password", sqlConnection);

            // Parametreler
            sqlCommand.Parameters.AddWithValue("@username", loginUsernameTb.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@password", loginPasswordTb.Text.Trim());

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            // Kullanıcı kontrol 
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(registerUsernameTb.Text) || string.IsNullOrWhiteSpace(registerPasswordTb.Text))
            {
                MessageBox.Show("Lütfen boş bırakmayınız!");
                return;
            }

            SqlConnection sqlConnection = new SqlConnection("Data Source=BERATZ\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True");
            sqlConnection.Open();

            // Kullanıcı kontrol 
            SqlCommand checkUserCommand = new SqlCommand("SELECT COUNT(*) FROM tblUser WHERE UserName = @username", sqlConnection);
            checkUserCommand.Parameters.AddWithValue("@username", registerUsernameTb.Text.Trim());
            int userExists = (int)checkUserCommand.ExecuteScalar();

            if (userExists > 0)
            {
                MessageBox.Show("Bu kullanıcı adı zaten alınmış!");
                return;
            }

            // Max UserId'i al
            SqlCommand getMaxIdCommand = new SqlCommand("SELECT ISNULL(MAX(UserId), 0) FROM tblUser", sqlConnection);
            int nextUserId = (int)getMaxIdCommand.ExecuteScalar() + 1;

            // Yeni kullanıcıyı ekle
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO tblUser (UserId, UserName, UserPassword) VALUES (@id, @username, @password)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", nextUserId);
            sqlCommand.Parameters.AddWithValue("@username", registerUsernameTb.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@password", registerPasswordTb.Text.Trim());

            int result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız. Lütfen tekrar deneyin.");
            }
        }
    }
}
