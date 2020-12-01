using System;
using System.Collections.Generic;
using System.Text;

namespace silnik
{
    public class Monster: LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExpiriencePoints { get; set; }
        public int RewardPlatinium { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints,
            int rewardPlatinum,int currentHitPoints,int maximumHitPoints)
            :base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExpiriencePoints = rewardExperiencePoints;
            RewardPlatinium = rewardPlatinum;
            LootTable = new List<LootItem>();
        }
    }
}
