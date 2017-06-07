using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDispositivos.Models;
namespace EjercicioDispositivos
{
    class Movil : Dispositivo
    {

        public Movil(String marca,String modelo,String SO,int Pulgadas) : base(marca, modelo, SO,Pulgadas)
        {


        }

        public override String ToString()
        {
            return Marca + " " + Modelo + " " + SO + " " + Pulgadas;
        }

    }
}
