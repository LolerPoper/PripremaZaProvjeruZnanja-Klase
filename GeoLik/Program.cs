using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLik
{
    internal class Program
    {
        class GeometrijskiLik
        {
            protected byte BrojStranica;
            protected double[] Stranice = new double[10];
            public void UcitajStranice()
            {
                for (int i = 0; i < BrojStranica; i++)
                {
                    Console.WriteLine("Upišite duljinu " + (i + 1) + ". stranice");
                    string s = Console.ReadLine();
                    Stranice[i] = Convert.ToDouble(s);
                }
            }
            public double Opseg()
            {
                double opseg = 0;
                for (int i = 0; i < BrojStranica; i++)
                    opseg += Stranice[i];
                return opseg;
            }
        }
        class Trokut : GeometrijskiLik
        {
            public Trokut()
            {
                BrojStranica = 3;
            }
        }
        class Cetverokut : GeometrijskiLik
        {
            public Cetverokut()
            {
                BrojStranica = 4;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Trokut");
            Trokut t = new Trokut();
            t.UcitajStranice();
            Console.WriteLine("Opseg trokuta je " + t.Opseg());
            Console.WriteLine("\nČetverokut");
            Cetverokut c = new Cetverokut();
            c.UcitajStranice();
            Console.WriteLine("Opseg četverokuta je " + c.Opseg());

            Console.ReadKey();
        }
    }
}
