using DataLayer;
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

    }
}
