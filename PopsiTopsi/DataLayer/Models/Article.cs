using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public Byte[] Image { get; set; }
        public string Description { get; set; }

    }
}
