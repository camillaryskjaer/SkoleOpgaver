namespace Øvelser.Øvelser

{
    class Øvelse9
    {
        static void Test9(string[] args)
        {
            Console.WriteLine("Tal1");
            double val1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("operator");
            string op = Console.ReadLine();
            Console.WriteLine("Tal2");
            double val2 = Convert.ToDouble(Console.ReadLine());


            if (op == "+")
                Console.WriteLine(val1 + val2);
            else if (op == "-")
                Console.WriteLine(val1 - val2);
            else if (op == "*")
                Console.WriteLine(val1 * val2);
            else if (op == "/")
                Console.WriteLine(val1 / val2);
            else
                Console.WriteLine("Operator invalid!");
        }
    }
}