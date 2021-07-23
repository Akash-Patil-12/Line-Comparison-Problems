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
        /// Calculate length of line
        /// </summary>
        public void lengthOfLine()
        {
            double length = Math.Sqrt((pointX2 - pointX1) ^ 2 + (pointY2 - pointY1) ^ 2);
            Console.WriteLine("Length of Line is : " + length);
        }
    }
}