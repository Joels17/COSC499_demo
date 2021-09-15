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
            Console.WriteLine(input);
        }
    }
}
