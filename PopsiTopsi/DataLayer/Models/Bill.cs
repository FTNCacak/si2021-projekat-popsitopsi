using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public int Stuff_Id { get; set; }

        public Bill(int id, decimal total, DateTime date, int stuff_id)
        {
            this.Id = id;
            this.Total = total;
            this.Date = date;
            this.Stuff_Id = stuff_id;

        }
        public Bill()
        {
             
        }
    }
}
