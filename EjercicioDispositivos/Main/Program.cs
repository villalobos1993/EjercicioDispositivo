using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDispositivos.Interfaces;
using EjercicioDispositivos.Models;

namespace EjercicioDispositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispositivo m = new Movil("Samsung", "Note", "Android", 10);
            Dispositivo p = new Pc(1200,"intel","Acer", "Predator", "Windows");
            Console.WriteLine(m.ToString());
            Console.WriteLine(p.ToString());

            p.Reparar(12.00f);
        }
    }
}
