using System;

namespace homeWork3
{
    class Program
    {
        static void Main()
        {
            bool continueGame = true;
            int currentHp = 100;
            while (continueGame)
            {
                Console.Clear();
                Console.WriteLine(string.Format("Your current hp: {0}", currentHp));
                Console.Write("Enter number or write \"EXIT\" to end game: ");
                string choosen = Console.ReadLine();
                Console.WriteLine();
                if (!int.TryParse(choosen, out int choosenNumber))
                {
                    if (choosen.ToUpper() == "EXIT")
                    {
                        Console.WriteLine("Exit from game...");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        continue;
                    }
                }
                if (choosenNumber == 0)
                {
                    Console.WriteLine("Choose not 0! Choose any another number");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    continue;
                }

                int rnd = new Random().Next(0, 5);
                switch (rnd % choosenNumber)
                {
                    case 0:
                        Console.WriteLine("You win");
                        continueGame = false;
                        break;
                    case 1:
                        Console.WriteLine("-10hp");
                        currentHp -= 10;
                        break;
                    case 2:
                        Console.WriteLine("+10hp");
                        currentHp += 10;
                        break;
                    case 3:
                        Console.WriteLine("-5hp");
                        currentHp -= 5;
                        break;
                    case 4:
                        Console.WriteLine("+5hp");
                        currentHp += 5;
                        break;
                    default:
                        Console.WriteLine("Incorrect number");
                        break;
                }
                if (currentHp > 0)
                {
                    Console.WriteLine(string.Format("Your current hp: {0}", currentHp));
                }
                else
                {
                    Console.WriteLine("Game over");
                    continueGame = false;
                }
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
        }
    }
}
