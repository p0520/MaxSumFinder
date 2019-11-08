using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumFinder
{
    public class NumbersTreeInitializer
    {
        public static Number InitNumbersTreeTest()
        {
            var number1 = new Number()
            {
                Value = 1
            };

            var number2 = new Number()
            {
                Value = 8
            };

            var number3 = new Number()
            {
                Value = 9
            };

            number1.AddChild(number2);
            number1.AddChild(number3);

            var number4 = new Number()
            {
                Value = 1
            };

            var number5 = new Number()
            {
                Value = 5
            };

            number2.AddChild(number4);
            number2.AddChild(number5);

            var number6 = new Number()
            {
                Value = 5
            };

            var number7 = new Number()
            {
                Value = 9
            };

            number3.AddChild(number6);
            number3.AddChild(number7);

            var number8 = new Number()
            {
                Value = 4
            };

            var number9 = new Number()
            {
                Value = 5
            };

            number4.AddChild(number8);
            number4.AddChild(number9);

            var number10 = new Number()
            {
                Value = 5
            };

            var number11 = new Number()
            {
                Value = 2
            };

            number5.AddChild(number10);
            number5.AddChild(number11);

            var number12 = new Number()
            {
                Value = 2
            };

            var number13 = new Number()
            {
                Value = 3
            };

            number7.AddChild(number12);
            number7.AddChild(number13);

            return number1;
        }
    }
}
