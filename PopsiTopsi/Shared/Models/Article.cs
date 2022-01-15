using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public String Image { get; set; }
        public string Description { get; set; }

    }
}
