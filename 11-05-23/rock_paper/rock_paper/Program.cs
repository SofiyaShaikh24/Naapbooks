using System;

namespace rock_paper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Rock ");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors ");
            Console.WriteLine("Enter no of your Choice : ");
            int player = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int opponent = rnd.Next(1, 4);
            Console.WriteLine("Opponent Chooses : " + opponent);
            if (player == opponent)
            {
                Console.WriteLine("It's a Tie :| ");
            }
            else if (player == 1 && opponent == 2)
            {
                Console.WriteLine("You Lose :( ");
            }
            else if (player == 1 && opponent == 3)
            {
                Console.WriteLine("You Win :) ");
            }
            else if (player == 2 && opponent == 1)
            {
                Console.WriteLine("You Win :) ");
            }
            else if (player == 2 && opponent == 3)
            {
                Console.WriteLine("You Lose :( ");
            }
            else if (player == 3 && opponent == 1)
            {
                Console.WriteLine("You Lose :( ");
            }
            else if (player == 3 && opponent == 2)
            {
                Console.WriteLine("You Win :) ");
            }
            else
            {
                Console.WriteLine("Invalid Choice ! ");
            }
            Console.ReadKey();
        }
    }
}




