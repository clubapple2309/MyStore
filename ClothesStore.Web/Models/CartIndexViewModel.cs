using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClothesStore.DB.Entities;

namespace ClothesStore.Web.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}