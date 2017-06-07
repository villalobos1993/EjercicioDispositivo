using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDispositivos.Interfaces;
using EjercicioDispositivos.Models;
using EjercicioDispositivos.Main;
using EjercicioDispositivos.M;

namespace EjercicioDispositivos
{
  
    class Program
    {
        static public Tienda t;
        static void Main(string[] args)
        {

            bool correcto = false;
            do
            {
                byte eleccion = Menu();
                switch (eleccion)
                {
                    case 0:Console.WriteLine("La opcion no existe"); break;
                    case 1:CrearDispositivo(); break;
                }

            } while (correcto);
           
        }


        public static byte Menu()
        {
            byte eleccion;
            String aux;
            Console.WriteLine("Que desea hacer:");
            Console.WriteLine("1. Añadir dispositivo.");
            Console.WriteLine("2. Reparar dispositivo.");
            Console.WriteLine("3. Entregar dispositivo.");

            aux = Console.ReadLine();

            try
            {
                eleccion = byte.Parse(aux);
            }
            catch (Exception e)
            {
                throw new Exception("Error: no ha introducido un valor valido");
            }

            if (eleccion > 0 && eleccion <= 3) { 
           
                    return eleccion; }
            else
            {
                return 0;
            }


        }

        
        public static void CrearDispositivo()
        {
            byte eleccion;
            String aux;
            Console.WriteLine("Que quieres crear");
            Console.WriteLine("1. Movil");
            Console.WriteLine("2. Tablet");
            Console.WriteLine("3. PC");
            Console.WriteLine("4. Portatil");


            aux = Console.ReadLine();

            try
            {
                eleccion = byte.Parse(aux);
            }
            catch (Exception e)
            {
                throw new Exception("Error: no ha introducido un valor valido");
            }

            if (eleccion >= 1 && eleccion <= 4) {
                switch (eleccion)
                {
                    case 1 : crearMovil(); break;
                }

            }

        }

        public static void crearMovil()
        {

            bool correcto = true;
            string marca;
            string modelo;
            string so;
            String aux;
            int Pulgadas;
            Console.WriteLine("Introduzca la marca.");
            marca = Console.ReadLine();
            if (marca.Equals(""))
            {
                do
                {
                    Console.WriteLine("Introduzca la marca.");
                    marca = Console.ReadLine();
                    if (marca.Equals(""))
                    {
                        correcto = false;
                    }
                    else
                    {
                        correcto = true;
                    }
                } while (correcto);
            }
            Console.WriteLine("Introduzca el Modelo");
            modelo = Console.ReadLine();

            if (modelo.Equals(""))
            {
                do
                {
                    Console.WriteLine("Introduzca la marca.");
                    modelo = Console.ReadLine();
                    if (modelo.Equals(""))
                    {
                        correcto = false;
                    }
                    else
                    {
                        correcto = true;
                    }

                } while (correcto);
            }
                Console.WriteLine("introduzca sistema operativo");
                so = Console.ReadLine();
                if (so.Equals(""))
                {
                    do
                    {
                        Console.WriteLine("Introduzca la marca.");
                        so = Console.ReadLine();
                        if (so.Equals(""))
                        {
                            correcto = false;
                        }
                        else
                        {
                            correcto = true;
                        }

                    } while (correcto);


                    Console.WriteLine("introduzca el numero de pulgadas");
                    aux = Console.ReadLine();

                    try
                    {
                        Pulgadas = Int32.Parse(aux);
                    correcto = true;
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Error: caracter no valido");
                   
                }

                if (correcto)
                {
                    Dispositivo x = new Movil(marca,modelo,so,Pulgadas);
                    t.añadir(x);
                }


                }
            }


        public static void CrearTablets()
        {
            bool correcto = true;
            string marca;
            string cpu;
            string modelo;
            string so;
            String aux;
            int Pulgadas;
            Console.WriteLine("Introduzca la marca.");
            marca = Console.ReadLine();
            if (marca.Equals(""))
            {
                do
                {
                    Console.WriteLine("Introduzca la marca.");
                    marca = Console.ReadLine();
                    if (marca.Equals(""))
                    {
                        correcto = false;
                    }
                    else
                    {
                        correcto = true;
                    }
                } while (correcto);
            }
            Console.WriteLine("Introduzca el Modelo");
            modelo = Console.ReadLine();

            if (modelo.Equals(""))
            {
                do
                {
                    Console.WriteLine("Introduzca la modelo.");
                    modelo = Console.ReadLine();
                    if (modelo.Equals(""))
                    {
                        correcto = false;
                    }
                    else
                    {
                        correcto = true;
                    }

                } while (correcto);
            }
            Console.WriteLine("introduzca sistema operativo");
            so = Console.ReadLine();
            if (so.Equals(""))
            {
                do
                {
                    Console.WriteLine("Introduzca la sistema operativo.");
                    so = Console.ReadLine();
                    if (so.Equals(""))
                    {
                        correcto = false;
                    }
                    else
                    {
                        correcto = true;
                    }

                } while (correcto);



                Console.WriteLine("introduzca el voltaje de la fuente");
                aux = Console.ReadLine();

                try
                {
                    Pulgadas = Int32.Parse(aux);
                    correcto = true;
                }
                catch (Exception e)
                {
                    throw new Exception("Error: caracter no valido");

                }

                if (correcto)
                {
                    Dispositivo x = new Tablet(marca, modelo, so, Pulgadas);
                    t.añadir(x);
                }


            }
        }


        public static void CrearPc()
        {
            bool correcto = true;
            string marca;
            string modelo;
            string cpu;
            string so;
            String aux;
            int fuenteA;
            Console.WriteLine("Introduzca la marca.");
            marca = Console.ReadLine();
            if (marca.Equals(""))
            {
                do
                {
                    Console.WriteLine("Introduzca la marca.");
                    marca = Console.ReadLine();
                    if (marca.Equals(""))
                    {
                        correcto = false;
                    }
                    else
                    {
                        correcto = true;
                    }
                } while (correcto);
            }
            Console.WriteLine("Introduzca el Modelo");
            modelo = Console.ReadLine();

            if (modelo.Equals(""))
            {
                do
                {
                    Console.WriteLine("Introduzca la modelo.");
                    modelo = Console.ReadLine();
                    if (modelo.Equals(""))
                    {
                        correcto = false;
                    }
                    else
                    {
                        correcto = true;
                    }

                } while (correcto);
            }
            Console.WriteLine("introduzca sistema operativo");
            so = Console.ReadLine();
            if (so.Equals(""))
            {
                do
                {
                    Console.WriteLine("Introduzca sistema operativo.");
                    so = Console.ReadLine();
                    if (so.Equals(""))
                    {
                        correcto = false;
                    }
                    else
                    {
                        correcto = true;
                    }

                } while (correcto);

                Console.WriteLine("Introduzca el cpu.");
                cpu = Console.ReadLine();
                if (marca.Equals(""))
                {
                    do
                    {
                        Console.WriteLine("Introduzca el cpu.");
                        marca = Console.ReadLine();
                        if (marca.Equals(""))
                        {
                            correcto = false;
                        }
                        else
                        {
                            correcto = true;
                        }
                    } while (correcto);
                }
                Console.WriteLine("introduzca el numero de pulgadas");
                aux = Console.ReadLine();

                try
                {
                    fuenteA = Int32.Parse(aux);
                    correcto = true;
                }
                catch (Exception e)
                {
                    throw new Exception("Error: caracter no valido");

                }

                if (correcto)
                {
                    Dispositivo x = new Pc(fuenteA,cpu,marca, modelo, so);
                    t.añadir(x);
                }


            }
        }


        public static void Demo()
        {
          
            Dispositivo p = new Pc(1200, "intel", "Acer", "Predator", "Windows");
           
            Console.WriteLine(p.ToString());

        }
    }
}
