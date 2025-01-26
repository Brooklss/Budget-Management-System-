using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Personal_Expense_Management
{


    internal class incomeData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brook\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { get; set; }
        public string Category {  get; set; }
        public string Item { get; set; }
        public string Cost { get; set; }
        public string Description {  get; set; }
        public string DateIncome { get; set; }
        public List<incomeData> incomeListData() { 
            List<incomeData> listData= new List<incomeData>();
            using(SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string selectData = "SELECT * FROM income";
                using (SqlCommand command = new SqlCommand(selectData, connection)) { 
                SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) { 
                    incomeData iData = new incomeData();
                        iData.ID = (int)reader["id"];
                        iData.Category = (string)reader["category"];
                        iData.Item = (string)reader["item"];
                        iData.Cost = reader["income"].ToString();
                        iData.Description = (string)reader["description"];
                        iData.DateIncome=((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");
                        listData.Add(iData);
                    }
                }
            }
        return listData;
        
        }
    }
}
