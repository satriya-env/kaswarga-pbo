using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kaswarga
{

    public partial class Login : Form
    {
        private string konek = @"
            Server=.\SQLEXPRESS;
            Database=db_kaswarga;
            Integrated Security=True;
            TrustServerCertificate=True";
        public Login()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(1) FROM [user] " +
                            "WHERE username=@user " +
                            "AND password=@pass";

            using (SqlConnection conn = new SqlConnection(konek))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", userbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", passbox.Text.Trim());
                    try
                    {
                        conn.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password salah cuy");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
