using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDispositivos.Models
{
    class Pc:Dispositivo
    {
        private int FuenteA;
        private List<String> Piezas;
        private Enum Ram;
        private String procesador;

        public Pc (int FuenteA, String procesador,String Marca,String Modelo,String SO) : base(Marca, Modelo, SO)
        {
            this.FuenteA = FuenteA;
            this.procesador = procesador;
        }


        public override String ToString()
        {
            return Marca + " " + Modelo + " " + SO+" " + FuenteA+" "+procesador ;
        }

    }
}
