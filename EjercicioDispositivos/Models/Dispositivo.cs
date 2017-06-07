using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDispositivos.Interfaces;
namespace EjercicioDispositivos.Models
{
    abstract class Dispositivo : Reparable
    {

        protected String Marca;
        protected String Modelo;
        protected int Pulgadas;
        protected string SO;
        protected float precio;

        private Dispositivo() { }

        public Dispositivo(string marca,String modelo,String SO)
        {

            this.Marca = marca;
            this.Modelo = modelo;
            this.SO = SO;
            this.precio = 0;
        }

        public Dispositivo(String Marca,String Modelo,String SO,int pulgadas) : this (Marca,Modelo,SO)
        {
            this.Pulgadas = pulgadas;

        }


        public String Marcas
        {
            get
            {
                return Marca;
            }
        }

        public String Modelos
        {
            get
            {
                return Modelo;
            }
        }

        public int Pulgada
        {

            get
            {
                return Pulgadas;
            }
        }

        public String Sistema
        {
            get
            {
                return SO;
            }
        }
          
        public float Precios
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }

        public string GenerarMac()
        {

            return "";
        }

        public virtual String ToString()
        {
            return Marca + " " + Modelo + " " + SO + " " + Pulgadas;
        }

        public float Precio()
        {
            float cantidad1;
            String cantidad2;
            Console.WriteLine("Introduzca el precio de reparacion");
            cantidad2 = Console.ReadLine();
            try
            {
                cantidad1 = Single.Parse(cantidad2);

            }
            catch(Exception e)
            {
                throw new Exception("Error: no es un dato correcto.");
            }

            return cantidad1;
        }

        public void Reparar(float precio)
        {
            if (precios > precio)
            {

            }
        }
    }
}
