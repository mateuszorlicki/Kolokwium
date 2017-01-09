using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukierniaOrlicki
{
    class Skladnik
    {
        private string nazwaSkladnika;
        private string ilosc;
        private double cenaSkladnika;

        public Skladnik(string nazwaSkladnika, string ilosc, double cenaSkladnika)
        {
            this.nazwaSkladnika = nazwaSkladnika;
            this.ilosc = ilosc;
            this.cenaSkladnika = cenaSkladnika;
        }
        public override string ToString()
        {
            return "Nazwa: " + nazwaSkladnika + ", ilość: " + ilosc + ", cena: " + cenaSkladnika;
        }
        public object ZwrocCene()
        {
            return cenaSkladnika;
        }

        /*     
         * Próba wykonania podpunktu nr2. 
         * 
         * 
         * 
         * class Skladnik : Icomparable <Skladnik>
         * 
         * 
        public object CompareTo(Skladnik inny)
        {
           
            if (this.nazwaSkladnika == inny.nazwaSkladnika)
            {
                return this.nazwaSkladnika.CompareTo(inny.nazwaSkladnika);
            }
            return inny.nazwaSkladnika.CompareTo(this.nazwaSkladnika);
        }
        */
       
    }
}
