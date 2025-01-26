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

namespace Personal_Expense_Management
{
    public partial class expenseForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brook\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public expenseForm()
        {
            InitializeComponent();
            displayCategyList();
            displayExpenseData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;

            }
            displayCategyList();
            displayExpenseData();

        }
        public void displayExpenseData()
        {

            expenseData eData = new expenseData();
            List<expenseData> listData = eData.expenseListData();
            dataGridView1.DataSource = listData;
        }
        public void displayCategyList()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string selectData = "SELECT category FROM categories WHERE type=@type AND status=@status";
                using (SqlCommand command = new SqlCommand(selectData, connection))
                {
                    command.Parameters.AddWithValue("@type", "Expense");
                    command.Parameters.AddWithValue("@status", "Active");
                    expense_Category.Items.Clear();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        expense_Category.Items.Add(reader["category"].ToString());
                    }


                }
            }
        }

        private void Expense_Addbtn_Click(object sender, EventArgs e)
        {
            if (expense_Category.SelectedIndex == -1 || expense_Item.Text == "" || expense_Cost.Text == "" || expense_Discription.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    if (!decimal.TryParse(expense_Cost.Text, out decimal incomeValue))
                    {
                        MessageBox.Show("Please enter a valid numeric value for income.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method without executing the query
                    }
                    connect.Open();
                    string insertData = "INSERT INTO expenses (category,item,cost,description,date_expense,date_insert)" +
                        "VALUES(@cat,@item,@cost,@desc,@date_ex,@date)";
                    using (SqlCommand command = new SqlCommand(insertData, connect)) 
                    {
                        command.Parameters.AddWithValue("@cat", expense_Category.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@item", expense_Item.Text);
                        command.Parameters.AddWithValue("@cost", expense_Cost.Text);
                        command.Parameters.AddWithValue("@desc", expense_Discription.Text);
                        command.Parameters.AddWithValue("@date_ex", expense_Date.Value);

                        DateTime today = DateTime.Today;
                        command.Parameters.AddWithValue("@date", today);
                        command.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Added sucessfully", "Informaition message", MessageBoxButtons.OK, MessageBoxIcon.Information);





                    }
                    connect.Close();
                }

            }
            displayExpenseData();
        }
        public void clearFields()
        {
            expense_Item.Text = "";
            expense_Category.SelectedIndex = -1;
            expense_Cost.Text = "";
            expense_Discription.Text = "";

        }

        private void Expense_Clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Expense_Updatebtn_Click(object sender, EventArgs e)
        {
            if (expense_Category.SelectedIndex == -1 || expense_Item.Text == "" || expense_Cost.Text == "" || expense_Discription.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Are you sure you wana update the iteam", "confirmation message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        if (!decimal.TryParse(expense_Cost.Text, out decimal incomeValue))
                        {
                            MessageBox.Show("Please Select an item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method without executing the query
                        }
                        connect.Open();
                        string updateData = "UPDATE  expenses SET category=@cat, item=@item, cost =@cost," +
                                "description=@desc WHERE id=@id";
                        using (SqlCommand command = new SqlCommand(updateData, connect))
                        {
                            command.Parameters.AddWithValue("@cat", expense_Category.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@item", expense_Item.Text);
                            command.Parameters.AddWithValue("@cost", expense_Cost.Text);
                            command.Parameters.AddWithValue("@desc", expense_Discription.Text);
                            command.Parameters.AddWithValue("@id", getId);

                            DateTime today = DateTime.Today;
                            command.Parameters.AddWithValue("@date", today);
                            command.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Updated sucessfully", "Informaition message", MessageBoxButtons.OK, MessageBoxIcon.Information);





                        }
                        connect.Close();
                    }
                }
            }
            displayExpenseData();
        }
        private int getId = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getId = (int)row.Cells[0].Value;
                expense_Category.SelectedItem = row.Cells[1].Value.ToString();
                expense_Item.Text = row.Cells[2].Value.ToString();
                expense_Cost.Text = row.Cells[3].Value.ToString();
                expense_Discription.Text = row.Cells[4].Value.ToString();
                expense_Date.Value = Convert.ToDateTime(row.Cells[5].Value);

            }
        }

        private void Expense_Deletebtn_Click(object sender, EventArgs e)
        {
            if (expense_Category.SelectedIndex == -1 || expense_Item.Text == "" || expense_Cost.Text == "" || expense_Discription.Text == "")
            {
                MessageBox.Show("Please Select an item first", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Are you sure you wana Delete the iteam", "confirmation message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        if (!decimal.TryParse(expense_Cost.Text, out decimal incomeValue))
                        {
                            MessageBox.Show("Please Select an item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method without executing the query
                        }
                        connect.Open();
                        string deleteData = "DELETE FROM expenses WHERE id=@id";
                        using (SqlCommand command = new SqlCommand(deleteData, connect))
                        {
                            
                            command.Parameters.AddWithValue("@id", getId);

                           
                            command.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Deleted sucessfully", "Informaition message", MessageBoxButtons.OK, MessageBoxIcon.Information);





                        }
                        connect.Close();
                    }
                }
            }
            displayExpenseData();
        }
    }
}
