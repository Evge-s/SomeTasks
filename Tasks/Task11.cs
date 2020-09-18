using System;
using System.Collections.Generic;
using System.Text;

namespace CertTasks.Tasks
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        protected bool Equals(Point other)
        {
            return X == other.X && Y == other.Y;
        }
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Point)obj);
        }

        public override string ToString()
        {
            return $"{ X}, { Y}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
