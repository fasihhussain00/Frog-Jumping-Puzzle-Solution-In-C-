using JumpingFrog.Interfaces;

namespace JumpingFrog.Rules
{
    internal class GreenFrogSlideRule : IRules
    {
        int Space = 0;
        int BrownFrog = 2;
        public bool FollowThisRule(List<int> state, int turnIndex)
        {
            int Last = state.Count - 1;
            if (Last != turnIndex && state[turnIndex + 1] == Space)
                return true;

            else if (Last != turnIndex && Last - 1 != turnIndex && state[turnIndex + 2] == Space)
                return true;

            return false;
        }
    }
}
