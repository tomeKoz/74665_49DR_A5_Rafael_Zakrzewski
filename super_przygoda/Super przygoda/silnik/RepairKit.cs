using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace silnik
{
    public class RepairKit : Item
    {
        public int AmountToHeal { get; set; }
        public int AmountToDischarge { get; set; }
        public RepairKit(int id, string name, string namePlural ,int amountToHeal,int amountToDischarge): base(id,name,namePlural)
        {
            AmountToHeal = amountToHeal;
            AmountToDischarge = amountToDischarge;
        }
    }
}
