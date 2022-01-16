
using Shared;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class BillItemRepository : IBillItemRepository
    {
        public List<BillItem> GetAllBillItems()
        {
            List<BillItem> billitems = new List<BillItem>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM BillItems";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    BillItem billitem = new BillItem();
                    billitem.Quantity = sqlDataReader.GetInt32(0);
                    billitem.Bill_Id = sqlDataReader.GetInt32(1);
                    billitem.Article_Id = sqlDataReader.GetInt32(2);
                    billitems.Add(billitem);
                }
            }
            return billitems;
        }
        public int InsertBillItem(BillItem b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO BillItems VALUES('{0}', '{1}', '{2}')", b.Quantity, b.Bill_Id, b.Article_Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }

        }
        public int UpdateBillItem(BillItem b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE BillItems SET Quantity = '{0}' WHERE Bill_Id = '{1}' AND Article_Id = '{2}' ",b.Quantity, b.Bill_Id, b.Article_Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int DeleteBillItem(int BillId, int ArticleId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM BillItems WHERE Bill_Id = '{0}'AND Article_Id='{1}'", BillId, ArticleId);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }

        }
        
    }
}
