namespace Øvelse1

{
    class Class1{
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal antal gange:");

            String str1 = Console.ReadLine();
            int a = Int32.Parse(str1);

            Console.WriteLine("Indtast tekst:");

            String str2 = Console.ReadLine();

            int i = 0;
            do
            {
                Console.WriteLine(str2);
                i++;
            }
            while (i < a);

        }
    }
}