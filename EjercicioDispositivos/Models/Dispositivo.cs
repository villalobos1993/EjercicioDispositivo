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

        private Dispositivo() { }

        public Dispositivo(string marca,String modelo,String SO)
        {

            this.Marca = marca;
            this.Modelo = modelo;
            this.SO = SO;
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
          
        public string GenerarMac()
        {

            return "";
        }

        public virtual String toString()
        {
            return Marca + " " + Modelo + " " + SO + " " + Pulgadas;
        }

        public float Precio()
        {
            throw new NotImplementedException();
        }

        public void Reparar(float precio)
        {
            Console.WriteLine("hola");
            throw new NotImplementedException();
        }
    }
}
