using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enginer
{
    internal class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
