using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace silnik
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();

        public const int ITEM_ID_PODSTAWOWE_DZIAŁO = 1;
        public const int ITEM_ID_DENOBIULAŃSKIE_PIJAWKI = 2;
        public const int ITEM_ID_SKÓRA_VARGA = 3;
        public const int ITEM_ID_USZY_MAKLAKA = 4;
        public const int ITEM_ID_ZĘBY_MAKLAKA = 5;

    }
}
