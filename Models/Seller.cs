using System;
using System.Collections.Generic;

namespace Ventas.Models
{
    public class Seller{
        public int Id { set; get; }
        public string Name { set; get; }
        public string Surname { set; get; }
        public string Document { set; get; }

        public Seller(){}

        public Seller(int Id, string Name, string Surname, string Document)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Document = Document;
        }
    }
}