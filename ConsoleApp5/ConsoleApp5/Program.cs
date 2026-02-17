namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(1, 101);
            int guess;
            Console.WriteLine("guess a number from 1-100");
            guess = Convert.ToInt32(Console.ReadLine());
            if(guess>number)
            {
                Console.WriteLine("too high");
            }
            else if(guess<number)
            {
                Console.WriteLine("too low");
            }
            else
            {
                Console.WriteLine("you win");
            }
        }
    }
}
