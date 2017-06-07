using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDispositivos.Interfaces
{
    interface Reparable
    {
         float Precio();

         void Reparar(float precio);
    }
}
