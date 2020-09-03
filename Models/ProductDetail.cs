using System;
using System.Collections.Generic;

namespace Ventas.Models
{
    public class ProductDetail{
        public int Id { set; get; }
        public float Weight { set; get; }
        public float Width { set; get; }
        public float Height { set; get; }
        public string Color { set; get; }

        public ProductDetail(){}
        public ProductDetail(int Id){
            this.Id = Id;
        }
        public ProductDetail(int Id, float Weight, float width, float Height, string Color){
            this.Id = Id;
            this.Weight = Weight;
            this.Width = Width;
            this.Height = Height;
            this.Color = Color;
        }
    }
}