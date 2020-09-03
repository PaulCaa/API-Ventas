using System;
using System.Collections.Generic;

namespace Ventas.Exceptions{
    public class RepositoryOperationException : HttpException{

        private const string DEFAULT_MESSAGE = "Error en operacion con base de datos";

        public RepositoryOperationException() : base(DEFAULT_MESSAGE){}

        public RepositoryOperationException(string message) : base(message) {}

        public RepositoryOperationException(Exception cause) : base(DEFAULT_MESSAGE, cause) {}

        public RepositoryOperationException(string message, Exception cause) : base(message, cause) {}

    }
}