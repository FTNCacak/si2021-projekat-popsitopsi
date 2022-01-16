
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public interface IArticleRepository
    {
        public List<Article> GetAllArticles();
        public int InsertArticle(Article a);
        public int UpdateArticle(Article a, int id);
        public int DeleteArticle(int id);
    }
}
