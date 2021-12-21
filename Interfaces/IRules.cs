using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingFrog.Interfaces
{
    public interface IRules
    {
        public bool FollowThisRule(List<int> state, int turnIndex);
    }
}
