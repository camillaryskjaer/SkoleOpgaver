
int space = 7;
int antal = 1;
int linecount = 1;
int starcount = 1;


Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < 8; i++)
{

    for (int a = 0; a < space; a++)
    {
        Console.Write(" ");
    }

    for (int b = 0; b < antal; b++)
    {

        if (linecount % 2 == 0)
        {
            if (starcount % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;

        }
        Console.Write("*");
        starcount++;
    }

    linecount++;
    space--;
    antal = antal + 2;
    Console.WriteLine();
}