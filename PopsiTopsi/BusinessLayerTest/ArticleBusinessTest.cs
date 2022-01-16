using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared;
using Shared.BusinessInterface;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayerTest
{
    [TestClass]
    public class ArticleBusinessTest
    {

        private Mock<IArticleRepository> mockArticleRepository = new Mock<IArticleRepository>();
        private Mock<IBillItemRepository> mockBillItemRepository = new Mock<IBillItemRepository>();

        private Article article1 = new Article
        {
            Id = 23,
            Name = "Cokoladno carstvo",
            Type = "POPSI, KROFNE",
            Price = 12345,
            Description = "Opis cokoladnog carstva."
        };
        private Article article2 = new Article
        {
            Id = 33,
            Name = "Zivotinjsko carstvo",
            Type = "KROFNE",
            Price = 13425,
            Description = "Opis zivotinjskog carstva."
        };
        private Article article3 = new Article
        {
            Id = 43,
            Name = "carstvo",
            Type = "KROFNE",
            Price = 13425,
            Description = "Opis  carstva."
        };
        private ArticleBusiness articleBusiness;
        private List<Article> list = new List<Article>();

        private BillItem billitem1 = new BillItem
        {
            Quantity = 23,
            Bill_Id = 56,
            Article_Id = 33,
        };
        private BillItem billitem2 = new BillItem
        {
            Quantity = 65,
            Bill_Id = 42,
            Article_Id = 43,
        };
        private List<BillItem> lista = new List<BillItem>();
        public ArticleBusinessTest()
        {
            list.Add(article1);
            list.Add(article2);
            list.Add(article3);
            lista.Add(billitem1);
            lista.Add(billitem2);
        }

        [TestMethod]
        public void GetAllArticleTest()
        {
            mockArticleRepository.Setup(a => a.GetAllArticles()).Returns(list);
            this.articleBusiness = new ArticleBusiness(mockArticleRepository.Object);
            var result = articleBusiness.GetAllArticles();
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void UpdateArticleTest()
        {
            mockArticleRepository.Setup(x => x.UpdateArticle(article1)).Returns(1);
            this.articleBusiness = new ArticleBusiness(mockArticleRepository.Object);

            var result = articleBusiness.UpdateArticle(article1);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void InsertArticleTest()
        {
            mockArticleRepository.Setup(x => x.InsertArticle(article1)).Returns(1);
            this.articleBusiness = new ArticleBusiness(mockArticleRepository.Object);

            var result = articleBusiness.InsertArticle(article1);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void GetSelectedArticleTest()
        {
            mockArticleRepository.Setup(x => x.GetAllArticles()).Returns(list);
            this.articleBusiness = new ArticleBusiness(mockArticleRepository.Object);

            var result = articleBusiness.GetSelectedArticle(article1.Id);
            Assert.AreEqual(result, article1);
        }

        [TestMethod]
        public void IsArticleConnectedToBillTest()
        {
            mockBillItemRepository.Setup(x => x.GetAllBillItems()).Returns(lista);

            this.articleBusiness = new ArticleBusiness(mockArticleRepository.Object,mockBillItemRepository.Object);

            var result = articleBusiness.IsArticleConnectedToBill(article3.Id);
            Assert.AreEqual(result, true);
        }
    }
}