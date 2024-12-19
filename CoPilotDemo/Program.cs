namespace CoPilotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(random.Next(1, 101)); // Generate random integers between 1 and 100
            }

            Console.WriteLine("Even numbers:");
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

      
    }
}
