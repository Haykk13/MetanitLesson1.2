using System;

namespace MetanitLesson1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer: ");
            int num = int.Parse(Console.ReadLine());

            if(num > 5 && num < 10)
            {
                Console.WriteLine($"{num} is between 5 and 10");
            }
            else
            {
                Console.WriteLine("Unknown integer");
            }

            Console.ReadLine();
        }
    }
}
