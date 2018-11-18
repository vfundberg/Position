using System;
namespace Labb2
{
    public class Position
    {
        private int x;
        private int y;

        public int X
        {
            get => x;
            set
            {
                if (value > 0)
                    x = value;
            }
        }

        public int Y 
        {
            get => y;
            set 
            {
                if (value > 0)
                    y = value;
            }
        }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + x + "," + y + ")"; 
        }
        public double Length() 
        {
            return Math.Sqrt(x * x + y * y);
        }
        public bool Equals(Position p)
        {
            if (p.X == x && p.Y == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Position Clone()
        {
            return new Position(x, y);
        }

        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.x + p2.x, p1.y + p2.y);
        }

        public static Position operator -(Position p1, Position p2)
        {
            return new Position(p1.x - p2.x, p1.y - p2.y);
        }

        public static double operator %(Position p1, Position p2)
        {
            return Math.Sqrt(p1.x * p1.x - p2.x * p2.x + p1.y * p1.y - p2.y * p2.y); 

        }

        public static bool operator >(Position p1, Position p2)
        {
            if (p1.Length() > p2.Length()) 
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        public static bool operator <(Position p1, Position p2)
        {
            if (p1.Length() > p2.Length())
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

    }
}
