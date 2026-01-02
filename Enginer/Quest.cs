using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enginer
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExpireancePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }

        public Quest(int id, string name, string description, int rewardExpireancePoints, int rewardGold) 
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExpireancePoints = rewardExpireancePoints;
            RewardGold = rewardGold;
        }
    }
}
