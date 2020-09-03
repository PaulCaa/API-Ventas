using System;
using System.Collections.Generic;
using Ventas.Models;

namespace Ventas.Repository{
    public class ProductDetailRepositoryMock{

        private List<ProductDetail> DetailsProducts;

        public ProductDetailRepositoryMock(){
            this.DetailsProducts = new List<ProductDetail>(){
                new ProductDetail(1,0.9f,0,0,""),
                new ProductDetail(2,0.95f,0,0,""),
                new ProductDetail(3,0.45f,0,0,""),
                new ProductDetail(4,0.45f,0,0,""),
                new ProductDetail(5,0.25f,0,0,""),
                new ProductDetail(6,0.32f,0,0,""),
                new ProductDetail(7,0.9f,0,0,""),
                new ProductDetail(8,0.9f,0,0,""),
                new ProductDetail(9,0.9f,0,0,""),
                new ProductDetail(10,0.9f,0,0,""),
                new ProductDetail(11,0.89f,0,0,""),
                new ProductDetail(12,0.85f,0,0,""),
                new ProductDetail(13,0.65f,0,0,""),
                new ProductDetail(14,0.66f,0,0,""),
                new ProductDetail(15,5.2f,0,0,""),
                new ProductDetail(16,3.9f,0,0,""),
                new ProductDetail(17,0.0f,0,0,"")
            };
        }

        public List<ProductDetail> GetAllDetails(){
            return DetailsProducts;
        }

        public ProductDetail GetDetailBy(int Id){
            foreach(ProductDetail d in DetailsProducts){
                if(d.Id == Id){
                    return d;
                }
            }
            return null;
        }

        public ProductDetail AddDetail(ProductDetail detail){
            detail.Id = DetailsProducts.Count + 1;
            DetailsProducts.Add(detail);
            return detail;
        }

        public ProductDetail UpdateDetail(ProductDetail detail){
            foreach(ProductDetail d in DetailsProducts){
                if(d.Id == detail.Id){
                    d.Weight = detail.Weight;
                    d.Width = detail.Weight;
                    d.Height = detail.Height;
                    d.Color = detail.Color;
                    return d;
                }
            }
            return null;
        }

    }
}