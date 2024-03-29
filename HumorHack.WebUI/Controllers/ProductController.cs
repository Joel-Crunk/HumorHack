﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HumorHack.Domain.Abstract;
using HumorHack.Domain.Entities;
using HumorHack.WebUI.Models;

namespace HumorHack.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 2;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }
        public ViewResult List(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            };
            return View(model);

        }
    }
}