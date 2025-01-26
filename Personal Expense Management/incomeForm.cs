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
    public partial class incomeForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brook\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public incomeForm()
        {
            InitializeComponent();
            displayCategyList();
            displayIncomeData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
                }
            displayCategyList();
            displayIncomeData();


        }
        public void displayIncomeData()
        {

            incomeData iData = new incomeData();
            List<incomeData> listData = iData.incomeListData();
            dataGridView1.DataSource= listData;
        }
        public void displayCategyList()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string selectData = "SELECT category FROM categories WHERE type=@type AND status=@status";
                using (SqlCommand command = new SqlCommand(selectData, connection))
                {
                    command.Parameters.AddWithValue("@type", "Income");
                    command.Parameters.AddWithValue("@status", "Active");
                    income_Category.Items.Clear();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        income_Category.Items.Add(reader["category"].ToString());
                    }


                }
            }
        }
        private void incomeForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void income_Addbtn_Click(object sender, EventArgs e)
        {
            if (income_Category.SelectedIndex == -1 || income_Item.Text == "" || income_Income.Text == "" || income_Discription.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    if (!decimal.TryParse(income_Income.Text, out decimal incomeValue))
                    {
                        MessageBox.Show("Please enter a valid numeric value for income.","Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return; // Exit the method without executing the query
                    }
                    connect.Open();
                    string insertData = "INSERT INTO income (category,item,income,description,date_income,date_insert)" +
                        "VALUES(@cat,@item,@income,@desc,@date_in,@date)";
                    using (SqlCommand command = new SqlCommand(insertData, connect))
                    {
                        command.Parameters.AddWithValue("@cat", income_Category.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@item", income_Item.Text);
                        command.Parameters.AddWithValue("@income", income_Income.Text);
                        command.Parameters.AddWithValue("@desc", income_Discription.Text);
                        command.Parameters.AddWithValue("@date_in", income_Date.Value);

                        DateTime today = DateTime.Today;
                        command.Parameters.AddWithValue("@date", today);
                        command.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Added sucessfully", "Informaition message", MessageBoxButtons.OK, MessageBoxIcon.Information);





                    }
                    connect.Close();
                }

            }
            displayIncomeData();
        }
        public void clearFields()
        {
            income_Item.Text = "";
            income_Category.SelectedIndex = -1;
            income_Income.Text = "";
            income_Discription.Text = "";

        }
        private void income_Clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void income_Updatebtn_Click(object sender, EventArgs e)
        {

            if (income_Category.SelectedIndex == -1 || income_Item.Text == "" || income_Income.Text == "" || income_Discription.Text == "")
            {
                MessageBox.Show("Please Select an item first", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(MessageBox.Show("Are you sure you wana update the iteam","confirmation message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();
                        string updateData = "UPDATE income SET category=@cat, item=@item, income =@income," +
                            "description=@desc,date_income=@date_in WHERE id=@id";
                        using (SqlCommand command = new SqlCommand(updateData, connect))
                        {
                            command.Parameters.AddWithValue("@cat", income_Category.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@item", income_Item.Text);
                            command.Parameters.AddWithValue("@income", income_Income.Text);
                            command.Parameters.AddWithValue("@desc", income_Discription.Text);
                            command.Parameters.AddWithValue("@date_in", income_Date.Value);
                            command.Parameters.AddWithValue("@id", getId);



                            command.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Updated sucessfully", "Informaition message", MessageBoxButtons.OK, MessageBoxIcon.Information);





                        }
                        connect.Close();
                    }
                }

            }
            displayIncomeData();
            
        }
        private int getId = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) { 
            DataGridViewRow row=dataGridView1.Rows[e.RowIndex];
                getId=(int)row.Cells[0].Value;
                income_Category.SelectedItem=row.Cells[1].Value.ToString();
                income_Item.Text = row.Cells[2].Value.ToString();
                income_Income.Text = row.Cells[3].Value.ToString();
                income_Discription.Text = row.Cells[4].Value.ToString();
                income_Date.Value=Convert.ToDateTime(row.Cells[5].Value);

            }

        }

        private void income_Deletebtn_Click(object sender, EventArgs e)
        {

            if (income_Category.SelectedIndex == -1 || income_Item.Text == "" || income_Income.Text == "" || income_Discription.Text == "")
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
                        connect.Open();
                        string deleteData = "DELETE FROM income WHERE id=@id";
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
            displayIncomeData();
        }

        private void income_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
