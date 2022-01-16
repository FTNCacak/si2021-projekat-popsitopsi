using DataLayer;
using Shared;
using Shared.BusinessInterface;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class ArticleBusiness :IArticleBusiness
    {
        public readonly IArticleRepository articleRepository;
        public readonly IBillItemRepository billitemRepository;
     
        public ArticleBusiness(IArticleRepository _articleRepository)
        {this.articleRepository = _articleRepository;
        }
        public ArticleBusiness(IArticleRepository _articleRepository, IBillItemRepository _billitemRepository)
        {
            this.articleRepository = _articleRepository;
            this.billitemRepository = _billitemRepository;
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
        public bool IsArticleConnectedToBill(int articleId)
        {
            return this.billitemRepository.GetAllBillItems().Where(bi => bi.Article_Id == articleId).ToList().Count > 0;
        }
        public bool UpdateArticle(Article a)
        {
            if (this.articleRepository.UpdateArticle(a) > 0)
            {
                return true;
            }
            return false;

        }
        public int GetNewArticleId()
        {
            return this.articleRepository.GetNewArticleId();
                
        }

    }
}
