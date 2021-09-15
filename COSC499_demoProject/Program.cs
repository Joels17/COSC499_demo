using System;

namespace COSC499_demoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a string: ");
            var input = Console.ReadLine();

            var stringMan = new StringManipulator();

            string output5 = stringMan.String5Times(input);
            Console.WriteLine($"Your input times 5: {output5}");

            var outputEs = stringMan.FindEs(input);
            Console.WriteLine($"Your input's e count: {outputEs}");
        }
    }
}
