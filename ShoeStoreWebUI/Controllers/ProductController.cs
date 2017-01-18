﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeStoreDomain.Abstract;
using ShoeStoreDomain.Entities;

namespace ShoeStoreWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        // GET: Product

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}