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
            List<int> golyok = new List<int>();
            kezdes(golyok);
            int leesett;
            int szamolo = 0;
            do
            {
                szamolo++;
                leesett = eltettsors(golyok);
                Console.WriteLine($"Az elrakott golyó:{leesett} ");
                kiiro(golyok);
                Console.ReadKey();

            } while (golyok.Contains(8));
            if (golyok.Count == 0)
            {
                Console.WriteLine("Nyertél");
            }
            else
            {
                Console.WriteLine("Elraktad a nyolcast!");
                Console.WriteLine("Vesztettél");
            }

            Console.ReadKey();
        }

        static void kiiro(List<int> golyok)
        {
            foreach (var item in golyok)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static int eltettsors(List<int> golyok)
        {
            Random rnd = new Random();
            int szám = rnd.Next(golyok.Count);
            int sorsolt = golyok[szám];
            golyok.Remove(golyok[szám]);
            return sorsolt;


        }

        static void kezdes(List<int> golyok)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyok.Add(i);
            }
        }
    }
}
