using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDispositivos.Models
{
    class Pc:Dispositivo
    {

        public Pc (String Marca,String Modelo,String SO) : base(Marca, Modelo, SO)
        {

        }


        public override String toString()
        {
            return Marca + " " + Modelo + " " + SO ;
        }

    }
}
