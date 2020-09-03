using System;
using System.Collections.Generic;

namespace Ventas.Exceptions{
    public class BadRequestParameterException : HttpException{

        private const string DEFAULT_MESSAGE = "Error, verificar el parametro de la request";

        public BadRequestParameterException() : base(DEFAULT_MESSAGE,400){}

        public BadRequestParameterException(string Message) : base(Message,400){}
    }
}