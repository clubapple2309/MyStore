using System;
using System.Collections.Generic;
using ClothesStore.DB.Entities;
namespace ClothesStore.Web.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}