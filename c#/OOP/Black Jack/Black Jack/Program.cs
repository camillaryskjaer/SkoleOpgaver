namespace Black_Jack
{
    public class Program
    {

        static void Main(string[] args)
        {
            Card[] deck = new Card[52];

            string[] suit = { "Hearts", "Dimonds", "Spades", "Clubs" };

            byte deckCounter = 0;

            //Creating deck\\

            for (int i = 0; i < suit.Length; i++)
            {
                for (byte j = 1; j <= 13; j++)
                {
                    deck[deckCounter] = new Card(suit[i], j, j);
                    deckCounter++;
                }
            }

            //Shuffle deck\\
            deck = Shuffle(deck);

            //Game values\\
            byte count = 0;

            byte playercount = 0;

            byte dealercount = 0;

            byte choise = 2;

            bool playersturn = true;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|||BLACK JACK|||\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            
            //Gives the player 2 cards
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dine kort er: " + deck[count].ToString());
                playercount += deck[count].Value; //Adds card value to playercount
                count++;
            }

            Console.WriteLine(playercount + "\n");

            Console.ForegroundColor = ConsoleColor.Blue;

            //Gives the dealer 2 cards
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealers kort er: " + deck[count].ToString());
                dealercount += deck[count].Value; //Adds card value to dealercount
                count++;
            }

            Console.WriteLine(dealercount + "\n");

            Checker(playercount, dealercount); //Check if player or computer has 21 or over

            while (playercount <21 && dealercount < 21)
            {
                if (playersturn == true) //If playersturn = true
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine("Ønsker du at trække et kort mere? 1 = YES, 2 = STAND/NO");
                    choise = Convert.ToByte(Console.ReadLine()); //Convert ReadLine to byte and set as choise

                    if (choise == 1) //If the player wants to get 1 more card
                    {
                        Console.WriteLine("\nDit nye kort er: " + deck[count].ToString());
                        playercount += deck[count].Value; //Adds card value to playercount
                        count++;
                        Console.WriteLine(playercount);

                        Checker(playercount, dealercount); //Check if player or computer has 21 or over
                    }
                    else //Else set playersturn to false
                    {
                        playersturn = false;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nDealers kort er: " + deck[count].ToString());
                    dealercount += deck[count].Value; //Adds card value to dealercount
                    count++;
                    Console.WriteLine(dealercount);

                    Checker(playercount, dealercount); //Check if player or computer has 21 or over
                    playersturn = true; //Set playersturn to true
                }
            }
        }

        //Check if player or computer has 21 or over\\
        static void Checker(byte playercount, byte dealercount)
        {
            if (playercount >= 21)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDu har tabt");
            }
            else if (dealercount >= 21)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("\nDu har vundet!");
            }
        }

        //Shuffle cards\\
        public static Card[] Shuffle(Card[] sorted)
        {
            Random rand = new Random();

            for (int i = 0;i < 200;i++)
            {
                int index1 = rand.Next(0, sorted.Length);
                int index2 = rand.Next(0, sorted.Length);

                Card placeholder = sorted[index1];

                sorted[index1] = sorted[index2];

                sorted[index2] = placeholder;
            }
            return sorted;
        }
    }
}