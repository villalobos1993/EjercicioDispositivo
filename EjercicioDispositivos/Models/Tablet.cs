using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDispositivos.Models;
namespace EjercicioDispositivos.Main
{
    class Tablet:Dispositivo
    {
        public Tablet(String Marca, String Modelo, String SO, int Pulgadas) : base(Marca, Modelo, SO,Pulgadas)
        {

        }


        public override String toString()
        {
            return Marca + " " + Modelo + " " + SO + " " + Pulgadas;
        }

    }
}
