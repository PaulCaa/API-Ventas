using System;
using System.Collections.Generic;

namespace Ventas.Models
{
    public class Sale
    {
        public int Id  { set; get; }
        public string Date  { set; get; }
        public Client Client  { set; get; }
        public Seller Seller { set; get; }
        public List<Product> Products { set; get; }
        public double Total { set; get; }

        public Sale()
        {
            this.Products = new List<Product>();
        }
    }
}