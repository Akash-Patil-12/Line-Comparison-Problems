using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class Line
    {
        int pointX1, pointX2, pointY1, pointY2;
        public Line(int pointX1, int pointX2, int pointY1, int pointY2)
        {
            this.pointX1 = pointX1;
            this.pointX2 = pointX2;
            this.pointY1 = pointY1;
            this.pointY2 = pointY2;
        }
        /// <summary>
        /// Return length of line
        /// </summary>
        public double lengthOfLine()
        {
            double length = Math.Sqrt((pointX2 - pointX1) ^ 2 + (pointY2 - pointY1) ^ 2);
            return length;
        }
        public void CompareLine(double line1,double line2)
        {
            Console.WriteLine("Line One value :" + line1 + " Line Second value :" + line2);
            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("Both lines are equals");
            }
            if (line1.CompareTo(line2) > 0)
            {
                Console.WriteLine("Line One is gratter than Second");
            }
            else
                Console.WriteLine("Line One is less than Second");
        }
    }
}