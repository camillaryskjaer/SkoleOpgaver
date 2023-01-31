
public class Program
{
    class Stats
    {
        public static byte Matches;
    }
    static void Main(string[] args)
    {
        Stats.Matches = 7;

        do
        {
            byte input = Amount();
            if (input > Stats.Matches)
            {
                Console.WriteLine("Der er kun " + Stats.Matches + " tændstikker i alt!");
            }
            else if (input <= Stats.Matches)
            {
                if (input > 3)
                {
                    Console.WriteLine("Du må kun trække 1, 2 eller 3 af gangen!");
                }

                else if (input <= 3)
                {
                    if ((Stats.Matches - input) == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Du vandt!");
                        return;
                    }
                    Stats.Matches = (byte)(Stats.Matches - input);
                    byte computerNum = MakeComputerTake();
                    ProcessComputerTake(computerNum);

                }
            }
        } while (Stats.Matches > 1);
        Console.WriteLine("Spillet er slut");

    }

    static byte Amount()
    {
        byte input;
        while (true)
        {
            Console.WriteLine("Der er " + Stats.Matches + " tændstikker i alt.");
            Console.WriteLine("Hvor mange tændstikker vil du trække 1, 2 eller 3?");
            Console.WriteLine();
            try
            {
                input = byte.Parse(Console.ReadLine());
                return input;
            }
            catch (Exception e)
            {
                Console.WriteLine("Det skal være et nummer");
            }
        }
    }

    static void ProcessComputerTake(byte number)
    {
        Stats.Matches = (byte)(Stats.Matches - number);

        Console.WriteLine();
        Console.WriteLine("Jeg trækker " + number);
        if (Stats.Matches == 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Du tabte!");
        }
    }

    static byte MakeComputerTake()
    {
        while (true)
        {
            Random random = new Random();
            int take = random.Next(1, 4);
            if (take <= Stats.Matches - 1)
            {
                return (byte)take;
            }
        }
    }
}