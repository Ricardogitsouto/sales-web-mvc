
using System;
using System.Linq;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name, ICollection<Seller> sellers)
        {
            this.id = id;
            this.name = name;
        }

        public void AddSellers(Seller Seller)
        {
            Sellers.Add(Seller);
        }

        public double TotalSeles(DateTime initial, DateTime Final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, Final));
        }
    }
}
