using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumFinder
{
    public class Number
    {
        public Number()
        {
            Children = new List<Number>();
        }

        public int Value { get; set; }

        public Number Parent { get; set; }

        public List<Number> Children { get; protected set; }

        public bool IsEven()
        {
            return Value % 2 == 0;
        }

        public bool HasParent()
        {
            return Parent != null;
        }

        public bool AnyChildren()
        {
            return Children.Any();
        }

        public void AddChild(Number number)
        {
            Children.Add(number);
            number.Parent = this;
        }
    }
}
