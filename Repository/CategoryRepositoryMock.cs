using System;
using System.Collections.Generic;
using Ventas.Models;

namespace Ventas.Repository
{
    public class CategoryRepositoryMock{

        private List<Category> Categories;

        public CategoryRepositoryMock(){
            this.Categories = new List<Category>(){
                new Category(1,"Comestibles"),
                new Category(2,"Limpieza"),
                new Category(3,"Electro"),
                new Category(4,"Servicios")
            };
        }

        public List<Category> GetAllCategories(){
            return Categories;
        }

        public Category GetCategoryById(int Id){
            foreach(Category c in Categories){
                if(c.Id == Id){
                    return c;
                }
            }
            return null;
        }

    }
}