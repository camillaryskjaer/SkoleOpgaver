using System;
namespace Øvelser.Øvelser

{
    class Øvelse6
    {
        static void Test6(string[] args)
        {
            List<int> numbers = new List<int> { 1, 4, 6, 8 };

            double average = numbers.Average();

            Console.WriteLine("The average is {0}", average);
        }
    }
}