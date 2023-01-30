public class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        do
        {
            Random random = new Random();
            int randomNum = random.Next(1, 37);
            if (!list.Contains(randomNum))
            {
                list.Add(randomNum);
            }
        } while (list.Count < 7);

        list.Sort();
        int joker = Joker(list);

        Console.Write("Lottonummeret er: ");
        foreach (int i in list)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (i == joker)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(i);
            Console.Write(" ");
            Task.Delay(2000).Wait();
        }
    }
    static int Joker(List<int> numbers)
    {
        Random random = new Random();
        int randomNum = random.Next(0, numbers.Count());
        return numbers.ElementAt(randomNum);
    }
}