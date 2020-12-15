using System;
using System.Collections.Generic;
using System.Text;

namespace silnik
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem(Item details, int dropPercentage, bool isDefailtItem)
        {
            Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefailtItem;
        }
    }
}
