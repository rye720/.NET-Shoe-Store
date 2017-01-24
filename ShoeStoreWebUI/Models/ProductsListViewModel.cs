using System;
using System.Collections.Generic;
using ShoeStoreDomain.Entities;
using System.Linq;
using System.Web;

namespace ShoeStoreWebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}