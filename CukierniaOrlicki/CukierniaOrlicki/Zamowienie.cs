using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukierniaOrlicki
{
    abstract class Zamowienie
    {
        protected DateTime czasDostawy;
        
        public virtual bool PoprawnyCzas()
        {
            DateTime czas = DateTime.Now;
            if (czasDostawy > czas)
            {
                return true;
            }
            else 
                return false;
        }
        public void UstawCzasDostawy(DateTime czasDostawy)
        {
            this.czasDostawy = czasDostawy;
        }
    }
}
