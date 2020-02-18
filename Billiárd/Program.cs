using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiárd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            Kezdés(golyók);
            int Leesik;
            do
            {
                
                Leesik=Leesősorsoló(golyók);
                Kiíró(golyók);
                Console.WriteLine(Leesik);
                Console.ReadKey();
            } while (golyók.Count!=8);
            if (golyók.Count==8)
            {
                Console.WriteLine("Nyertél.");
            }
            
            Console.ReadKey();
        }

        static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static int Leesősorsoló(List<int> golyók)
        {
            Random gép = new Random();
            int szám = gép.Next(golyók.Count);
            golyók.Remove(golyók[szám]);
            return golyók[szám];
            
        }

        static void Kezdés(List<int> golyók)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
