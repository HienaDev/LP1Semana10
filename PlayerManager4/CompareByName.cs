using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {

        private bool ascend;
        private bool score = false;

        public CompareByName()
        {
            score = true;
        }

        public CompareByName(bool ascend)
        {
            this.ascend = ascend;
        }

        public int Compare(Player x, Player y)
        {
            if (score)
            {
                
            }
        }

    }
}