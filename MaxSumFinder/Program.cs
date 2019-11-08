using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Number baseNumber = NumbersTreeInitializer.InitNumbersTreeTest();
            var pathCalculator = new PathCalculator(baseNumber);
            var a = pathCalculator.CalculateHighestValuePath();

            Console.WriteLine(a.Value());
            Console.WriteLine("------------");

            foreach (var number in a.Numbers)
            {
                Console.WriteLine(number.Value);
            }
            Console.WriteLine("------------");

            foreach (Path path in pathCalculator.Paths)
            {
                Console.WriteLine("------------");
                foreach (var number in path.Numbers)
                {
                    Console.WriteLine(number.Value);
                }
            }

            Console.ReadKey();
        }
    }
}
