using System;

namespace Courses
{
    class Program
    {
        static void Main()
        {
            //1 task
            Console.WriteLine("Task 1:");
            double value1 = getDoubleFromConsole();
            double value2 = getDoubleFromConsole(true);
            double result = value1 / value2;

            //2 task
            Console.WriteLine("\nTask 2:");
            Console.WriteLine("First variant of division: " + Math.Round(result, 2));
            Console.WriteLine("Second variant of division: " + string.Format("{0:0.00}", result));
            Console.WriteLine("Third variant of division: " + result.ToString("#.##"));

            //Without using a variable "result"
            Console.WriteLine("Result of division without using a third variable: " + Math.Round(value1 / value2, 2));

            //3 task
            Console.WriteLine("\nTask 3:");
            long phonenumber = 198765432110;
            showPhoneNumber(phonenumber.ToString("+# (###) ###-##-##"));
            Console.WriteLine(string.Format("Your phone number is: {0:+## (###) ###-##-##}", phonenumber));
            Console.WriteLine(string.Format("Your phone number is: {0:+00 (000) 000-00-00}", phonenumber));
        }

        private static double getDoubleFromConsole(bool nullCheck = false)
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

        private static void showPhoneNumber(string phoneNumber)
        {
            Console.WriteLine(string.Format("Your phone number is: {0:+## (###) ###-##-##}", phoneNumber));
        }
    }
}
