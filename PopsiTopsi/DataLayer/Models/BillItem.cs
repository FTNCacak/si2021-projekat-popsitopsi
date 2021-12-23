using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class BillItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Bill_Id { get; set; }
        public int Stuff_Id { get; set; }
        public int Article_Id { get; set; }

    }
}
