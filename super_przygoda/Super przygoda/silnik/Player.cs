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
       public List<InvertoryItem>Inventory { get; set; }
       public List<PlayerQuest> Quests { get; set; }
        public Player(int currentHitPoints, int maximumHitPoints, int curentBatteries, int maximumbatteries, int platinum, int experiencePoints, int level)
            :base(currentHitPoints,maximumHitPoints)
        {
            Platinum = platinum;
            ExperiencePoints = experiencePoints;
            Level = level;
            CurrentBatteries = curentBatteries;
            MaximumBatteries = maximumbatteries;
            Inventory = new List<InvertoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
