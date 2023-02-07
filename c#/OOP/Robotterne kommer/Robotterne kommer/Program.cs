public class Program
{
    public class Robot
    {
        public string Colour { get; set; }
        public string Chip { get; set; }
        public bool WIFI { get; set; }
        public byte Battery { get; set; }
        public double Sope { get; set; }
        public int Wheels { get; set; }

        public Robot() //Robot defualt constructor
        {

            //Random MicroShip between "RX54667" and "QT8339"
            string[] chip = { "RX54667", "QT8339" };
            Random random = new Random();
            int index = random.Next(chip.Length);

            Random rnd = new Random();

            Colour = "white";
            Chip = chip[index];
            WIFI = false;
            Battery = (byte)rnd.Next(0, 255); //Random battery size, between 0 and 255
            Sope = 0;
            Wheels = 0;
        }
    }

    static void Main(string[] args)
    {
        Robot robot1 = new Robot(); //Makes a new robot, called robot1. From constructor "Robot"
        Robot robot2 = new Robot(); //Makes a new robot, called robot2. From constructor "Robot"

        byte choise = 2;
        bool rengøring = false;


        //ROBOT 1\\
        Console.WriteLine("Hvilken farve skal robot1 være?");
        robot1.Colour = Console.ReadLine(); //Set "Readline" to robot colour

        Console.WriteLine("Skal robot1 have WIFI? 1=yes, 2=no");
        choise = Convert.ToByte(Console.ReadLine()); //Convert "ReadLine" to byte

        if (choise == 1) //If the user choose 1, Robot1.WIFI = true
        {
            robot1.WIFI = true;
        }

        Console.WriteLine("Skal robot1 være en rengørings-robot? 1=yes, 2=no");
        choise = Convert.ToByte(Console.ReadLine()); //Convert "ReadLine" to byte

        if (choise == 1) //If the robot is a cleaning robot, it has no battery, but 2.3 L sope
        {
            robot1.Battery = 0;
            robot1.Sope = 2.3;
        }

        Console.WriteLine("Hvor mange hjul skal robot1 have?");
        robot1.Wheels = Convert.ToInt32(Console.ReadLine()); //Convert "ReadLine" to int


        //ROBOT 2\\
        Console.WriteLine("Hvilken farve skal robot2 være?");
        robot2.Colour = Console.ReadLine(); //Set "Readline" to robot colour

        Console.WriteLine("Skal robot2 have WIFI? 1=yes, 2=no");
        choise = Convert.ToByte(Console.ReadLine()); //Convert "ReadLine" to byte

        if (choise == 1) //If the user choose 1, Robot2.WIFI = true
        {
            robot2.WIFI = true;
        }

        Console.WriteLine("Skal robot2 være en rengørings-robot? 1=yes, 2=no");
        choise = Convert.ToByte(Console.ReadLine()); //Convert "ReadLine" to byte

        if (choise == 1) //If the robot is a cleaning robot, it has no battery, but 2.3 L sope
        {
            robot2.Battery = 0;
            robot2.Sope = 2.3;
        }

        Console.WriteLine("Hvor mange hjul skal robot2 have?");
        robot2.Wheels = Convert.ToInt32(Console.ReadLine()); //Convert "ReadLine" to int

        //COLOUR CHECK\\
        if (robot1.Colour != "white") //Checks if robot1.Colour is not "white"
        {
            robot1.Battery = 0;
        }

        if (robot2.Colour != "white") //Checks if robot2.Colour is not "white"
        {
            robot1.Battery = 0;
        }

        //PRINT SPECS OF ROBOTS\\
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Robot1 colour: " + robot1.Colour);
        Console.WriteLine("Robot1 chip: " + robot1.Chip);
        Console.WriteLine("Robot1 WIFI: " + robot1.WIFI);
        Console.WriteLine("Robot1 Battery: " + robot1.Battery);
        Console.WriteLine("Robot1 Sope: " + robot1.Sope);
        Console.WriteLine("Robot1 Wheels: " + robot1.Wheels);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("---------------");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Robot2 colour: " + robot2.Colour);
        Console.WriteLine("Robot2 chip: " + robot2.Chip);
        Console.WriteLine("Robot2 WIFI: " + robot2.WIFI);
        Console.WriteLine("Robot2 Battery: " + robot2.Battery);
        Console.WriteLine("Robot2 Sope: " + robot2.Sope);
        Console.WriteLine("Robot2 Wheels: " + robot2.Wheels);
    }
}