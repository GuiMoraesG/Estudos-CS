using System;

namespace Excecoes_Ex001.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        { 
            
        }
    }
}
