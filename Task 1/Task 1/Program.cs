using System;

class Program
{
    static void Main()
    {
        //variables
        double a = 1;
        double b = 2;
        double c = 3;
        double x = 0.5;


        //formuls
        double part1 = (7.0 / 4.0) * a * Math.Tan(x);

        double absX3 = Math.Abs(x * x * x);
        double cubeRoot = Math.Pow(absX3, 1.0 / 3.0);
        double part2 = b * cubeRoot;

        double sinX = Math.Sin(x);
        double part3 = c * sinX * sinX;

        //final decision
        double y = part1 + part2 + part3;
        Console.WriteLine("y = " + y);
        Console.ReadKey();
    }
}