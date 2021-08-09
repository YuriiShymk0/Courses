using System;

namespace Snake
{
    public struct CurrentPlace
    {
        public int x { get; set; }
        public int y { get; set; }
        public char ElementForWall { get; set; }

        public static implicit operator CurrentPlace((int, int, char) value)
        {
            return new CurrentPlace { x = value.Item1, y = value.Item2, ElementForWall = value.Item3 };
        }

        public static bool operator ==(CurrentPlace a, CurrentPlace b)
        {
            if (a.x == b.x && a.y == b.y)
            {
                return true;
            }
            else return false;
        }

        public static bool operator !=(CurrentPlace a, CurrentPlace b)
        {
            if (a.x != b.x || a.y != b.y)
            {
                return true;
            }
            else return false;
        }

        public void Show() => ShowCurrentThePlace(ElementForWall);
        public void Clear() => ShowCurrentThePlace(' ');

        private void ShowCurrentThePlace(char Char)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Char);
        }
    }
}