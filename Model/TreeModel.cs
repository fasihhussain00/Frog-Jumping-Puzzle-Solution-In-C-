using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingFrog.Model
{
    public class TreeModel
    {
        public List<int> State { get; set; }
        public List<TreeModel> Children { get; set; }
        public TreeModel(TreeModel? parent)
        {
            State = new List<int>();
            Children = new List<TreeModel>();
        }
        public TreeModel addState(List<int> state)
        {
            State = state;
            return this;
        }
        public List<int> GetState()
        {
            return this.State;
        }
        public TreeModel AddChild(TreeModel child) {
            Children.Add(child);
            return Children[Children.Count - 1];
        }

        public List<TreeModel>? GetAllChild()
        {
            return this.Children;
        }
    }
}

