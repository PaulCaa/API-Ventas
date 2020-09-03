using System;
using System.Collections.Generic;

namespace Ventas.Models
{
    public class Client{
        public int Id { set; get; }
        public string Name { set; get; }
        public string Surname { set; get; }
        public string Document { set; get; }
        public string Email { set; get; }
    }
}