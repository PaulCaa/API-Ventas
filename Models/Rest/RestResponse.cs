using System;
using System.Collections.Generic;

namespace Ventas.Models.Rest{
    public class RestResponse{
        public Header Header { set; get; }
        public List<Object> Data { set; get; }

        public RestResponse(){
            this.Data = new List<Object>();
        }

        public RestResponse(Object O){
            this.Data = new List<Object>();
            Data.Add(O);
        }

        public RestResponse(List<Object> Data){
            this.Data = Data;
        }
    }
}