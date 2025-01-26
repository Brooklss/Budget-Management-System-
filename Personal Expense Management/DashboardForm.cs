using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Personal_Expense_Management
{
    public partial class DashboardForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brook\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public DashboardForm()
        {
            InitializeComponent();
            //income dashboard value insializiantions 
            incomeToday();
            incomeYesterday();
            incomeMonth();
            incomeYear();
            incomeTotal();
            //expense dashboard value insializiantions 
            expenseToday();
            expenseYesterday();
            expenseMonth(); 
            expenseYear();
            expenseTotal();
            expensesuggested();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
                
               
            }
            //income dashboard value insializiantions
            incomeToday();
            incomeYesterday();
            incomeMonth();
            incomeYear();
            incomeTotal();
            //expense dashboard value insializiantions 
            expenseToday();
            expenseYesterday();
            expenseMonth();
            expenseYear();
            expenseTotal();
            expensesuggested();

        }
        // income
        public void incomeToday()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection)) { 
            connect.Open();
                string query = "SELECT SUM(income) FROM income WHERE date_income=@date_in";
                using (SqlCommand cmd = new SqlCommand(query, connect)) { 
                DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal todayincome = Convert.ToDecimal(result);
                        income_today.Text =  todayincome.ToString()+"BR";
                    }
                    else {
                        income_today.Text = "0.00BR";
                    }
                
                }
            }
        }
        
        public void incomeYesterday()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection)) {
                
                conn.Open();
                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE,date_income) = DATEADD(day,DATEDIFF(day,0,GETDATE()),-1)";
                using (SqlCommand cmd = new SqlCommand(query, conn)) { 
                object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value) { 
                        decimal yesterdayincome= Convert.ToDecimal(result);
                        income_yesterday.Text = yesterdayincome.ToString() + "BR";
                    }
                    else
                    {
                        income_yesterday.Text = "0.00BR";
                    }
                }

            }
        }
        public void incomeMonth()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {

                conn.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth= startMonth.AddMonths(1).AddDays(-1);
                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal montincome = Convert.ToDecimal(result);
                        income_month.Text = montincome.ToString() + "BR";
                    }
                    else
                    {
                        income_month.Text = "0.00BR";
                    }
                }

            }
        }
        public void incomeYear() {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {

                conn.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yearincome = Convert.ToDecimal(result);
                        income_year.Text = yearincome.ToString() + "BR";
                    }
                    else
                    {
                        income_year.Text = "0.00BR";
                    }
                }

            }
        }
        public void incomeTotal()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {

                conn.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string query = "SELECT SUM(income) FROM income ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                   
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalincome = Convert.ToDecimal(result);
                        income_total.Text = totalincome.ToString() + "BR";
                    }
                    else
                    {
                        income_total.Text = "0.00BR";
                    }
                }

            }
        }
        //expense
        public void expenseToday()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense = @date_ex";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_ex", today);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal todyacost = Convert.ToDecimal(result);
                        expense_today.Text = todyacost.ToString() + "BR";
                    }
                    else
                    {
                        expense_today.Text = "0.00BR";
                    }

                }
            }
        }
        
        public void expenseYesterday()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {

                conn.Open();
                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE,date_expense) = DATEADD(day,DATEDIFF(day,0,GETDATE()),-1)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yesterdayincome = Convert.ToDecimal(result);
                        expense_yesterday.Text = yesterdayincome.ToString() + "BR";
                    }
                    else
                    {
                        expense_yesterday.Text = "0.00BR";
                    }
                }

            }
        }
        public void expenseMonth()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {

                conn.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);
                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <= @endMonth";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal montincome = Convert.ToDecimal(result);
                        expense_month.Text = montincome.ToString() + "BR";
                    }
                    else
                    {
                        expense_month.Text = "0.00BR";
                    }
                }

            }
        }
        public void expenseYear()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {

                conn.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startYear AND date_expense <= @endYear";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yearincome = Convert.ToDecimal(result);
                        expense_year.Text = yearincome.ToString() + "BR";
                    }
                    else
                    {
                        expense_year.Text = "0.00BR";
                    }
                }

            }
        }
        public void expenseTotal()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {

                conn.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string query = "SELECT SUM(cost) FROM expenses";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalexpense = Convert.ToDecimal(result);
                        expense_total.Text = totalexpense.ToString() + "BR";
                    }
                    else
                    {
                        expense_total.Text = "0.00BR";
                    }
                }

            }
        }
        public void expensesuggested()
        {
            

            
                // Connect to the database
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    // Fetch total income for the current month
                    string incomeQuery = @"SELECT SUM(income) AS TotalIncome
                                            FROM income
                                            WHERE MONTH(date_income) = MONTH(GETDATE()) AND YEAR(date_income) = YEAR(GETDATE());";

                    SqlCommand incomeCommand = new SqlCommand(incomeQuery, connection);
                    object incomeResult = incomeCommand.ExecuteScalar();
                    float totalIncome = incomeResult != DBNull.Value ? Convert.ToSingle(incomeResult) : 0;

                    // Fetch total expenses for the current month
                    string expenseQuery = @"SELECT SUM(cost) AS TotalExpenses
                                             FROM expenses
                                             WHERE MONTH(date_expense) = MONTH(GETDATE()) AND YEAR(date_expense) = YEAR(GETDATE());";

                    SqlCommand expenseCommand = new SqlCommand(expenseQuery, connection);
                    object expenseResult = expenseCommand.ExecuteScalar();
                    float totalExpenses = expenseResult != DBNull.Value ? Convert.ToSingle(expenseResult) : 0;

                    // Calculate daily usage suggestion
                    int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    float remainingBalance = totalIncome - totalExpenses;
                    float dailySuggestion = remainingBalance / daysInMonth;
                if (expenseResult != DBNull.Value || incomeResult != DBNull.Value)
                {
                    decimal totalexpense = Convert.ToDecimal(dailySuggestion);
                    expense_suggested.Text = "Daily suggestion:" + totalexpense.ToString() + "BR";
                }
                else
                {
                    expense_suggested.Text = "Daily suggestion:0.00BR";
                }
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
