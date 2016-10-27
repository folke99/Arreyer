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
            */
            //Övning 3
            /*
            int[] numbArrey = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };
            int bytPlats;
            for (int i = 0; i < numbArrey.Length; i++)
            {
                for (int j = i; j < numbArrey.Length; j++)
                {
                    if (numbArrey[i] > numbArrey[j])
                    {
                        bytPlats = numbArrey[i];
                        numbArrey[i] = numbArrey[j];
                        numbArrey[j] = bytPlats;
                    }
                }
            }
            for (int k = numbArrey.Length - 1; 0 < k; k--)
            {
                Console.WriteLine(numbArrey[k] + " ");
            }
            Console.ReadKey();
            */
            //Övning 4
            /*
            string[] names = new string[] { "Citron", "Apple", "Cocos", "Banan", "Andre", "Dadel", "Aprikos" };
            string bytPlats;
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = i; j < names.Length; j++)
                {
                    if (names[i].CompareTo(names[j]) > 0)
                    {
                        bytPlats = names[i];
                        names[i] = names[j];
                        names[j] = bytPlats; 
                    }
                }
            }
            for (int k = 0; k < names.Length; k++)
            {
                Console.WriteLine(names[k] + " ");
            }
            Console.ReadKey();
            */
            //Övning 5
            string[] names = new string[] { "Citron", "Apple", "Cocos", "Banan", "Andre", "Dadel", "Aprikos" };
            string bytPlats;
            foreach (string i in names)
            {
                foreach (string j in names)
                {
                    if (names[i].CompareTo(names[j]) > 0)
                    {
                        bytPlats = names[i];
                        names[i] = names[j];
                        names[j] = bytPlats;
                    }
                }
            }
        }//static
    }
}
