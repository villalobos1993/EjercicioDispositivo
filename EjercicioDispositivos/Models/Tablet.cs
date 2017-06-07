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
        public Tablet(String Marca, String Modelo, String SO, int Pulgadas, bool Reparado) : base(Marca, Modelo, SO,Pulgadas)
        {

        }


        public override String ToString()
        {
            return Marca + " " + Modelo + " " + SO + " " + Pulgadas;
        }

    }
}
