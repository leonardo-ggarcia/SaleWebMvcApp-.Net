using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvcApp.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Seller> sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void addSeller(Seller seller)
        {
            sellers.Add(seller);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return sellers.Sum(s => s.totalSales(initial, final));
        }
    }
}
