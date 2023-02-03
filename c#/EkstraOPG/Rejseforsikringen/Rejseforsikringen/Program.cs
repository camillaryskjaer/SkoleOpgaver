public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Angiv dit CPR nummer");
            int[] CPR = Convert.ToInt32(Console.ReadLine());


            if (CPR.Length < 10)
            {
                Console.WriteLine("Fejl!");
            }
            else if (CPR.Length > 10)
            {
                Console.WriteLine("Fejl!");
            }
            else
            {
                int CPR1 = (CPR[0] * 4);
                int CPR2 = (CPR[1] * 3);
                int CPR3 = (CPR[2] * 2);
                int CPR4 = (CPR[3] * 7);
                int CPR5 = (CPR[4] * 6);
                int CPR6 = (CPR[5] * 5);
                int CPR7 = (CPR[6] * 4);
                int CPR8 = (CPR[7] * 3);
                int CPR9 = (CPR[8] * 2);
                int CPR10 = (CPR[9] * 1);

                int Sum = CPR1 + CPR2 + CPR3 + CPR4 + CPR5 + CPR6 + CPR7 + CPR8 + CPR9 + CPR10;

                Console.WriteLine(Sum);
                
                int check = Sum % 11;

                if (check == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CPR-nummer gyldigt!");
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("CPR-nummer ugyldigt!");
                }

            }

        }
    }
}