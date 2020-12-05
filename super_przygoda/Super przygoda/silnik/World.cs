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
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_SUN_SAILS = 11;
        public const int ITEM_ID_REPAIR_KIT = 7; 
        public const int ITEM_ID_RAKIETY_FOTONOWE = 6;
        public const int ITEM_ID_PODSTAWOWE_DZIAŁO = 1;
        public const int ITEM_ID_DENOBIULAŃSKIE_PIJAWKI = 2;
        public const int ITEM_ID_SKÓRA_VARGA = 3;
        public const int ITEM_ID_HORĄGIEW_DALTURCZYKÓW = 4;
        public const int ITEM_ID_MUNDUR_DALTURCZYKÓW = 5;
        public const int ITEM_ID_SKRZYDŁA_KESOLOMA = 8;
        public const int ITEM_ID_FUTRO_KESOLOMA = 9;
        public const int ITEM_ID_PRZEPUSTKA = 10;

        public const int MONSTER_ID_FURANIE_DROBNICOWIEC = 1;
        public const int MONSTER_ID_DALTURCZYCY_FREGATA = 2;
        public const int MONSTER_ID_DALTURCZYCY_KANONIERKA = 3;

        public const int QUEST_ID_GET_PIJAWKI = 1;
        public const int QUEST_ID_GET_HORĄGIEW_MAKLAKÓW = 2;

        public const int LOCATION_ID_DOK = 1;
        public const int LOCATION_ID_CERES = 2;
        public const int LOCATION_ID_PLACÓWKA_STAŻNICZA = 3;
        public const int LOCATION_ID_TERYTORIUM_EVENKÓW = 4;
        public const int LOCATION_ID_SZKLAK_EVENKÓW = 5;
        public const int LOCATION_ID_TERYTORIUM_XOBIAN = 6;
        public const int LOCATION_ID_GRANICA_Z_DALTURCZYKAMI = 7;
        public const int LOCATION_ID_JEDWABNY_SZLAK = 8;
        public const int LOCATION_ID_TERYTORIUM_TEMARAN = 9;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }
        private static void PopulateItems()
        {
            Items.Add(new SunSails(ITEM_ID_SUN_SAILS, "Żagle słoneczne", "Żagle słoneczne", 50));
            Items.Add(new RepairKit(ITEM_ID_REPAIR_KIT, "Zestaw naprawczy", "Zestaw naprawczy", 50,10));
            Items.Add(new Weapon(ITEM_ID_PODSTAWOWE_DZIAŁO, "Podstawowe działko", "Podstawowe działko", 0, 50,9));
            Items.Add(new Weapon(ITEM_ID_RAKIETY_FOTONOWE, "Rakiety Fotonowe", "Rakiety Fotonowe", 30, 100,15));
            Items.Add(new Item(ITEM_ID_DENOBIULAŃSKIE_PIJAWKI, "Denobiulańskie pijawki", "Denobiulańskie pijawki"));
            Items.Add(new Item(ITEM_ID_SKÓRA_VARGA,"Skóra Varga", "Skóra Varga"));
            Items.Add(new Item(ITEM_ID_HORĄGIEW_DALTURCZYKÓW, "Horągiew Dalturczyków", "Horągiew Dalturczyków"));
            Items.Add(new Item(ITEM_ID_MUNDUR_DALTURCZYKÓW, "Mundur Dalturczyków", "Mundur Dalturczyków"));
            Items.Add(new Item(ITEM_ID_SKRZYDŁA_KESOLOMA, "Skrzydła Kesoloma", "Skrzydła Kesoloma"));
            Items.Add(new Item(ITEM_ID_FUTRO_KESOLOMA, "Futro Kesoloma", "Futro Kesoloma"));
            Items.Add(new Item(ITEM_ID_PRZEPUSTKA, "Przepustka podróznika", "Przepustka podróżnika"));
        }
        private static void PopulateMonsters()
        {
            Monster furanie_drobnicowiec = new Monster(MONSTER_ID_FURANIE_DROBNICOWIEC, "Furanie Drobnicowiec", 38, 50, 20, 60, 60);
            furanie_drobnicowiec.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DENOBIULAŃSKIE_PIJAWKI), 75, false));
            furanie_drobnicowiec.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SKÓRA_VARGA), 75, true));

            Monster dalturczycy = new Monster(MONSTER_ID_DALTURCZYCY_FREGATA, "Fregata Dalturczyków", 48, 60, 35, 70, 70);
            dalturczycy.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HORĄGIEW_DALTURCZYKÓW), 75, false));
            dalturczycy.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MUNDUR_DALTURCZYKÓW), 75, true));

            Monster dalturczycy_kanonierka = new Monster(MONSTER_ID_DALTURCZYCY_KANONIERKA, "Kanonierka Dalturczyków", 51, 50, 50, 100, 100);
            dalturczycy_kanonierka.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SKRZYDŁA_KESOLOMA), 75, false));
            dalturczycy_kanonierka.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FUTRO_KESOLOMA), 75, true));

            Monsters.Add(furanie_drobnicowiec);
            Monsters.Add(dalturczycy);
            Monsters.Add(dalturczycy_kanonierka);
        }
        private static void PopulateQuests()
        {
            Quest get_pijawki = new Quest(QUEST_ID_GET_PIJAWKI, "Zdobądź Denobiulańskie pijawki",
                "Pokonaj dowolny z Drobnicowców Furanów które przemieżają SZLAK EVENKÓW aby zdobyć Denobiulańskie pijawki" +
                " przeznaczone na handel. Otrzymasz 100 Platinum oraz zestaw naprawczy.", 200, 100);
            get_pijawki.QuestCompletionItem.Add(new QuestCompletionItem(ItemByID(ITEM_ID_DENOBIULAŃSKIE_PIJAWKI), 3));
            get_pijawki.RewardItem = ItemByID(ITEM_ID_REPAIR_KIT);

            Quest get_horągiew_maklaków = new Quest(QUEST_ID_GET_HORĄGIEW_MAKLAKÓW, "Zdobądź horągiew Dalturczyków", "Udaj się" +
                "na granicę z Dalturczykami którzy nękają Xobian i pokonaj Maklaków zdobywając minimum trzy ich horągwie" +
                ". Otrzymasz Przepustkę Podrużnika oraz 100 Platinum ", 200, 100);
            get_horągiew_maklaków.QuestCompletionItem.Add(new QuestCompletionItem(ItemByID(ITEM_ID_HORĄGIEW_DALTURCZYKÓW), 3));
            get_horągiew_maklaków.RewardItem = ItemByID(ITEM_ID_PRZEPUSTKA);

            Quests.Add(get_horągiew_maklaków);
            Quests.Add(get_pijawki);
        }
        private static void PopulateLocations()
        {
            Location dok = new Location(LOCATION_ID_DOK, "Dok",
                "Ogromna stacja dokująca, dzieło twoje cywilizacji. To właśnie" +
                "tu powstał twój wspaniały statek");
            Location ceres = new Location(LOCATION_ID_CERES, "Ceres",
                "Planeta karłowata Ceres to największy znany nam " +
                "obiekt pasa asteroid między Marsem i Jowieszem jeto to również umowny punkt wstępu do strefy planetarnej Ziemi");
            Location guardPost = new Location(LOCATION_ID_PLACÓWKA_STAŻNICZA, "Placówka Strażnicza", "Widzisz ciężko uzbrojoną Placówkę" +
                "strażniczą która jest najdalej wysuniętą tego typu placówką ziemską. Zadaniem tego obiektu jest ochrona " +
                "Ziemskich i sojuszniczych kupców");
            Location terytoriumEvenków = new Location(LOCATION_ID_TERYTORIUM_EVENKÓW, "Terytorium Evenków",
                "Twoje sensory wykrywają" +
                "zamieszkałą planetę, z bazy danych możesz odczytać że jest to Evterus planeta matka Evenków. Wchodzisz na orbitę" +
                "teraz możesz zaobserwować na swoich ekranach że fauna i flora na tej planecie są wyjątkowo bujne." +
                "Rośnie na niej wiele drzew owocowych o przedziwnych nazwach jest też ogromna ilość zwierzyny która znacząco" +
                "odróżnia się od tej którą poznałeś na ziemi");
            Location szlakEvenków = new Location(LOCATION_ID_SZKLAK_EVENKÓW, "Szlak Evenków",
                "Ta część kosmosu wedłóg twoich danych stanowi szlak hanlowy Evenków");
            Location terytoriumXobian = new Location(LOCATION_ID_TERYTORIUM_XOBIAN, "Terytorium Xobian",
                "Twoje sensory wykrywają zamieszkałą planetę. Początkowo widzisz jedynie Planetę która jest cała w wodzie jednak wchodząc na orbitę" +
                "na ekranach widzisz odczyty sensorów które pokazują że podwodą znajduje się cała cywilizacja");
            Location granicaZDalturczykami = new Location(LOCATION_ID_GRANICA_Z_DALTURCZYKAMI, "Granica z Dalturczykami",
                "Ten kwadrant to terytorium sporne między Dalturczykami a Xobianami. Na sensorach możesz odnotować " +
                "trwające potyczki między obydwiema rasami które odbywają się co kilka lat świetlnych między sobą");
            Location jedwabnySzlak = new Location(LOCATION_ID_JEDWABNY_SZLAK, "Jedwabny Szlak", "Sensory wykrywają natężony " +
                "ruch w tej części kosmosu co jest zupełnie normalne gdyż jest to główny szlak międzyplanetarnego handlu");
            Location terytoriumTemaran = new Location(LOCATION_ID_TERYTORIUM_TEMARAN, "Terytorium Temaran", "Wleciałeś na terytorium" +
                "Temaran- wyjątkowo agresywnej cywilizacji. Sekundy po twoim zatrzymaniu słyszysz wielki wybuch i piczenie alarmu " +
                "taktycznego w twoim statku. SZYKUJ SIĘ DO WALKI");

            dok.LocationPrzod = ceres;

            ceres.LocationPrzod = terytoriumEvenków;
            ceres.LocationTył = dok;
            ceres.LocationPrawo = guardPost;
            ceres.LocationLewo = terytoriumXobian;

            terytoriumXobian.LocationPrawo = ceres;
            terytoriumXobian.LocationPrawo = granicaZDalturczykami;

            granicaZDalturczykami.LocationPrawo = terytoriumXobian;

            terytoriumEvenków.LocationTył = ceres;
            terytoriumEvenków.LocationPrzod = szlakEvenków;

            szlakEvenków.LocationTył = terytoriumEvenków;

            guardPost.LocationPrawo = jedwabnySzlak;
            guardPost.LocationLewo = ceres;

            jedwabnySzlak.LocationLewo = guardPost;
            jedwabnySzlak.LocationPrawo = terytoriumTemaran;

            terytoriumTemaran.LocationLewo = jedwabnySzlak;

            Locations.Add(dok);
            Locations.Add(ceres);
            Locations.Add(guardPost);
            Locations.Add(terytoriumEvenków);
            Locations.Add(szlakEvenków);
            Locations.Add(terytoriumXobian);
            Locations.Add(granicaZDalturczykami);
            Locations.Add(jedwabnySzlak);
            Locations.Add(terytoriumTemaran);
        }
        public static Item ItemByID(int id)
        { 
            foreach (Item item in Items)
            {
                if(item.ID ==id)
                {
                    return item;
                }
            }
            return null;
         }
        public static Monster MonsterByID(int id)
        {
            foreach(Monster monster in Monsters)
            {
                if(monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }
        public static Location LocationById(int id)
        {
            foreach(Location location in Locations)
            {
                if(location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }
        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if(quest.ID==id)
                {
                    return quest;
                }
            }
            return null;
        }

    }
}
