using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace silnik
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperience { get; set; }
        public int RewardPlatinum { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItem { get; set; }

        public Quest(int id,string name,string description,int rewardExperience,int rewardPlatinum)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperience = rewardExperience;
            RewardPlatinum = rewardPlatinum;
            QuestCompletionItem = new List<QuestCompletionItem>();
        }
        
    }
}
