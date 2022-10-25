using System;
using System.Collections.Specialized;
using System.Linq.Expressions;

namespace Cadenas
{

    class Program
    {

        static void Main(string[] args)
        {

            bool ok = true;

            do
            {

                Console.WriteLine("Introduzca un texto");
                string cad = Console.ReadLine();

                while (cad != null && ok)
                {

                    if (cad.Length < 40)
                    {
                        Console.WriteLine("Introduzca nueva cadena con al menos 40 caracteres");
                        cad = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("------MENU------");
                        Console.WriteLine("A.Modificar palabra");
                        Console.WriteLine("B.Buscar");
                        Console.WriteLine("C.Buscar inicio");
                        Console.WriteLine("D.SALIR");

                        string opMenu = Console.ReadLine();

                        switch (opMenu)
                        {
                            case "A":
                                Console.WriteLine("Introduce dos palabras separadas  (palsustituta pal_a_sust)");
                                string x = Console.ReadLine();
                                String[] pal = x.Split(' ');
                                string aux = cad.Replace(pal[0], pal[1]);
                                Console.WriteLine("Texto resultante: " + aux); 
                                break;

                            case "B":
                                Console.WriteLine("Introduce texto");
                                string z = Console.ReadLine();

                                if (cad.Contains(z))
                                {
                                    Console.WriteLine("texto encontrado");
                                }
                                else
                                {
                                    Console.WriteLine("texto NO encontrado");
                                }
                                break;

                            case "C":
                                Console.WriteLine("introduce texto");
                                string y = Console.ReadLine();

                                if (cad.StartsWith(y))
                                {
                                    Console.WriteLine("El texto comienza por la cadena leída por teclado");
                                }
                                else
                                {
                                    Console.WriteLine("El texto NO comienza por la cadena leída por teclado");
                                }
                                break;

                            case "D":
                                ok = false;
                                break;
                        }
                    }
                }
            } while(ok);
        }
    }
}