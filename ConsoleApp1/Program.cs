using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nobel> Nobel = new List<Nobel>();
            File.ReadAllLines("nobel.csv").Skip(1).ToList().ForEach(x => Nobel.Add(new Nobel(x)));
            Nobel dijas =Nobel.Find(x => x.Ev == 2017 && x.Tipus == "irodalmi");
            Console.WriteLine($"{dijas.VezetekNev} {dijas.KeresztNev}");
            Console.WriteLine("2. feladat: ");
            Nobel.Where(x => x.VezetekNev.Contains("Curie")).GroupBy(x => x.KeresztNev).ToList().ForEach(x => Console.WriteLine($" {x.Key}"));
            Nobel.GroupBy(x => x.Tipus).ToList().ForEach(x => Console.WriteLine($"{x.Key}  {x.Count()}db"));
            StreamWriter sw = new StreamWriter("orvosi.txt", true);
            Nobel.Where(x => x.Tipus == "orvosi").ToList().ForEach(x => sw.WriteLine(x))
        }
    }
}
