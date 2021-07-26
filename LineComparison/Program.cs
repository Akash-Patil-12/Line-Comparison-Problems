using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line(12, 23, 22, 30);
            double line1Length = line1.lengthOfLine();
            Line line2 = new Line(22, 23, 20, 40);
            double line2Length = line2.lengthOfLine();
            line2.CompareLine(line1Length, line2Length);
        }
    }
}
