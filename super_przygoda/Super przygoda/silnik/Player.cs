using System;
using System.Collections.Generic;
using System.Text;

namespace silnik
{
    public class Player: LivingCreature
    {
       public int CurrentBatteries { get; set; }
       public int MaximumBatteries { get; set; }
       public int Platinum { get; set; }
       public int ExperiencePoints { get; set; }
       public int Level { get; set; }
    }
}
