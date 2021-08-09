using System;

namespace Snake
{
    public class AddFoodToBoard
    {
        private readonly int x;
        private readonly int y;
        private readonly char ch;
        public CurrentPlace food { get; private set; }

        Random random = new Random();

        public AddFoodToBoard(Random rand)
        {
            random = rand;
        }
           
        public AddFoodToBoard(int x, int y, char ch)
        {
            this.x = x;
            this.y = y;
            this.ch = ch;
        }

        public void CreateFood()
        {
            food = (random.Next(2, x - 2), random.Next(2, y - 2), ch);
            food.Show();
        }
    }
}