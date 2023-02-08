namespace Fordelingshatten
{
    public class Program
    {
        enum Colleges { Gryffindor, Hufflepuff, Ravenclaw, Slytherin }

        public static void Main(string[] args)
        {
            Sortinghat sorter = new Sortinghat();

            Console.WriteLine(sorter.Sorter());
        }
    }
}