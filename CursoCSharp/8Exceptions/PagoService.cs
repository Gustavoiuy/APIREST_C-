using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _8Exceptions.Exceptions;

namespace _8Exceptions
{
    public class PagoService
    {
        const int montoMaximo = 100;

        public void Realizar(int monto, string persona)
        {
            if (string.IsNullOrEmpty(persona))
            {
                throw new ArgumentException("mensaje no puede ser null o vacio");
            }

            if (monto > montoMaximo)
            {
                throw new MontoSuperadoException();
                //throw new MontoSuperadoException($"el cliente {persona} ha intentado hacer un pago > que {montoMaximo} USD");
            }

            if (persona.ToLower() == "juan" && monto > 20)
            {
                throw new SinSaldoException($"el cliente {persona} ha intentado hacer un pago y no tiene saldo suficiente");
            }
        }
    }
}