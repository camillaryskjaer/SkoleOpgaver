using System;
namespace Øvelser.Øvelser

{
    class Factorial
    {
        public double display(double n)
        {
            double res = 1;
            while (n > 1)
            {
                res = res * n;
                Console.WriteLine("Res {0}", res);
                --n;
                Console.WriteLine("n ={0}", n);
            }
            return res;
        }
        static void Test4(string[] args)
        {
            int num = 0;
            double ret;
            while (num == 0)
            {
                Console.WriteLine("Hvad er dit faktuelt tal?");
                string str = Console.ReadLine();
                double value = Convert.ToDouble(str);

                if (value < 26)
                {
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