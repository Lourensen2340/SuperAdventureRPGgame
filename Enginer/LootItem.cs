using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enginer
{
    internal class LootItem
    {
        public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }
        public LootItem(Item details, int dropPercentage)
        {
            Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = IsDefaultItem;
        }
    }
}
