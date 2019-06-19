using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HumorHack.Domain.Entities;

namespace HumorHack.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}