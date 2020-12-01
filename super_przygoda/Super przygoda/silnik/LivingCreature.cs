using System;
using System.Collections.Generic;
using System.Text;

namespace silnik
{
    public class LivingCreature
    {
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

    public LivingCreature (int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            maximumHitPoints = MaximumHitPoints;
        }
    }
}
