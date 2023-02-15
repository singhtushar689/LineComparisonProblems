using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Length
    {
        int lengthX, _lengthY, lenGthsX, lengthsY;
        public Length(int lengthX, int lengthY, int lengthsX, int lengthsY)
        {
            this.lengthX = lengthX;               //These are different types to declare constructor
            _lengthY = lengthY;
            lenGthsX = lengthsX;
            this.lengthsY = lengthsY;
        }
        public double Calculate()
        {
            double length = Math.Sqrt(Math.Pow((lenGthsX - lengthX), 2) + (Math.Pow((lengthsY - _lengthY), 2)));
            Console.WriteLine(length);
            return length;
        }
    }
}
