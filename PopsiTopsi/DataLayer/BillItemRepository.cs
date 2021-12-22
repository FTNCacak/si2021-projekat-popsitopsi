using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class BillItemRepository
    {
        public List<BillItem> GetAllBillItems()
        {
            List<BillItem> billitems = new List<BillItem>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectioString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM BillItems";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    BillItem billitem = new BillItem();
                    billitem.Id = sqlDataReader.GetInt32(0);
                    billitem.Quantity = sqlDataReader.GetInt32(1);
                    billitem.Bill_Id = sqlDataReader.GetInt32(2);
                    billitem.Stuff_Id = sqlDataReader.GetInt32(3);
                    billitem.Article_Id = sqlDataReader.GetInt32(4);

                    billitems.Add(billitem);
                }
            }
            return billitems;
        }
        public int InsertBillItem(BillItem b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectioString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO BillItems VALUES('{0}', '{1}', '{2}', '{3}')", b.Quantity, b.Bill_Id, b.Stuff_Id, b.Article_Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }

        }
        public int UpdateBillItem(BillItem b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectioString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE BillItems Quantity = '{0}', Bill_Id = '{1}', Stuff_Id = '{2}', Article_Id = '{3}' WHERE Id = '{4}'");
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int DeleteBillItem(int Id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectioString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM BillItems WHERE Id = '{0}'", Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }

        }
    }
}
