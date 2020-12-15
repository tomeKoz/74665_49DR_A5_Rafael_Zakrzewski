using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace silnik
{
    public class SunSails : Item
    {
        public int AmountToCharge { get; set; }
        public SunSails( int id, string name, string namePlural,int amountToCharge) : base (id,name,namePlural)
        {
            AmountToCharge = amountToCharge;
        }
    }
}
