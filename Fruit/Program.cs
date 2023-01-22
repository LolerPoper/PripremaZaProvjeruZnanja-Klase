using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    internal class Program
    {

        public class Fruit
        {
            private string Vrsta;
            private string Boja;
            private bool JeLiSlatko;
            public Fruit(string s)
            {
                Vrsta = s;
            }
            public Fruit(string s1, string s2, bool b)
            {
                Vrsta = s1;
                Boja = s2;
                JeLiSlatko = b;
            }
        }
        static void Main(string[] args)
        {
            Fruit x = new Fruit("Jagoda", "Crvena", true);
            Fruit y = new Fruit("Limun", "Žuta", false);
            Fruit z = new Fruit("Avokado");
        }
    }
}
