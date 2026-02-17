namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, total = 1;
            Console.WriteLine("write the number to calculate factorial");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                total = total * (i + 1);
            }
            Console.WriteLine("the factorial of " + number + " is " + total);
        }
    }
}
