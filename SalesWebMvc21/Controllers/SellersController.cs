﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc21.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMvc21.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {

            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}