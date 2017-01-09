using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukierniaOrlicki
{
    class Przepis
    {
        private string nazwa;
        private double suma = 0;
        private List<Skladnik> skladniki = new List<Skladnik>();
        private int czasPrzygotowania;

        public void DodajSkladnik(string nazwaSkladnika, string ilosc, double cenaSkladnika)
        {
            skladniki.Add(new Skladnik(nazwaSkladnika, ilosc, cenaSkladnika));
            suma = suma + cenaSkladnika;
        }
        private void UstawNazweICzas(string nazwa, int czasPrzygotowania)
        {
            this.nazwa = nazwa;
            this.czasPrzygotowania = czasPrzygotowania;

        }
        public override string ToString()
        {
            if (skladniki.Any())
            {
                foreach (var x in skladniki)
                {
                    Console.WriteLine(x.ToString());
                }
                Console.WriteLine("Suma: " + suma);
            }
            else return "";
            return "";
        }
        private bool CzyCzas()
    {
        if (czasPrzygotowania > 0)
        {
            return true;
        }
        else return false;

    }
        private int IleSkladnikow()
        {
            return skladniki.Count();
        }

    }
}
