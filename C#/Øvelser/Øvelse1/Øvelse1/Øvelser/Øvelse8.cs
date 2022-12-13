namespace Øvelser.Øvelser

{
    class Øvelse8
    {
        static void Test8(string[] args)
        {
            Console.WriteLine("hvilken tabel ønsker du at se?");
            string a = Console.ReadLine();
            double value = Convert.ToDouble(a);

            for (int j = 0; j <= 10; j++)
                Console.WriteLine(value * j);
        }
    }
}