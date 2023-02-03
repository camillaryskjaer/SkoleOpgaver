Random random = new Random();
int dice = random.Next(1, 7);

if (dice == 1)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Du slog en etter");
}

else if (dice == 2)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Du slog en to'er");
}

else if (dice == 3)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Du slog en tre'er");
}

else if (dice == 4)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Du slog en fire'er");
}

else if (dice == 5)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Du slog en fem'er");
}

else if (dice == 6)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Du slog en seks'er");
}

else if (dice == 7)
{ 
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("Du slog en syv'er");
}