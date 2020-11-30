using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace silnik
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Location(int id, string name, string descritpion)
        {
            ID = id;
            Name = name;
            Description = descritpion;
        }
    public Item ItemRequiredToEnter { get; set; }
    public Item RewardItem { get; set; }
    public Quest QuestAvailableHere { get; set; }
    public Monster MonsterLivinHere { get; set; }
    public Location LocationPrzod { get; set; }
    public Location LocationTył { get; set; }
    public Location LocationPrawo { get; set; }
    public Location LocationLewo { get; set; }

    public Location(int id,string name, string description,
        Item intemRequiredToEnter = null,
        Quest questAvailableHere = null,
        Monster monsterLivingHere = null,
        Item rewardItem=null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = intemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivinHere = monsterLivingHere;
            RewardItem = rewardItem;
        }
    }
}
