using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8Exceptions.Exceptions
{
    public class MontoSuperadoException : Exception
    {
        public MontoSuperadoException()
        {
        }

        public MontoSuperadoException(string? message) : base(message)
        {
        }
    }
}