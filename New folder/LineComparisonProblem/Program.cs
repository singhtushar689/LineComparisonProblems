using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Length length_One = new Length(9,7,2,3);      //UC1
            double length1 = length_One.Calculate();
            Console.ReadLine();
        }
    }
}
