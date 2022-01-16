
using Shared;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class StuffRepository : IStuffRepository
    {
        public List<Stuff> GetAllStuffs()
        {
            List<Stuff> stuffs = new List<Stuff>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Stuffs";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Stuff stuff = new Stuff();
                    stuff.Id = sqlDataReader.GetInt32(0);
                    stuff.Name = sqlDataReader.GetString(1);
                    stuff.Surname = sqlDataReader.GetString(2);
                    stuff.Username = sqlDataReader.GetString(3);
                    stuff.Password = sqlDataReader.GetString(4);
                    stuff.PhoneNumber = sqlDataReader.GetString(5);
                    stuff.Email = sqlDataReader.GetString(6);
                    

                    stuffs.Add(stuff);
                }

            }
            return stuffs;
        }
        public int InsertStuff(Stuff s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Stuffs VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )", s.Name, s.Surname, s.Username, s.Password, s.PhoneNumber, s.Email);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }

        }
        public int UpdateStuff(Stuff s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Stuffs SET  Name = '{0}', Surname = '{1}', Username = '{2}', Password = '{3}', PhoneNumber = '{4}', Email = '{5}' WHERE Id = '{6}'",s.Name, s.Surname, s.Username, s.Password, s.PhoneNumber, s.Email, s.Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int DeleteStuff(int Id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Stuffs WHERE Id = '{0}'", Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }

        }
        public int GetStuffNewId()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT IDENT_CURRENT('Stuffs')";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                var result = Convert.ToInt32(sqlDataReader[0]);
                return result;
            }
        }
    }
}
