using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class BillItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Bill Bill_Id { get; set; }
        public Stuff Stuff_Id { get; set; }
        public Article Article_Id { get; set; }

    }
}
