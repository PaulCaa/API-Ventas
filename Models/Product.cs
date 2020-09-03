using System;
using System.Collections.Generic;

namespace Ventas.Models{
    public class Product{
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public double Price { set; get; }
        public ProductDetail Detail { set; get; }
        public Category Category { set; get; }

        public Product() {
            this.Detail = new ProductDetail();
            this.Category = new Category();
        }

        public Product(int Id, string Name, string Description, double Price) {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Detail = new ProductDetail(Id);
            this.Category = new Category();
        }

        public Product(int Id, string Name, string Description, double Price, ProductDetail detail, Category category) {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Detail = MapDetails(Id, detail);
            this.Category = category;
        }


        private ProductDetail MapDetails(int Id, ProductDetail d){
            return new ProductDetail(Id,d.Weight,d.Width,d.Height,d.Color);
        }
    }
}