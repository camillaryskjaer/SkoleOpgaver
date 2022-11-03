using System;
namespace Øvelse4

{
    class Factorial{
        public int display(int n)
        {
            int res = 1;
            while (n != 1)
            {
                res = res * n;
                n = n - 1;
            }
            return res;
        }
        static void test1(string[] args)
        {
            int num = 0;
            while (num == 0){
                Console.WriteLine("Hvad er dit faktuelt tal?");
                string str = Console.ReadLine();
                int value = Int32.Parse(str);
                if (value < 25)
                {
                    int ret;
                    Factorial fact = new Factorial();
                    ret = fact.display(value);
                    Console.WriteLine("Slut værdien er: {0}", ret);
                }
                else
                {
                    Console.WriteLine("Dit faktuelle tal må ikke være mere end 25!");
                }
            }

        }
    }
}