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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 utama = new Form1();
            utama.Show();

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
