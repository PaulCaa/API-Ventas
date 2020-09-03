using System;
using System.Collections.Generic;

namespace Ventas.Models.Rest{
    public class Header{
        public string Result { set; get; }
        public string Method { set; get; }
        public List<Error> Errors;

        public Header(){
            this.Errors = new List<Error>();
        }

        public Header(Error Error){
            this.Errors = new List<Error>();
            Errors.Add(Error);
        }

        public Header(List<Error> Errors){
            this.Errors = Errors;
        }
    }
}