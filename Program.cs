namespace Topic_7._1_Loops_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random generator = new Random();
            int number = generator.Next(1, 11);
            int guess = 0;
            int tries = 0;

            while (guess != number && tries <5)
            {
                Console.Write("Guess a number from 1 to 10: ");
                int.TryParse(Console.ReadLine(), out guess);

                tries++;

                if (guess < number)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too High!");
                }
                else
                {
                    Console.WriteLine("Correct! You Win!");
                }
            }
            if (guess == number)
            {
                Console.WriteLine("You can out of guesses. You lose!");
                Console.WriteLine("The number was " + number);
            }

            Console.WriteLine();


            //Part 2 DICE DOUBLES

            Console.WriteLine("PART 2 - DICE DOUBLES");

            int dice1 = 0;
            int dice2 = 1;
            int count = 0;
            while (dice1 != dice2)
            {
                dice1 = generator.Next(1, 7);
                dice2 = generator.Next(1, 7);

                count++;

                Console.WriteLine("Dice1: " + dice1);
                Console.WriteLine("Dice2: " + dice2);
                Console.WriteLine();
            }
        }  

    }
}
