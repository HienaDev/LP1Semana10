using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {

        private bool ascend;

        public CompareByName(bool ascend)
        {
            this.ascend = ascend;
        }

        public int Compare(Player x, Player y)
        {
            if (ascend)
            {
                return (IComparer<string>);
            }
            else if (!ascend)
            {
                int comparsion = Compare(x.Name, y.Name);

                return comparsion;
            }
        }

    }
}