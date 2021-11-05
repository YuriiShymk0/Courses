using System;
using System.Text;

namespace homeWork4
{
    class Program
    {
        static void Main()
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Options:");
            sb.AppendLine("1. Sum");
            sb.AppendLine("2. Subtraction");
            sb.AppendLine("3. Division");
            sb.AppendLine("4. Multiplication");
            sb.AppendLine("5. Factorial");
            sb.AppendLine("6. Sum and subtraction of numbers");
            sb.AppendLine("0. Exit");
            Console.WriteLine(sb.ToString());
            int chossenMode = GetIntFromConsole("Chose option: ");
            string result;
            switch (chossenMode)
            {
                case 1:
                    result = Sum(GetDoubleFromConsole(), GetDoubleFromConsole()).ToString();
                    break;
                case 2:
                    result = Subtraction(GetDoubleFromConsole(), GetDoubleFromConsole()).ToString();
                    break;
                case 3:
                    result = Division(GetDoubleFromConsole(), GetDoubleFromConsole()).ToString();
                    break;
                case 4:
                    result = Multiplication(GetDoubleFromConsole(), GetDoubleFromConsole()).ToString();
                    break;
                case 5:
                    result = Factorial(GetIntFromConsole()).ToString();
                    break;
                case 6:
                    ForOutMethod(GetIntFromConsole(), GetIntFromConsole(), out int sumOfNumbers, out int subtractionOfNumbers);
                    result = string.Format("\nSum of numbers: {0}\nSubtraction of numbers: {1}", sumOfNumbers, subtractionOfNumbers);
                    break;
                case 0:
                    PressEnterToContinue("Press Enter to exit from program");
                    return;
                default:
                    Console.WriteLine("Error: invalid option. Try again");
                    PressEnterToContinue();
                    MainMenu();
                    return;
            }
            Console.WriteLine(string.Format("Result of your operation {0}", result));
            PressEnterToContinue();
            MainMenu();
        }

        private static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        private static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }

        private static double Division(double number1, double number2)
        {
            while (number2 == 0)
            {
                Console.WriteLine("Error: Сan't be divided by zero");
                number2 = GetDoubleFromConsole("Enter not 0 number: ");
            }
            return number1 / number2;
        }

        private static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        private static double GetDoubleFromConsole(string enterNumber = "Please enter number: ")
        {
            while (true)
            {
                Console.WriteLine(enterNumber);
                bool isConverted = double.TryParse(Console.ReadLine(), out double number);
                if (isConverted)
                {
                    return number;
                }
                Console.WriteLine("Error: Not correct value. Example: 1,2");
                PressEnterToContinue();
            }
        }

        private static int GetIntFromConsole(string enterNumber = "Please enter number: ")
        {
            while (true)
            {
                Console.WriteLine(enterNumber);
                bool isConverted = int.TryParse(Console.ReadLine(), out int number);
                if (isConverted)
                {
                    return number;
                }
                Console.WriteLine("Error: Not correct value. Example: 1");
                PressEnterToContinue();
            }
        }

        private static void PressEnterToContinue(string message = "Press Enter to continue! ")
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }

        private static int Factorial(int number)
        {
            while (number < 0)
            {
                Console.WriteLine("number must be > 0");
                number = GetIntFromConsole();
            }
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            return 1;
        }

        private static void ForOutMethod(int number1, int number2, out int sumOfNumbers, out int subtractionOfNumbers)
        {
            sumOfNumbers = number1 + number2;
            subtractionOfNumbers = number1 - number2;
        }
    }
}
