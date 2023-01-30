public class Program
{
    static void Main(string[] args)
    {
        string morsekode = "";

        string input = Console.ReadLine();

        char[] characters = input.ToCharArray();

        foreach (char word in characters)
        {
            switch (word)
            {
                case 'a':
                    morsekode += "*- ";
                    break;
                case 'b':
                    morsekode += "-*** ";
                    break;
                case 'c':
                    morsekode += "-*-* ";
                    break;
                case 'd':
                    morsekode += "-** ";
                    break;
                case 'e':
                    morsekode += "* ";
                    break;
                case 'f':
                    morsekode += "**-* ";
                    break;
                case 'g':
                    morsekode += "--* ";
                    break;
                case 'h':
                    morsekode += "**** ";
                    break;
                case 'i':
                    morsekode += "** ";
                    break;
                case 'j':
                    morsekode += "*--- ";
                    break;
                case 'k':
                    morsekode += "-*- ";
                    break;
                case 'l':
                    morsekode += "*-** ";
                    break;
                case 'm':
                    morsekode += "-- ";
                    break;
                case 'n':
                    morsekode += "-* ";
                    break;
                case 'o':
                    morsekode += "--- ";
                    break;
                case 'p':
                    morsekode += "*--* ";
                    break;
                case 'q':
                    morsekode += "--*- ";
                    break;
                case 'r':
                    morsekode += "*-* ";
                    break;
                case 's':
                    morsekode += "*** ";
                    break;
                case 't':
                    morsekode += "- ";
                    break;
                case 'u':
                    morsekode += "**- ";
                    break;
                case 'v':
                    morsekode += "***- ";
                    break;
                case 'w':
                    morsekode += "*-- ";
                    break;
                case 'x':
                    morsekode += "-**- ";
                    break;
                case 'y':
                    morsekode += "-*-- ";
                    break;
                case 'z':
                    morsekode += "--** ";
                    break;
                case 'æ':
                    morsekode += "*-*- ";
                    break;
                case 'ø':
                    morsekode += "---* ";
                    break;
                case 'å':
                    morsekode += "*--*- ";
                    break;

                case '1':
                    morsekode += "*---- ";
                    break;
                case '2':
                    morsekode += "**--- ";
                    break;
                case '3':
                    morsekode += "***-- ";
                    break;
                case '4':
                    morsekode += "****- ";
                    break;
                case '5':
                    morsekode += "***** ";
                    break;
                case '6':
                    morsekode += "-**** ";
                    break;
                case '7':
                    morsekode += "--*** ";
                    break;
                case '8':
                    morsekode += "---** ";
                    break;
                case '9':
                    morsekode += "----* ";
                    break;
                case '0':
                    morsekode += "----- ";
                    break;

                case '.':
                    morsekode += "*-*-*- ";
                    break;
                case ',':
                    morsekode += "--**-- ";
                    break;
                case ':':
                    morsekode += "---*** ";
                    break;
                case '?':
                    morsekode += "**--** ";
                    break;
                case '\'':
                    morsekode += "*----* ";
                    break;
                case '-':
                    morsekode += "-****- ";
                    break;
                case '/':
                    morsekode += "-**-*";
                    break;
                case '(':
                    morsekode += "-*--*";
                    break;
                case ')':
                    morsekode += "-*--*-";
                    break;
                case '"':
                    morsekode += "*-**-*";
                    break;
                case '\n':
                    morsekode += "*-*-";
                    break;
                case '*':
                    morsekode += "-**-";
                    break;
                case '@':
                    morsekode += "*--*-*";
                    break;
            }
        }
        Console.WriteLine(morsekode);
    }
}