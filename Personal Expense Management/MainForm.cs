using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Expense_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayUserName();
        }
        public void displayUserName()
        {
            string Username= Form1.userName;
            greetUser.Text = "Welcome " + Username;

        }
        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wana Close the app?", "Confermation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you sure you wana log out?", "Confermation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void incomeForm1_Load(object sender, EventArgs e)
        {

        }
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expenseForm1.Visible = false;
            DashboardForm dForm = dashboardForm1 as DashboardForm;
            if (dForm != null)
            {
                dForm.refreshData();
            }
        }
        private void addCataegory_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm1.Visible = false;
            expenseForm1.Visible = false;
           
            CategoryForm cForm = categoryForm1 as CategoryForm;
            if (cForm != null)
            {
                cForm.refreshData();
            }

        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = true;
            expenseForm1.Visible = false;

            incomeForm iForm = incomeForm1 as incomeForm;
            if (iForm != null)
            {
                iForm.refreshData();
            }

        }

        private void expense_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expenseForm1.Visible = true;
            expenseForm eForm= expenseForm1 as expenseForm;
            if (eForm != null) { 
                eForm.refreshData();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
