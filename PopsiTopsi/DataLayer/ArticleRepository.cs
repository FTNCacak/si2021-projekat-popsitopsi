
using Shared;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;


namespace DataLayer
{
    public class ArticleRepository : IArticleRepository
    {
        

        public List<Article> GetAllArticles()
        {
            List<Article> articles = new List<Article>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
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
                    article.Image = sqlDataReader.GetString(4);
                    article.Description = sqlDataReader.GetString(5);

                    articles.Add(article);
                }

            }
            return articles;
        }
        public  byte[] ReadAllBytes( Stream instream)
        {
            if (instream is MemoryStream)
                return ((MemoryStream)instream).ToArray();

            using (var memoryStream = new MemoryStream())
            {
                instream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
        public int InsertArticle(Article a)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                Console.WriteLine("Ivana");
                Console.WriteLine(a.Image);
                sqlCommand.CommandText = string.Format("INSERT INTO Articles VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", a.Name, a.Type, a.Price, a.Image, a.Description);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
                
            }
            
        }
        public int UpdateArticle(Article a,int idSelected)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Articles SET Name = '{0}',Type = '{1}', Price = '{2}', Image = '{3}', Description = '{4}' WHERE Id = '{5}'", a.Name, a.Type, a.Price, a.Image, a.Description, idSelected);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int DeleteArticle(int Id)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Articles WHERE Id = '{0}'", Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
                
        }

        public Article GetSelectedArticle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
