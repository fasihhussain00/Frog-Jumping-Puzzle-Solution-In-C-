using JumpingFrog.Interfaces;
using JumpingFrog.Model;
using JumpingFrog.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingFrog
{
    public class MakeATreeOfStates
    {
        List<List<int>> states;
        const int GreenFrog = 1;
        const int BrownFrog = 2;
        const int Space = 0;
        public int TotalNoOfStates = 0;

        int[] GoalState = { BrownFrog, BrownFrog, BrownFrog, Space, GreenFrog, GreenFrog, GreenFrog };
        public MakeATreeOfStates()
        {
            states = new List<List<int>>();
        }
        public void CreateANode(ref TreeModel CurrentNode, List<int> CurrentState)
        {
            states.Add(CurrentState);
            CurrentNode.addState(CurrentState);
            int count = 0;
            TotalNoOfStates++;
            var isGoalState = isThisCurrentStateGoalState(CurrentState, ref count);
            if (!isGoalState)
            for (int i = 0; i < CurrentState.Count; i++)
            {
                var rules = CurrentState[i] == GreenFrog ? RuleFactory.GetRules(FrogType.GreenFrog) : RuleFactory.GetRules(FrogType.BrownFrog);
                var isSwapValid = rules.FollowThisRule(CurrentState, i);
                if (isSwapValid)
                {
                    var childNode = new TreeModel(CurrentNode);
                    var NewState = SwapFrogWithSpace(CurrentState, i);
                    childNode.addState(NewState);
                    var currentChild = CurrentNode.AddChild(childNode);
                    CreateANode(ref currentChild, NewState);
                }
            }

        }

        private bool isThisCurrentStateGoalState(List<int> CurrentState, ref int count)
        {
            for (int i = 0; i < CurrentState.Count; i++)
                if (CurrentState[i] == GoalState[i])
                    count++;

            return CurrentState.Count == count;
        }

        private List<int> SwapFrogWithSpace(List<int> state, int swappingIndex)
        {
            var SwappedList = new List<int>();
            state.ForEach(x => SwappedList.Add(x));

            var space = SwappedList.IndexOf(Space);
            var swappingFrog = SwappedList[swappingIndex];
            SwappedList[swappingIndex] = Space;
            SwappedList[space] = swappingFrog;
            
            return SwappedList;
        }
    }
}
