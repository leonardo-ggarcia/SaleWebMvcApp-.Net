using SaleWebMvcApp.Models.ModelsEnun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvcApp.Models
{
    public class SalesRecord
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public double amount { get; set; }
        public SaleStatus saleStatus { get; set; }

        public Seller seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus saleStatus, Seller seller)
        {
            this.id = id;
            this.date = date;
            this.amount = amount;
            this.saleStatus = saleStatus;
            this.seller = seller;
        }
    }
}
