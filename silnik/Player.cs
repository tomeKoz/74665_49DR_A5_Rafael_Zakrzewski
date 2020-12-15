using System;
using System.Collections.Generic;
using System.Text;


namespace silnik
{
    public class Player : LivingCreature
    {
        public int CurrentBatteries { get; set; }
        public int MaximumBatteries { get; set; }
        public int Platinum { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<InvertoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public Location CurrentLocation { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int curentBatteries, int maximumbatteries, int platinum, int experiencePoints, int level)
            : base(currentHitPoints, maximumHitPoints)
        {
            CurrentBatteries = curentBatteries;
            MaximumBatteries = maximumbatteries;
            Platinum = platinum;
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<InvertoryItem>();
            Quests = new List<PlayerQuest>();
        }
        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if (location.ItemRequiredToEnter == null)
            {
                return true;
            }
            foreach (InvertoryItem ii in Inventory)
            {
                if (ii.Details.ID == location.ItemRequiredToEnter.ID)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasThisQuest(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if(playerQuest.Details.ID == quest.ID)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CompletedThisQuest(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if(playerQuest.Details.ID== quest.ID)
                {
                    return playerQuest.IsCompleted;
                }
            }
            return false;
        }
        public bool HasAllQuestCompletionItem(Quest quest)
        {
            foreach(QuestCompletionItem qci in quest.QuestCompletionItem)
            {
                bool foundItemInPlayersInventory = false;
                foreach(InvertoryItem ii in Inventory)
                {
                    if(ii.Details.ID == qci.Details.ID)
                    {
                        foundItemInPlayersInventory = true;
                        if(ii.Quantity<qci.Quantity)
                        {
                            return false;
                        }
                    }
                }
                if (!foundItemInPlayersInventory)
                {
                    return false;
                }
            }
            return true;
        }
        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach (QuestCompletionItem qci in quest.QuestCompletionItem)
            {
                foreach (InvertoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        ii.Quantity -= qci.Quantity;
                        break;
                    }
                }
            }
        }
        public void AddItemToInvetory(Item itemToAdd)
        {
            foreach (InvertoryItem ii in Inventory)
            {
                if(ii.Details.ID == itemToAdd.ID)
                {
                    ii.Quantity++;
                    return;
                }
            }
            Inventory.Add(new InvertoryItem(itemToAdd, 1));
        }
        public void MarkQuestCompleted(Quest quest)
        {
            foreach(PlayerQuest pq in Quests)
            {
                if (pq.Details.ID == quest.ID)
                {
                    pq.IsCompleted = true;
                    return;
                }
            }
        }

    }    
        
}

