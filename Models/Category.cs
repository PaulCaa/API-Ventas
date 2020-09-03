using System;
using System.Collections.Generic;

namespace Ventas.Models
{
    public class Category{
        public int Id { set; get; }
        public string Name { set; get; }

        public Category(){}

        public Category(int id, string name){
            this.Id = id;
            this.Name = name;
        }
    }
}