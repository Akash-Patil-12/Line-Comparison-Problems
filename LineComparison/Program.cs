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
            Console.WriteLine("First Line Length :" + line1Length + " Second Line Length : " + line2Length);
            if (line1Length == line2Length)
            {
                Console.WriteLine("Length of two Lines are equals");
            }
            else
            {
                Console.WriteLine("Length of two lines are not equals");
            }
        }
    }
}
