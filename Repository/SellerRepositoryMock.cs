using System;
using System.Collections.Generic;
using Ventas.Models;

namespace Ventas.Repository{
    public class SellerRepositoryMock{
        private List<Seller> Sellers;
        public SellerRepositoryMock(){
            this.Sellers = new List<Seller>(){
                new Seller(1,"Pedro","Sosa","28123456"),
                new Seller(2,"Agustin","Benitez","30123456"),
                new Seller(3,"Romina","Saenz","31987654")
            };
        }

        public List<Seller> GetAllSellers(){
            return Sellers;
        }
    }
}