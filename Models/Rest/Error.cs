using System;
using System.Collections.Generic;

namespace Ventas.Models.Rest{
    public class Error{
        public string ErrorCode { set; get; }
        public string Description { set; get; }
        public Exception Cause { set; get; }

        public Error() {}

        public Error(string errorCode){
            this.ErrorCode = errorCode;
        }

        public Error(string errorCode, string description){
            this.ErrorCode = errorCode;
            this.Description = description;
        }

        public Error(string errorCode, string description, Exception cause){
            this.ErrorCode = errorCode;
            this.Description = description;
            this.Cause = cause;
        }
    }
}