using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Personal_Expense_Management
{
    internal class Catagorydata
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brook\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string Date { get; set; }

        public List<Catagorydata> categoryListData()
        {
            List < Catagorydata > listData = new List<Catagorydata > ();
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM categories";
                using (SqlCommand cmd = new SqlCommand(selectData, connect)) {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        Catagorydata cData = new Catagorydata();
                        cData.ID = (int)reader["id"];
                        cData.category = (string)reader["category"];
                        cData.type = (string)reader["type"];
                        cData.status = (string)reader["status"];
                        cData.Date=reader["date_inserted"].ToString();
                        listData.Add (cData);
                    }

                }
            }
            return listData;
        }
    } }
