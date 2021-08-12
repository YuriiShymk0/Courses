using System.Collections.Generic;

namespace Snake
{
    public class Walls
    {
        private readonly char CharSymbol;

        public Walls(int x, int y, char symbolFromKeyBoard)
        {
            CharSymbol = symbolFromKeyBoard;
            HorizontalWalls(x, 0);
            HorizontalWalls(x, y);
            VerticalWalls(0, y);
            VerticalWalls(x, y);
        }

        private List<CurrentPlace> wall = new List<CurrentPlace>();
        private void VerticalWalls(int x, int y)
        {
            for (int i = 1; i < y; i++)
            {
                CurrentPlace currentPlace = (x, i, '│');
                currentPlace.Show();
                wall.Add(currentPlace);
            }
        }
        private void HorizontalWalls(int x, int y)
        {
            for (int i = 1; i < x; i++)
            {
                CurrentPlace currentPlace = (i, y, '—');
                currentPlace.Show();
                wall.Add(currentPlace);
            }
        }

        public bool Сollision(CurrentPlace currentplace)   
        {
            foreach (var elementOfWall in wall)
            {
                if (currentplace == elementOfWall)
                {
                    return true;
                }
            }
            return false;
        }
    }
}