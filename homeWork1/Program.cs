using System;

namespace Courses
{
    class Program
    {
        static void Main()
        {
            //1 task
            Console.WriteLine("Enter first number: ");
            double.TryParse(Console.ReadLine(), out double value1);
            Console.WriteLine("Enter second number: ");
            double.TryParse(Console.ReadLine(), out double value2);
            double result = value1 / value2;
            //2 task
            Console.WriteLine("First variant of division: " + Math.Round(result, 2));
            Console.WriteLine("Second variant of division: " + string.Format("{0:0.00}", result));
            Console.WriteLine("Third variant of division: " + result.ToString("#.##"));

            //Without using a variable "result"
            Console.WriteLine("Result of division without using a third variable: " + Math.Round(value1 / value2, 2));
            //3 task
            long phonenumber = 198765432110;
            Console.WriteLine("Your phone number is:" + phonenumber.ToString("+# (###) ###-##-##"));
            Console.WriteLine($"Your phone number is:{phonenumber:+## (###) ###-##-##}");
            Console.WriteLine("Your phone number is:" + string.Format("{0:+00 (000) 000-00-00}", phonenumber));
        }
    }
}


