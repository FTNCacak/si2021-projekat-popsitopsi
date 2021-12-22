using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class ArticleRepository
    {
        public List<Article> GetAllArticles()
        {
            List<Article> articles = new List<Article>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectioString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Articles";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Article article = new Article();
                    article.Id = sqlDataReader.GetInt32(0);
                    article.Name = sqlDataReader.GetString(1);
                    article.Type = sqlDataReader.GetString(2);
                    article.Price = sqlDataReader.GetDecimal(3);
                    long b = sqlDataReader.GetBytes(4, 0, article.Image, 0, Int32.MaxValue);
                    article.Description = sqlDataReader.GetString(5);

                    articles.Add(article);
                }

            }
            return articles;
        }
        public int InsertArticles(Article a)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectioString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Articles VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", a.Name, a.Type, a.Price, a.Image, a.Description);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            
        }
        public int UpdateArticles(Article a)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectioString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Articles Name = '{0}',Type = '{1}', Price = '{2}', Image = '{3}', Description = '{4}' WHERE Id = '{5}'");
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int DeleteArticles(int Id)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectioString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Articles WHERE Id = '{0}'", Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
                
        }
    }
}
