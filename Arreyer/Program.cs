using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreyer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            Console.WriteLine("Mata in 10 olika namn:");
            string[] inläst = new string[10];
            for (int i = 0; i < 10; i++)
            {
                inläst[i] = Console.ReadLine();
            }

            for (int i = 0; i < inläst.Length; i++)
            {
                Console.WriteLine(inläst[i]);
            }
            Console.ReadKey();
            */
            //Övning 2
            /*
            Console.WriteLine("Mata in 10 olika namn:");
            int[] inläst = new int[10];
            for (int i = 9; i >= 0; i--)
            {
                inläst[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < inläst.Length; i++)
            {
                Console.WriteLine(inläst[i]);
            }
            Console.ReadKey();           
            //Övning 3
            */            
            int[] numbArrey = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };
            int störst = 0;
            for (int i = 0; i < numbArrey.Length; i++)
            {
                for (int x = 1; x < numbArrey.Length-1; x++)
                {
                    if (numbArrey[i] < numbArrey[x + 1])
                    {
                        störst = numbArrey[x+1];
                        numbArrey[x+1] = numbArrey[x];
                        numbArrey[x] = störst;
                    }
                }
                
            }
            for (int i = 0; i < numbArrey.Length; i++)
            {
                Console.WriteLine(numbArrey[i] + " ");
            }
            Console.ReadKey();

        }//static
    }
}
