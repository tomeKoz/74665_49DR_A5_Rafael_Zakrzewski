using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace silnik
{
    public class QuestCompletionItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public QuestCompletionItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
