using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6Clases
{
    public class Coche
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }

        public int Precio { get;  private set; }
        public int Potencia { get;  private set; }
        public double VelocidadActual{ get; private set; } // km/h
        private const double FactorAceleracion = 0.1;
        private const double FactorFrenado = 0.8;

        public Coche(string marca, string modelo, int precio, int potencia)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;

            Potencia = potencia;
            VelocidadActual = 0;
        }

        public void Acelerar()
        {
            VelocidadActual += Potencia * FactorAceleracion;
        }
        public void Frenar()
        {
            VelocidadActual *= FactorFrenado;
            if (VelocidadActual < 0)
            {
                VelocidadActual = 0;
            }
        }
        public override string ToString()
        {
            return $"Coche: {Marca} {Modelo}, Precio: ${Precio}, Potencia: {Potencia} HP, Velocidad actual: {VelocidadActual:F2} km/h";
        }


    }
}