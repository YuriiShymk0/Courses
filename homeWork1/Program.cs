using System;

namespace Courses
{
    class Program
    {
        static void Main()
        {
            /* Make the operation of dividing two numbers (double) so that the result is a number 
             * with a large number of decimal places.
             */
            Console.WriteLine("Enter first number: ");
            double.TryParse(Console.ReadLine(), out double value1);
            Console.WriteLine("Enter second number: ");
            double.TryParse(Console.ReadLine(), out double value2);
            double result = value1 / value2;
            /*
             * Display this number in a console so that only two decimal places are displayed (suggest several solutions)
             */
            Console.WriteLine("First variant of division: " + Math.Round(result, 2));
            Console.WriteLine("Second variant of division: " + string.Format("{0:0.00}", result));
            Console.WriteLine("Third variant of division: " + result.ToString("#.##"));

            //Without using a variable "result"
            Console.WriteLine("Result of division without using a third variable: " + Math.Round(value1 / value2, 2));

            /*
             * Make a variable whose value will be equal to 19876543210. 
             * Print this variable to the console in the format of the phone number: 
             * +19 (876) 543-21-10, but so that it is not hard-coded, ie option:
             * Console.WriteLine ("+19 (876) 543-21-10 ") is not suitable.
             */
            long phonenumber = 198765432110;
            Console.WriteLine("Your phone number is:" + phonenumber.ToString("+# (###) ###-##-##"));
            Console.WriteLine($"Your phone number is:{phonenumber:+## (###) ###-##-##}");
            Console.WriteLine("Your phone number is:" + string.Format("{0:+00 (000) 000-00-00}", phonenumber));
        }
    }
}


