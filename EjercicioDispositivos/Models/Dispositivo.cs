using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDispositivos.Models
{
    abstract class Dispositivo
    {

        protected String Marca;
        protected String Modelo;
        protected int Pulgadas;
        protected string SO;

        private Dispositivo() { }

        public Dispositivo(string marca,String modelo)
        {

            this.Marca = marca;
            this.Modelo = modelo;
        }

        public Dispositivo(String Marca,String Modelo,int pulgadas) : this (Marca,Modelo)
        {
            this.Pulgadas = pulgadas;

        }

        
    }
}
