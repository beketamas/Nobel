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
        string keresztnev;
        string vezeteknev;

        public Nobel(string sor)
        {
            
            string[] tomb = sor.Split(';');
            this.ev = int.Parse(tomb[0]);
            this.tipus = tomb[1];
            this.keresztnev = tomb[2];
            this.vezeteknev = tomb[3];
        }

        public int Ev { get => ev;}
        public string Tipus { get => tipus; }
        public string Keresztnev { get => keresztnev; }
        public string Vezeteknev { get => vezeteknev; }
    }
}
