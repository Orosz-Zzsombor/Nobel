using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nobel
    {
        int ev;
        string tipus;
        string keresztNev;
        string vezetekNev;

        public Nobel(string CSVsor)
        {
            var mezo = CSVsor.Split(';');
            this.ev = int.Parse(mezo[0]);
            this.tipus = mezo[1];
            this.vezetekNev = mezo[2];
            this.keresztNev = mezo[3];
        }
        public Nobel(int ev, string tipus, string keresztNev, string vezetekNev)
        {
            this.ev = ev;
            this.tipus = tipus;
            this.keresztNev = keresztNev;
            this.vezetekNev = vezetekNev;
        }

        public int Ev { get => ev; set => ev = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string KeresztNev { get => keresztNev; set => keresztNev = value; }
        public string VezetekNev { get => vezetekNev; set => vezetekNev = value; }
    }
}
