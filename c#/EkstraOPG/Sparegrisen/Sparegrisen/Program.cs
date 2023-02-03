public class Program
{
    static void Main(string[] args)
    {

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nAngiv dit beløb!");
        double amount = int.Parse(Console.ReadLine());

        Console.WriteLine("\nAngiv din rente! (x,y)");
        double percent = double.Parse(Console.ReadLine());

        Console.WriteLine("\nAngiv antal år!");
        byte years = byte.Parse(Console.ReadLine());

        percent = percent / 100;

        Console.ForegroundColor = ConsoleColor.Blue;
        for (int i = 1; i < years +1; i++)
        {
            amount = (amount * (1 + percent));

            Console.WriteLine(i + " År = beløb: " + amount);
        }
    }
}