using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public int Stuff_Id { get; set; }

       
    }
}
