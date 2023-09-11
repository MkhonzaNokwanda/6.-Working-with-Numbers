using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you do not need to delare variables
            Console.WriteLine(50);

            //you can also use all the normal operators straight into brackets
            Console.WriteLine(6 + 4);
            //you can write the numbers in quotes to see the console without calculation
            Console.WriteLine("6+4");
            //trying other operators
            Console.WriteLine(5 * 2);
            Console.WriteLine(5 - 2);
            //how to avoid the console giving you the integer part of the result
            Console.WriteLine(5 / 2.0);
            //modulus or the remainder
            Console.WriteLine(5 % 2);
            Console.WriteLine("5 divided by 2 is " + 5/2 + " remainder " + 5%2);

            //declaring variable and intialize 
            int num1 = 2;
            //incrementing numbers
            num1 = num1 + 1;
            num1 += 1;
            Console.WriteLine("num1 = " + num1);
            int num2 = 2;
            num2++;
            Console.WriteLine(num2);
            //absolute of a number
            Console.WriteLine(Math.Abs(-61));
            //Minimum of a number
            Console.WriteLine(Math.Min(5, 9));
            //Power of a number
            Console.WriteLine(Math.Pow(5, 2));

            //freeze the console
            Console.ReadLine();
        }
    }
}
