using System;

namespace ConsoleApp1
{
    class Program
    {
       
    
        

        
            static void Main(string[] args)
            {
                Console.WriteLine("Unesite prvi broj: ");
                double broj1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Unesite Matematicku Operaciju ");
                string matop = Console.ReadLine();
                Console.WriteLine("Unesite drugi broj");
                double broj2 = Convert.ToDouble(Console.ReadLine());


                if (matop == "+")
                {
                    Console.WriteLine(broj1 + broj2);

                }
                else if (matop == "/")
                {
                    Console.Write(broj1 / broj2);
                }
                else if (matop == "*")
                {
                    Console.WriteLine(broj1 * broj2);

                }
                else if (matop == "-")
                {
                    Console.WriteLine(broj1 - broj2);
                }
                else
                {
                    Console.WriteLine("niste unejeli validnu matematicku operaciju");
                }

                Console.ReadLine();
            }



        }
    }
