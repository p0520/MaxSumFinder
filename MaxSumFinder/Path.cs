using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumFinder
{
    public class Path
    {
        public List<Number> Numbers { get; protected set; }

        public Path(List<Number> numbers)
        {
            Numbers = numbers;
        }

        public int Value()
        {
            int value = Numbers.Sum(n => n.Value);

            return value;
        }

        public override string ToString()
        {
            var numbersAsString = string.Join(", ", Numbers.Select(n => n.Value.ToString()));
            var pathAsString = $"Path numbers: {numbersAsString}";

            return pathAsString;
        }
    }
}
