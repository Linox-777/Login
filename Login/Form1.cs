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

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8EC9BHBF\\SQLEXPRESS;Initial Catalog=DBTest;Integrated Security=True;Encrypt=False");
            con.Open();
            string query = "SELECT COUNT (*) FROM loginapp WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            object result = cmd.ExecuteScalar();
            int count = (result != null) ? Convert.ToInt32(result) : 0;
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Kinginamo");
            }
        }
    }
}
