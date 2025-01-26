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
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Personal_Expense_Management
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brook\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }
        public bool cheakConneciton()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void register_signup_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();


            this.Hide();

        }

        private void register_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showpassword.Checked ? '\0' : '*';
            register_confirmpass.PasswordChar = register_showpassword.Checked ? '\0' : '*';
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_confirmpass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Exit the method if any field is empty
            }

            if (cheakConneciton())  // Assuming this checks connection
            {
                try
                {
                    connect.Open();

                    // Check for existing username
                    string selectUsername = "SELECT * FROM users WHERE username=@usern";
                    using (SqlCommand cheakUser = new SqlCommand(selectUsername, connect))
                    {
                        cheakUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cheakUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show(register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1) + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else // Username doesn't exist, proceed with password checks
                        {
                            if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Password can't be less than 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text != register_confirmpass.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else // All checks passed, insert user
                            {
                                string insertData = "INSERT INTO users(username,password,date_created ) VALUES(@usern,@pass,@date)";
                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    DateTime today = DateTime.Now;
                                    insertUser.Parameters.AddWithValue("@date", today);
                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void register_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


