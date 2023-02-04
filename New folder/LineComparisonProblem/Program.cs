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
            Length length_One = new Length(9, 7, 2, 3);      //UC1
            double length1 = length_One.Calculate();

            Length length_Two = new Length(3, 5, 2, 4);      //UC2
            double length2 = length_Two.Calculate();
            //if (length1.Equals(length2))
            //    Console.WriteLine("Lines are Equal");
            //else
            //    Console.WriteLine("Lines are not Equal");

            if (length1.CompareTo(length2) == 0)            //UC3
            {
                Console.WriteLine("Lines are Equal");
            }
            else if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
            else
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            Console.ReadLine();
        }
    }
}
