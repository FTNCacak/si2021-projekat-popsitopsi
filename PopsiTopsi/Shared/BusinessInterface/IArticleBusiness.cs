
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.BusinessInterface
{
    public interface IArticleBusiness
    {
        public bool InsertArticle(Article a);
        public List<Article> GetAllArticles();
        public bool DeleteArticle(int idSelected);
        public bool UpdateArticle(Article a);
        public Article GetSelectedArticle(int id);
        public bool IsArticleConnectedToBill(int articleId);
        public int GetNewArticleId();
    }
}
