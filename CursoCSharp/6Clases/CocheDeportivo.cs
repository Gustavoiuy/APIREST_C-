using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6Clases
{
    public class CocheDeportivo : AbstractVehiculo
    {
        private const double FactorAceleracion = 0.3;
        private const double FactorFrenado = 0.8;

        public CocheDeportivo(string marca, string modelo, int precio, int potencia)
        : base(marca, modelo, precio, potencia, FactorAceleracion, FactorFrenado)
        {

        }
        public override void Frenar()
        {
            VelocidadActual *= _factorFrenado;

            // No permitir velocidad negativa
            if (VelocidadActual < 0)
            {
                VelocidadActual = 0;
            }
        }

        public override void TocarBocina()
        {
            Console.WriteLine("PIiii pero pijo eh!");
        }
    }
}