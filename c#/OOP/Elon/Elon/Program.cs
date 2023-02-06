public class Program
{
    public class Car //Defines my class "Car"
    {
        private int _battery = 100;
        private int _meter = 0;
        private string _color = "red";

        public void Drive() //Drive method
        {
            _battery -= 1;
            _meter += 20;
        }

        public void Charge() //Chage method
        {
            _battery = 100;
            _meter = 0;
        }

        public int Battery //Makes battery a public int
        {
            get { return _battery; }
            set { _battery = value; }
        }

        public int Meter //Makes Meter a public int
        {
            get { return _meter; }
            set { _meter = value; }
        }

        public string Color //Makes color a public int
        {
            get { return _color; }
            set { _color = value; }
        }
    }

    static void Main(string[] args) //Main program
    {
        Car car1 = new Car();
        Car car2 = new Car();

        int choise = 2; //Default choise is 2 = charge car

        while (true)
        {
            if (car1.Battery <= 0) //If cars battery is 0 or less
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Der er ikke mere strøm på bilen");
                Console.WriteLine("Du har køret " + car1.Meter + " meter\n");

                choise = 2; //Set choise to 2
            }
            else if (car1.Battery > 0) //If cars battery is over 0
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hvad ønsker du at gøre ");
                Console.WriteLine("1. Kør i bilen, den har kørt " + car1.Meter + " meter");
                Console.WriteLine("2. Oplad bilen, der er " + car1.Battery + "% på bilen");
                Console.ForegroundColor = ConsoleColor.Cyan;
                choise = Convert.ToInt32(Console.ReadLine());
            }

            switch (choise)
            {
                case 1: //If case = 1, drive car
                    car1.Drive(); //Run drive method
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nBilen kører...\n");
                    break;
                case 2: //If case = 2, charge car
                    car1.Charge(); //Run change method
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nDu er igang med at oplade bilen...");
                    Task.Delay(1000).Wait(); //Set delay to 1 sec (1000 ms)
                    Console.WriteLine("Bilen er nu på " + car1.Battery + "%\n");
                    break;
            }
        }
    }
}
