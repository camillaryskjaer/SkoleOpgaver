Console.WriteLine("skriv højden");
double height = double.Parse(Console.ReadLine());
Console.WriteLine("skriv længden");
double lenght = double.Parse(Console.ReadLine());
Console.WriteLine("skriv breden");
double width = double.Parse(Console.ReadLine());

Console.Write("Rumfanget er: ");
Console.WriteLine(height * width * lenght); 