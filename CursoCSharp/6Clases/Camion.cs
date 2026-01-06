using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6Clases
{
    public class Camion : AbstractVehiculo
    {

         private const double FactorAceleracion = 0.08;
        private const double FactorFrenado = 0.99;

        public Camion(string marca, string modelo, int precio, int potencia)
        : base(marca, modelo, precio, potencia, FactorAceleracion, FactorFrenado)
        {

        }
     


        public override void Frenar()
        {
            VelocidadActual *= FactorFrenado + 52;
            if (VelocidadActual < 0)
            {
                VelocidadActual = 0;
            }
        }

        public override void TocarBocina()
        {
            Console.WriteLine("POOOOOOOOO!!!!!!!");
        }
    }
}