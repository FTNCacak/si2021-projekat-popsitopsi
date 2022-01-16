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
        public List<int> listIDS = new List<int>();

        [TestInitialize]
        public void init()
        {
            article = new Article
            {

                Name = "Artikal 1",
                Type = "Tip broj 1",
                Description = "Opis broj 1",
                Price = 1000,


            };
            articleRepository = new ArticleRepository();
        }
        [TestMethod]
        public void GetAllArticlesTest()
        {
            articleRepository.InsertArticle(article);
            listIDS.Add(articleRepository.GetNewArticleId());
            Assert.IsNotNull(articleRepository.GetAllArticles());
        }

        [TestMethod]
        public void InsertArticleTest()
        {
            int result = articleRepository.InsertArticle(article);
            listIDS.Add(articleRepository.GetNewArticleId());
            Assert.IsTrue(result > 0);
            
        }

        [TestMethod]
        public void UpdateArticleTest()
        {
            articleRepository.InsertArticle(article);
            int newId = articleRepository.GetNewArticleId();
            article.Name = "Izmenjeni artikal!";
            article.Id = newId;
            listIDS.Add(newId);
            articleRepository.UpdateArticle(article);
            string result = articleRepository.GetAllArticles().FirstOrDefault(x => x.Id == article.Id).Name;
            Assert.AreEqual(result,"Izmenjeni artikal!");
        }
        [TestCleanup]
        public void CleanUpAfterTest()
        {
            foreach (int item in listIDS)
            {
                articleRepository.DeleteArticle(item);
            }
        }
    }

}
  