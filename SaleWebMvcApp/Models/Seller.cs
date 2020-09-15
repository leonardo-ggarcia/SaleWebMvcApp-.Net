﻿using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvcApp.Models
{
    public class Seller
    {
        public int id { get; set; }       
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }

        public ICollection<SalesRecord> salesRecord { get; set; } = new List<SalesRecord>();

        public Department department { get; set; }

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        public void addSales(SalesRecord sr)
        {
            salesRecord.Add(sr);
        }

        public void removeSales(SalesRecord sr)
        {
            salesRecord.Remove(sr);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return salesRecord.Where(s => s.date >= initial && s.date <= final).Sum(sr => sr.amount);
        }
    }
}
