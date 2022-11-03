using System;
namespace Øvelse5

{
    class Øvelse5 {
        static void test2(string[] args)
        {
            Console.WriteLine("Hvad er tal 1?");
            int num1 = int.Parse(Console.ReadLine()); //takes the console input and converts it to and int

            Console.WriteLine("Hvad er tal 2?");
            int num2 = int.Parse(Console.ReadLine()); //takes the console input and converts it to and int

            if (num1 > num2) //Checks if num1 is bigger than num2
            {
                Console.WriteLine("Tal 1 ({0}) er størrer end tal 2 ({1})", num1, num2);
            }
            else if (num1 < num2) //Checks if num1 is lover than num2
            {
                Console.WriteLine("Tal 1 ({1}) er størrer end tal 2 ({0})", num1, num2);
            }
            else if (num1 == num2) //Checks if num1 is equal to num2
            {
                Console.WriteLine("Tal 1 ({0}) er ligmed tal 2 ({1})", num1, num2);
            }
        }
    }
}