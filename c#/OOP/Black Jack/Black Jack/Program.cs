namespace Black_Jack
{
    public class Program
    {

        static void Main(string[] args)
        {
            Card[] deck = new Card[52];

            string[] suit = { "Hearts", "Dimonds", "Spades", "Clubs" };

            byte deckCounter = 0;

            //Creating deck

            for (int i = 0; i < suit.Length; i++)
            {
                for (byte j = 1; j <= 13; j++)
                {
                    deck[deckCounter] = new Card(suit[i], j, j);
                    deckCounter++;
                }
            }

            //Shuffle
            deck = Shuffle(deck);

            //Write deck shuffled
            //foreach (Card item in deck)
            //{
            //    Console.WriteLine(item.Suit + ":" + item.Value);
            //}
            //Console.ReadKey();

            while (true)
            {
                byte count = 0;

                byte playercount = 0;

                byte computercount = 0;

                byte choise = 2;

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Dine kort er: " + deck[count].ToString());
                    playercount += deck[count].Value;
                    count++;
                }

                Console.WriteLine(playercount);

                Console.WriteLine(" -----");

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Computerens kort er: " + deck[count].ToString());
                    computercount += deck[count].Value;
                    count++;
                }

                Console.WriteLine(computercount);

                if (playercount <= 21 || computercount <= 21)
                {

                    Console.WriteLine("Ønsker du at trække et kort mere? 1 = YES - 2 = STAND");
                    choise = Convert.ToByte(Console.ReadLine());

                    if (choise == 1)
                    {
                        Console.WriteLine("Dit kort er: " + deck[count].ToString());
                        playercount += deck[count].Value;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Computerens kort er: " + deck[count].ToString());
                        computercount += deck[count].Value;
                        count++;
                    }

                }
                else if (playercount >= 21)
                {
                    Console.WriteLine("Du har tabt");
                    Console.WriteLine("Din count: " + playercount);
                    Console.WriteLine("Computer count: " + computercount);
                }
                else
                {
                    Console.WriteLine("Du har vunder over computeren");
                    Console.WriteLine("Din count: " + playercount);
                    Console.WriteLine("Computer count: " + computercount);
                }
            }
        }

        //Shuffle cards
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