using System;

namespace NumberAnalyzer___DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer between 1 and 100.");

            int x = int.Parse(Console.ReadLine());
            bool tryAgain = false;
            while (tryAgain == true)
            {
              
                string answer = Console.ReadLine().ToLower();
                Console.WriteLine(answer);
                if(answer == "y")
                {
                    Console.WriteLine("Let's try again!");
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Good bye!");
                }
            
            }

            if (x < 1 || x > 100)
            
            {
                Console.WriteLine("That was not an acceptable integer!");
            }
            else
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine($"{x} is even.");
                }
                else
                {
                    Console.WriteLine($"{x} is odd.");
                }
                if (x % 2 == 0 && x > 2 && x < 25)
                {
                    Console.WriteLine($"{x} is even and less than 25.");
                }
                else if (x % 2 == 0 && x > 25 && x < 60)
                {
                    Console.WriteLine($"{x} is even.");
                }
                if (x % 2 == 0 && x > 60)
                {
                    Console.WriteLine($"{x} is even.");
                }
                if (x % 2 != 0 && x > 60)
                {
                    Console.WriteLine($"{x} is odd.");
                }
            }
            
            
           







        }
    }
}
