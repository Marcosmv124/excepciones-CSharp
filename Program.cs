using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_elevar_un_número_al_cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            // programa que eleve un numero al cuadrado
            Console.Title = "Elevar un número al cuadrado";
            int N;
            int R; 
            try
            {
               
               
                    Console.Write("Ingresa un numero: ");
                    N = int.Parse(Console.ReadLine());
                    R = N * N; 
                    Console.WriteLine("Numero elevado al cuadrado:" + R);
                
               
            }
            catch (System.FormatException A )
            {
                Console.WriteLine(" error Ingreso letra: " + A.Message); 
            }
            catch(SystemException D)
            {
                Console.WriteLine("error Ingreso un numero decimal: " + D.Message);  
            }
            Console.Write("Para salir presione enter: "); 
            Console.ReadKey(); 

        }
    }
}
