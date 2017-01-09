using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukierniaOrlicki
{
    class NaWynos : Zamowienie
    {
        private bool PoprawnyCzas(DateTime czasDostawy)

        {
            TimeSpan dwiegodziny = new TimeSpan(2, 00, 0);
            DateTime czas = DateTime.Now;
            czasDostawy += dwiegodziny;
            if (czasDostawy> czas)
            {
                return true;
            }
            else
                return false;

}
        }
    }

