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
    public partial class CategoryForm : UserControl

    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brook\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public CategoryForm()
        {
            InitializeComponent();
            displayCategoryList();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;

            }
            displayCategoryList();


        }
        public void displayCategoryList()
        {
            Catagorydata cData = new Catagorydata();
            List<Catagorydata> listData = cData.categoryListData();

            dataGridView1.DataSource = listData;
        }

        private void category_Addbtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Fill every table", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();
                    string insertData = "INSERT INTO categories(category,type,status,date_inserted)" + "VALUES(@cat,@type,@status,@date)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect)) {
                        cmd.Parameters.AddWithValue("@cat",category_category.Text.Trim());
                        cmd.Parameters.AddWithValue("@type",category_type.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@status", category_status.SelectedItem.ToString());
                        DateTime date = DateTime.Today;
                        cmd.Parameters.AddWithValue(@"date", date.ToString());
                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("succesfuley added category","Information message",MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    connect.Close();
                }
            }
            displayCategoryList();
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row= dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                category_category.Text = row.Cells[1].Value.ToString();
                category_type.SelectedItem = row.Cells[2].Value.ToString();
                category_status.SelectedItem= row.Cells[3].Value.ToString();


            }
        }

        private void category_Updatebtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Select Item First", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to update ID:"+getID,"Confermation message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes) { 
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();
                    string UpdateData = "UPDATE categories SET category =@cat, type=@type, status= @status WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(UpdateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", getID);
                        cmd.Parameters.AddWithValue("@cat", category_category.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", category_type.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@status", category_status.SelectedItem.ToString());
                       
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated ", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    connect.Close();
                    }
                }
           
            }
            displayCategoryList();
        }
        public void clearFields() {
            category_category.Text ="";
            category_type.SelectedIndex = -1;
            category_status.SelectedIndex = -1;


        }
        private void category_Clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void category_Deletebtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Select Item First", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID:" + getID, "Confermation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();
                        string UpdateData = "DELETE FROM categories WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(UpdateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                           ;

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        connect.Close();
                    }
                }

            }
            displayCategoryList();
        }
    }
}
