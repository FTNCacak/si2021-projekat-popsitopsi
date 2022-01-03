using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class ArticleBusiness
    {
        public readonly ArticleRepository articleRepository;
        
        public ArticleBusiness()
        {
            this.articleRepository = new ArticleRepository();
        }
        public bool InsertArticle(Article a)
        {
            if (this.articleRepository.InsertArticle(a) > 0)
            {
                return true;
            }
            else return false;
        }

        public List<Article> GetAllArticles()
        {
            return this.articleRepository.GetAllArticles();
        }
    }
}
