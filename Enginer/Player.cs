using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enginer
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExpirencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<Quest> Quests { get; set; }
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int expirencePoints, int level)
            : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExpirencePoints = expirencePoints;
            Level = level;

            Inventory = new List<InventoryItem>();
            Quests = new List<Quest>();
        }
    }

    public class InventoryItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }
    }
}
