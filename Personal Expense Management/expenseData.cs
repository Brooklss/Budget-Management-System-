using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Personal_Expense_Management
{
    internal class expenseData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brook\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public string DateIncome { get; set; }
        public List<expenseData> expenseListData()
        {
            List<expenseData> listData = new List<expenseData>();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string selectData = "SELECT * FROM expenses";
                using (SqlCommand command = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        expenseData eData = new expenseData();
                        eData.ID = (int)reader["id"];
                        eData.Category = (string)reader["category"];
                        eData.Item = (string)reader["item"];
                        eData.Cost = reader["cost"].ToString();
                        eData.Description = (string)reader["description"];
                        eData.DateIncome = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");
                        listData.Add(eData);
                    }
                }
            }
            return listData;

        }
    }
}
