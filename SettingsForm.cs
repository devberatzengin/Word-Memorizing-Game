using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
                string query = "update tblWordProgress set CorrectCount = 0 , IsLearned = 0 , LastCorrectDate =null, NextTestDate = null where UserID = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", currentUser.UserId);
                command.ExecuteNonQuery();
                MessageBox.Show($"Kullanici adi:{currentUser.UserName}\n Kullanici Id:{currentUser.UserId} \n" +
                    $"Ilerlemesi başarıyla sıfırlandı.");
            }

        }

        private void ReportPdfButton_Click(object sender, EventArgs e)
        {
            ExportReportToPDF();
        }


        private void ExportReportToPDF()
        {
            // Reports Location
            string reportsFolder = Path.Combine(Application.StartupPath, "Reports");
            if (!Directory.Exists(reportsFolder))
                Directory.CreateDirectory(reportsFolder);

            // File Name
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            string fileName = $"{currentUser.UserName}_{timestamp}.pdf";
            string fullPath = Path.Combine(reportsFolder, fileName);

            Document doc = new Document(PageSize.A4);

            PdfWriter.GetInstance(doc, new FileStream(fullPath, FileMode.Create));
            doc.Open();

            var titleFont = FontFactory.GetFont("Arial", 16.ToString(), Font.Bold);
            var cellFont = FontFactory.GetFont("Arial", 12.ToString(), Font.Italic);

            doc.Add(new Paragraph("User Reports"+$" {DateTime.Now.ToString()}", titleFont));
            doc.Add(new Paragraph(" ", cellFont));


            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.AddCell("User Id");
            table.AddCell("Word Level");
            table.AddCell("Total Words");
            table.AddCell("Succes Rate(%)");

            // Get values from database
            using (SqlConnection con = new SqlConnection("Data Source=BERATZ\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True"))
            {
                con.Open();
                string query = @"
            SELECT 
                wp.UserID, 
                w.WordLevel,
                COUNT(*) as TotalWords,
                SUM(CASE WHEN wp.CorrectCount > 0 THEN 1 ELSE 0 END) as CorrectAnswers,
                CAST(SUM(CASE WHEN wp.CorrectCount > 0 THEN 1 ELSE 0 END) * 100.0 / COUNT(*) AS DECIMAL(5,1)) as SuccessRate
            FROM tblWordProgress wp
            JOIN tblWords w ON wp.WordID = w.WordID
            GROUP BY wp.UserID, w.WordLevel
            ORDER BY wp.UserID, w.WordLevel
        ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    table.AddCell(rdr["UserID"].ToString());
                    table.AddCell(rdr["WordLevel"].ToString());
                    table.AddCell(rdr["TotalWords"].ToString());
                    table.AddCell(rdr["SuccessRate"].ToString());
                }
            }

            doc.Add(table);
            doc.Close();

            MessageBox.Show("Pdf Succesfully Created:\n" + fullPath, "Report was created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
