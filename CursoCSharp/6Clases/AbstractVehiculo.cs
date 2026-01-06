using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6Clases
{
    public abstract class AbstractVehiculo
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Precio { get; private set; }
        public int Potencia { get; private set; }
        public double VelocidadActual { get;  set; } // km/h
        protected double _factorAceleracion = 0.1;
        protected double _factorFrenado = 0.8;

        public AbstractVehiculo(string marca, string modelo, int precio, int potencia, double factorAceleracion, double factorFrenado)
        {

            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Potencia = potencia;
            VelocidadActual = 0;
            _factorAceleracion = factorAceleracion;
            _factorFrenado = factorFrenado;

        }
        public void Acelerar()
        {
            // Aumenta la velocidad en función de la potencia
            VelocidadActual += Potencia * _factorAceleracion;
        }
        public abstract void Frenar();
        public abstract void TocarBocina();

        public override string ToString()
        {
            return $"Coche: {Marca} {Modelo}, Precio: ${Precio}, Potencia: {Potencia} HP, Velocidad actual: {VelocidadActual:F2} km/h";
        }

    }
}