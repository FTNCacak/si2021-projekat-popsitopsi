
using Shared;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class BillRepository :IBillRepository
    {
        public List<Bill> GetAllBills()
        {
            List<Bill> bills = new List<Bill>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Bills";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Bill bill = new Bill();
                    bill.Id = sqlDataReader.GetInt32(0);
                    bill.Total = sqlDataReader.GetDecimal(1);
                    bill.Date = sqlDataReader.GetDateTime(2);
                    bill.Stuff_Id = sqlDataReader.GetInt32(3);

                    bills.Add(bill);
                }
            }
            return bills;
        }
        public int InsertBill(Bill b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Bills VALUES('{0}', '{1}', '{2}')", b.Total, b.Date, b.Stuff_Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }

        }
        public int UpdateBill(Bill b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Bills SET Total = '{0}', Date = '{1}', Id_Stuff = '{2}' WHERE Id = '{3}'", b.Total, b.Date, b.Stuff_Id, b.Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int DeleteBill(int Id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Bills WHERE Id = '{0}'", Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }

        }
        public int GetNewBillId()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT IDENT_CURRENT('Bills')";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                var result = Convert.ToInt32(sqlDataReader[0]);
                return result;
            }
        }
    }
}
