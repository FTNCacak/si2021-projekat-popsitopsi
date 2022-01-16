using BusinessLayer;
using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared;
using Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayerTest
{
    [TestClass]
    public class ArticleRepositoryTest
    {

        public Article article;
        public IArticleRepository articleRepository;

       
        [TestInitialize]
        public void init()
        {
            article = new Article
            {
                Id = 98978,
                Name="Artikal 1",
                Type="Tip broj 1",
                Description="Opis broj 1",
                Price=1000
               
            };
            
            articleRepository = new ArticleRepository();
          
        }
        [TestMethod]
        public void GetAllArticlesTest()
        {
            articleRepository.InsertArticle(article);
            Assert.IsNotNull(articleRepository.GetAllArticles());
        }

        [TestMethod]
        public void InsertArticleTest()
        {
            int result = articleRepository.InsertArticle(article);
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void UpdateArticleTest()
        {
            articleRepository.InsertArticle(article) ;
            Article newArticle = articleRepository.GetAllArticles().Where(x => x.Id == article.Id).ToList()[0];
            int result = articleRepository.UpdateArticle(newArticle);
            Assert.IsTrue(result > 0);
        }

     
        
    }

}
  