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
            Dispositivo p = new Pc("Acer", "Predator", "Windows");
            Console.WriteLine(m.toString());
            Console.WriteLine(p.toString());

            p.Reparar(12.00f);
        }
    }
}
