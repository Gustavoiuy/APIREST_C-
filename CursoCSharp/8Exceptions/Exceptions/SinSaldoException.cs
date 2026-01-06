using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8Exceptions.Exceptions
{
    public class SinSaldoException :Exception
    {
        public SinSaldoException(string message) : base(message) { }
    }
}