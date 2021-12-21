using JumpingFrog.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingFrog.Rules
{
    public class BrownFrogSlideRule : IRules
    {
        int Space = 0;
        int GreenFrog = 1;
        public bool FollowThisRule(List<int> state, int turnIndex)
        {
            int First = 0;
            if (turnIndex != First && state[turnIndex - 1] == Space)
                return true;

            else if (turnIndex != First && turnIndex != First + 1 && state[turnIndex - 2] == Space)
                return true;

            return false;
        }
    }
}
