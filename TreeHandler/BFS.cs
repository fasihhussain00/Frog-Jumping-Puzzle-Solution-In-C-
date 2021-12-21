using JumpingFrog.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingFrog
{
    public class BFS
    {
        private List<int> _GoalState;

        public BFS(List<int> GoalState)
        {
            _GoalState = GoalState;
        }
        public List<List<int>> Traverse(TreeModel Tree)
        {
            var Nodes = new List<List<int>>();
            if (IsGoalState(Tree.State))
            {
                _GoalState =_GoalState.Select(x => 0).ToList();
                Nodes.Add(Tree.State);
                return Nodes;
            }
            else
            {
                Tree.Children.ForEach(eachChild =>
                {
                    var ChildNode = Traverse(eachChild);
                    if (ChildNode != null && ChildNode.Count > 0)
                    {
                        Nodes.Add(Tree.State);
                        Nodes.AddRange(ChildNode); 
                    }
                });
                return Nodes;
            }
        }
        private bool IsGoalState(List<int> State)
        {
            int count = 0;
            for (int i = 0; i < State.Count; i++)
                if (State[i] == _GoalState[i])
                    count++;
            return State.Count == count;
        }
    }
}


