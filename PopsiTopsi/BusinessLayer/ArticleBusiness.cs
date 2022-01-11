using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Article GetSelectedArticle(int id)
        {
            return this.articleRepository.GetAllArticles().FirstOrDefault(s => s.Id == id);
        }

        public bool DeleteArticle(int idSelected)
        {
            if (this.articleRepository.DeleteArticle(idSelected) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateArticle(Article a,int idSelected)
        {
            if (this.articleRepository.UpdateArticle(a,idSelected) > 0)
            {
                return true;
            }
            return false;

        }
    }
}
