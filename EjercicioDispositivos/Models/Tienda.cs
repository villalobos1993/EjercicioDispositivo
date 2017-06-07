using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDispositivos.Interfaces;

namespace EjercicioDispositivos.Models
{
    class Tienda 
    {
        IList<Dispositivo> listaAveriada;
        IList<Dispositivo> listaArreglada;
        public Tienda()
        {
            IList<Dispositivo> lista = new List<Dispositivo>();
           

        }

        public void añadir(Dispositivo x)
        {
            listaAveriada.Add(x);
        }

        public void Reparar(Dispositivo x)
        {
            listaArreglada.Add(x);
            listaAveriada.Remove(x);
                        
        }
        public void Entregar(Dispositivo x)
        {
            
            listaArreglada.Remove(x);

        }

      
    }
}
