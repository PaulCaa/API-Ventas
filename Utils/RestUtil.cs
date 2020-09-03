using System;
using System.Collections.Generic;
using Ventas.Models.Rest;

namespace Ventas.Utils{
    public class RestUtil{

        public static Header GenerateHeaderOk(String method){
            Header header = new Header();
            header.Result = "OK";
            header.Method = method;
            return header;
        }
        public static Header GenerateHeaderError(Error error, string method){
            Header header = new Header(error);
            header.Result = "ERROR";
            header.Method = method;
            return header;
        }

    }
}