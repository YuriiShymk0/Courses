using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Snake
    {
        private List<CurrentPlace> snake;
        private Way direction;
        private readonly int step = 1;
        private CurrentPlace tail;
        private CurrentPlace head;
        bool rotation = true;

        public Snake(int x, int y, int length)
        {
            direction = Way.RIGHT;
            snake = new List<CurrentPlace>();
            for (int i = x - length; i < x; i++)
            {
                CurrentPlace p = (i, y, '$');
                snake.Add(p);
                p.Show();
            }
        }

        public CurrentPlace GetHead() => snake.Last();

        public void Move()
        {
            head = GetNextPoint();
            snake.Add(head);
            tail = snake.First();
            snake.Remove(tail);
            tail.Clear();
            head.Show();
            rotation = true;
        }

        public bool Eat(CurrentPlace currentpl)
        {
            head = GetNextPoint();
            if (head == currentpl)
            {
                snake.Add(head);
                head.Show();
                return true;
            }
            return false;
        }

        public CurrentPlace GetNextPoint()
        {
            CurrentPlace p = GetHead();

            switch (direction)
            {
                case Way.LEFT:
                    p.x -= step;
                    break;
                case Way.RIGHT:
                    p.x += step;
                    break;
                case Way.UP:
                    p.y -= step;
                    break;
                case Way.DOWN:
                    p.y += step;
                    break;
            }
            return p;
        }

        public void Rotation(ConsoleKey key)
        {
            if (rotation)
            {
                switch (direction)
                {
                    case Way.LEFT:
                    case Way.RIGHT:
                        if (key == ConsoleKey.DownArrow)
                            direction = Way.DOWN;
                        else if (key == ConsoleKey.UpArrow)
                            direction = Way.UP;
                        break;
                    case Way.UP:
                    case Way.DOWN:
                        if (key == ConsoleKey.LeftArrow)
                            direction = Way.LEFT;
                        else if (key == ConsoleKey.RightArrow)
                            direction = Way.RIGHT;
                        break;
                }
                rotation = false;
            }

        }

        public bool IsHit(CurrentPlace place)
        {
            for (int i = snake.Count - 2; i > 0; i--)
            {
                if (snake[i] == place)
                {
                    return true;
                }
            }
            return false;
        }
    }
}