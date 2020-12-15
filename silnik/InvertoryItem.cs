using System;
using System.Collections.Generic;
using System.Text;

namespace silnik
{
    public class InvertoryItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public InvertoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}