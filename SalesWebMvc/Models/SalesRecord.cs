using System;
using SalesWebMvc.Models.Enuns;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public  SaleStatus status { get; set; }
        public Seller Saller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amouth, SaleStatus status, Seller saller)
        {
            Id = id;
            Date = date;
            Amount = amouth;
            this.status = status;
            Saller = saller;
        }
    }
}
