using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumFinder
{
    public class PathCalculator
    {
        protected const string ErrorMsgNoValidPaths = "No valid paths found";

        protected Number BaseNumber;

        public List<Path> Paths { get; protected set; }

        public PathCalculator(Number baseNumber)
        {
            BaseNumber = baseNumber;
            Paths = new List<Path>();
        }

        public Path CalculateHighestValuePath()
        {
            StartPathsSearch();

            if (!Paths.Any())
            {
                throw new Exception(ErrorMsgNoValidPaths);
            }

            Path highestValuePath = Paths.OrderByDescending(p => p.Value()).First();

            return highestValuePath;
        }

        protected void StartPathsSearch()
        {
            FindPaths(BaseNumber);
        }

        protected void FindPaths(Number number)
        {
            foreach (Number childNumber in number.Children)
            {
                bool pathValid = number.IsEven() != childNumber.IsEven();

                if (!pathValid)
                {
                    continue;
                }

                if (childNumber.AnyChildren())
                {
                    FindPaths(childNumber);
                }
                else
                {
                    CreatePath(childNumber);
                }
            }
        }

        protected void CreatePath(Number number)
        {
            var pathNumbers = new List<Number>();
            pathNumbers.Add(number);

            while (number.HasParent())
            {
                number = number.Parent;
                pathNumbers.Insert(0, number);
            }

            var path = new Path(pathNumbers);
            Paths.Add(path);
        }
    }
}
