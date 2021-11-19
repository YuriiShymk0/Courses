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
            Console.WriteLine("Task 1:");
            double value1 = GetDoubleFromConsole();
            double value2 = GetDoubleFromConsole(true);
            double result = value1 / value2;

            /*
            * Display this number in a console so that only two decimal places are displayed (suggest several solutions)
            */
            Console.WriteLine("\nTask 2:");
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
            Console.WriteLine("\nTask 3:");
            long phonenumber = 198765432110;
            ShowPhoneNumber(phonenumber.ToString("+# (###) ###-##-##"));
            Console.WriteLine(string.Format("Your phone number is: {0:+## (###) ###-##-##}", phonenumber));
            Console.WriteLine(string.Format("Your phone number is: {0:+00 (000) 000-00-00}", phonenumber));
        }

        private static double GetDoubleFromConsole(bool nullCheck = false)
        {
            while (true)
            {
                Console.WriteLine("Enter number: ");
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    if (nullCheck)
                    {
                        if (result != 0)
                        {
                            return result;
                        }
                    }
                    else
                    {
                        return result;
                    }
                }
                Console.WriteLine("Invalid value. Press Enter and try again");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void ShowPhoneNumber(string phoneNumber)
        {
            Console.WriteLine(string.Format("Your phone number is: {0:+## (###) ###-##-##}", phoneNumber));
        }
    }
}
