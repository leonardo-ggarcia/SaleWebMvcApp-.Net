using SaleWebMvcApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvcApp.Models.ModelsService
{
    public class SellerService
    {
        private readonly SaleWebMvcAppContext _context;

        public SellerService(SaleWebMvcAppContext context)
        {
            _context = context;
        }

        public List<Seller> findAll()
        {
            return _context.Seller.ToList();
        }
    }
}
