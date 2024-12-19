namespace CoPilotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = Person.CreatePersonFromUserInput();
            Person person2 = Person.CreatePersonFromUserInput();

            Console.WriteLine("\nPerson 1 Info:");
            person1.DisplayInfo();

            Console.WriteLine("\nPerson 2 Info:");
            person2.DisplayInfo();
        }
    }
}
