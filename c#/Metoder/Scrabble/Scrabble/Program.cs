public class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Write your word:");
        string input = Console.ReadLine();

        char[] characters = input.ToCharArray();

        int point = 0;

        for (int i = 0; i < characters.Length; i++) //Kører en for, for så mange karaktere der er i mit array
        {
            point = point + Program.Points(characters[i]); //Liger karakterenes points oveni "point" variablen
        }

        Console.WriteLine("You got: " + point + " points!");
    }


    static int Points(char character) //Metode der laver hver karakter om til de point det svare til
    {
        switch (Char.ToUpper(character)) //Laver hver karakter til stort karakter (så man både kan skrive ord med lille og stort. Checker hver karakter hvilket point det svare til.
        {
            case 'E':
            case 'A' :
            case 'N':
            case 'R':
                return 1;
            case 'D':
            case 'L':
            case 'O':
            case 'S':
            case 'T':
                return 2;
            case 'B':
            case 'I':
            case 'K':
            case 'F':
            case 'G':
            case 'M':
            case 'U':
            case 'V':
                return 3;
            case 'H':
            case 'J':
            case 'P':
            case 'Y':
            case 'Æ':
            case 'Ø':
            case 'Å':
                return 4;
            case 'C':
            case 'X':
            case 'Z':
            case 'W':
            case 'Q':
                return 8;
        }
        return 0; //Hvis det den checker ikke svarer til noget (Fx. et tal (1)) retunere den 0.
    }
}