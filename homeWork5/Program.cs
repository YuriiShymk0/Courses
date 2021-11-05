using System;
using System.Collections.Generic;
using System.Linq;

namespace homeWork5
{
    class Program
    {
        internal static void Main(string[] arrayForSort)
        {
            arrayForSort = GetParamsFromArguments(arrayForSort, out char cshoosenLetter);
            string[] sortedArrayByDesc = DescSortArray(arrayForSort).ToArray();
            string[] sortedArrayByLetter = SortByLetter(sortedArrayByDesc, cshoosenLetter).ToArray();

            Delimitation();
            ShowCollection(sortedArrayByDesc, "Sorted array by desc:");
            Delimitation();
            ShowCollection(sortedArrayByLetter, "Sorted array by letter:");
            Delimitation();
        }

        private static string[] GetParamsFromArguments(string[] arrayForSort, out char cshoosenLetter)
        {
            if (arrayForSort == null || arrayForSort.Length < 2)
            {
                arrayForSort = EnterArrayFromConsole();
                cshoosenLetter = GetCharFromConsole("Enter letter for sort: ");
                return arrayForSort;
            }
            cshoosenLetter = arrayForSort[^1][0];
            return arrayForSort.Take(arrayForSort.Length - 1).ToArray();
        }

        private static IEnumerable<string> DescSortArray(IEnumerable<string> arrayToSort)
        {
            return arrayToSort.OrderByDescending(word => word);
        }

        private static List<string> SortByLetter(string[] arrayToSort, char cshoosenLetter)
        {
            List<string> sortedByLetterList = new List<string>();
            foreach (var name in arrayToSort)
            {
                if (Char.ToUpper(name[0]) == Char.ToUpper(cshoosenLetter))
                {
                    sortedByLetterList.Add(name);
                }
            }
            return sortedByLetterList;
        }

        private static void Delimitation()
        {
            Console.WriteLine("----------------------------------------------------");
        }

        private static void ShowCollection(string[] array, string message = "")
        {
            Console.WriteLine(message);
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void PressEnterToContinue(string message = "Press Enter to continue! ")
        {
            Console.WriteLine(message);
            Console.ReadLine();
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
                Console.WriteLine("Error: Not correct value. ");
                PressEnterToContinue();
            }
        }

        private static char GetCharFromConsole(string enterChar = "Please enter char: ")
        {
            {
                while (true)
                {
                    Console.WriteLine(enterChar);
                    bool isConverted = char.TryParse(Console.ReadLine(), out char number);
                    if (isConverted && number.ToString().Length == 1)
                    {
                        return number;
                    }
                    Console.WriteLine("Error: Not correct value. ");
                    PressEnterToContinue();
                }
            }
        }

        private static int GetLengthFromConsole()
        {
            while (true)
            {
                int lengthOfArray = GetIntFromConsole("Enter count of game that you would to enter ");
                if (lengthOfArray > 0)
                {
                    return lengthOfArray;
                }
                Console.WriteLine("Error: Not correct value. ");
                PressEnterToContinue();
            }
        }

        private static string[] EnterArrayFromConsole()
        {
            string[] array = new string[GetLengthFromConsole()];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter name of {i + 1} game :\t");
                if ((array[i] = Console.ReadLine()) == "")
                {
                    Console.WriteLine("Error: Empty value.");
                    PressEnterToContinue();
                    i--;
                }
            }
            return array;
        }
    }
}