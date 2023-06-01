using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nobel> lista = File.ReadAllLines("..//..//nobel.csv").Skip(1).Select(x => new Nobel(x)).ToList();
            //4. feldat
            lista.Where(x => x.Ev == 2017 && x.Tipus == "irodalmi").ToList().ForEach(x => Console.WriteLine($"4. feldat: {x.Keresztnev} {x.Vezeteknev}"));
            //6. feladat
            Console.WriteLine($"6. feldat: ");
            lista.Where(x => x.Vezeteknev.Contains("Curie")).ToList().ForEach(x => Console.WriteLine($"{x.Ev}: {x.Keresztnev} {x.Vezeteknev}({x.Tipus})"));
            //7. feldat
            Console.WriteLine($"7. feladat:");
            lista.GroupBy(x => x.Tipus).ToList().ForEach(x => Console.WriteLine($"{x.Key}\t\t\t{x.Count()}db"));
            //8. feldat
            Console.WriteLine($"8. feldat: orvosi.txt");
            File.WriteAllLines("orvosi.txt", lista.Where(x => x.Tipus =="orvosi").OrderBy(x => x.Ev).ToList().Select(x => $"{x.Ev}:{x.Keresztnev} {x.Vezeteknev}"));

            //Készen van 19 perc alatt BRAVÓ TAMÁS!!!

            //3 feldata
            lista.Where(x => x.Keresztnev == "Arthur B." && x.Vezeteknev == "McDonald").ToList().ForEach(x => Console.WriteLine($"3. feldata: {x.Tipus}"));

            //5. feldata
            lista.Where(x => x.Vezeteknev == "" && x.Tipus == "béke" && x.Ev > 1990).ToList().ForEach(x => Console.WriteLine($"{x.Ev}\t{x.Keresztnev}"));
        }
    }
}
