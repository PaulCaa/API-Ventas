using System;
using System.Collections.Generic;

namespace Ventas.Exceptions{
    public class HttpException : Exception{

        private const string DEFAULT_MESSAGE = "Error en ejecucion de funcionalidad";

        private int HttpStatus;

        public HttpException() : base(DEFAULT_MESSAGE){
            this.HttpStatus = 500;
        }

        public HttpException(Exception Cause) : base(DEFAULT_MESSAGE,Cause){
            this.HttpStatus = 500;
        }

        public HttpException(string message) : base(message){
            this.HttpStatus = 500;
        }

        public HttpException(string message, Exception Cause) : base(message,Cause){
            this.HttpStatus = 500;
        }

        public HttpException(int HttpStatus) : base(DEFAULT_MESSAGE){
            this.HttpStatus = HttpStatus;
        }

        public HttpException(Exception Cause, int HttpStatus) : base(DEFAULT_MESSAGE,Cause){
            this.HttpStatus = HttpStatus;
        }

        public HttpException(string message, int HttpStatus) : base(message){
            this.HttpStatus = HttpStatus;
        }

        public HttpException(string message, Exception Cause, int HttpStatus) : base(message,Cause){
            this.HttpStatus = HttpStatus;
        }

        public int GetHttpStatus(){
            return HttpStatus;
        }
    }
}