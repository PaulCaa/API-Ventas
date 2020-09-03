using System;
using System.Collections.Generic;
using Ventas.Models;

namespace Ventas.Repository
{
    public class ProductRepositoryMock{

        private List<Product> Products;

        private CategoryRepositoryMock Categories;

        private ProductDetailRepositoryMock Details;

        public ProductRepositoryMock(){
            Categories = new CategoryRepositoryMock();
            Details = new ProductDetailRepositoryMock();
            this.Products = new List<Product>(){
                new Product(1,"Yogurt Corsan","Yogurt Bebible",56.00, Details.GetDetailBy(1), Categories.GetCategoryById(1)),
                new Product(2,"Yogurt La Serena","Yogurt Bebible",59.00, Details.GetDetailBy(2), Categories.GetCategoryById(1)),
                new Product(3,"Pan Lactal Forgo","Pan Lactal Blanco",115.00, Details.GetDetailBy(3), Categories.GetCategoryById(1)),
                new Product(4,"Pan Lactal Bombo","Pan Lactal Blanco",126.00, Details.GetDetailBy(4), Categories.GetCategoryById(1)),
                new Product(5,"Pan Hamburguesa Forgo","Pan para hamburguesas x4",95.00, Details.GetDetailBy(5), Categories.GetCategoryById(1)),
                new Product(6,"Pan Hamburguesa Bombo","Pan para hamburguesas con sesamo x4",108.00, Details.GetDetailBy(6), Categories.GetCategoryById(1)),
                new Product(7,"Yogurt Corsan","Yogurt Bebible",56.00, Details.GetDetailBy(7), Categories.GetCategoryById(1)),
                new Product(8,"Yogurt Corsan","Yogurt Bebible",56.00, Details.GetDetailBy(8), Categories.GetCategoryById(1)),
                new Product(9,"Yogurt Corsan","Yogurt Bebible",56.00, Details.GetDetailBy(9), Categories.GetCategoryById(1)),
                new Product(10,"Yogurt Corsan","Yogurt Bebible",56.00, Details.GetDetailBy(10), Categories.GetCategoryById(1)),
                new Product(11,"Lavandina Ayudita","Lavandina comun", 44.00, Details.GetDetailBy(11), Categories.GetCategoryById(2)),
                new Product(12,"Lavandina Soft","Lavandina Premium",49.00, Details.GetDetailBy(12), Categories.GetCategoryById(2)),
                new Product(13,"Detergente Soft","Detergente concentrado", 89.00, Details.GetDetailBy(13), Categories.GetCategoryById(2)),
                new Product(14,"Detergente Ola","Detergente anti grasa", 87.00, Details.GetDetailBy(14), Categories.GetCategoryById(2)),
                new Product(15,"TV Led 40 pulg. Chanchung","Led 40 pulgadas",39000.00, Details.GetDetailBy(15), Categories.GetCategoryById(3)),
                new Product(16,"TV LCD 32 pulg EleGe","LCD 32 pulgadas",21000.00, Details.GetDetailBy(16), Categories.GetCategoryById(3)),
                new Product(17,"Garantia extendida","Servicio de garantia por 12 meses",2499.00, Details.GetDetailBy(17), Categories.GetCategoryById(4))
            };
        }

        public List<Product> getAllProducts(){
            return Products;
        }

        public List<Product> GetProductsByCategory(int Id){
            List<Product> result = new List<Product>();
            foreach(Product p in Products){
                if(p.Category.Id == Id){
                    result.Add(p);
                }
            }
            return result;
        }

    }
}