﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleWebMvcApp.Data;
using SaleWebMvcApp.Models;
using SaleWebMvcApp.Models.ModelsService;

namespace SaleWebMvcApp.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()        {
            var list = _sellerService.findAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller objSeller)
        {
            _sellerService.insert(objSeller);
            return RedirectToAction(nameof(Index));
        }
       
       
    }
}
