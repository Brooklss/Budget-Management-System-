using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Personal_Expense_Management
{
    public partial class Form1 : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brook\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public static string userName;
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect= new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM users WHERE USERNAME= @usern AND password=@pass";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_passowrd.Text.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        userName = login_username.Text;
                        MessageBox.Show("Login Sucessful!", "information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm mForm = new MainForm();
                        mForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("INCORECT USER NAME/PASS", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            login_passowrd.PasswordChar = login_showpassword.Checked ? '\0' : '*';
            
        }
    }
}
