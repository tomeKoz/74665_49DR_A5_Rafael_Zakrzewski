using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace silnik
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int AmountToDischarge { get; set; }
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage, int amountToDischarge) : base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            AmountToDischarge = amountToDischarge;
        }
    }
}
