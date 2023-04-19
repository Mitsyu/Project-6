using Dice_Game;
namespace _6_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            bool running = true;

            while (running)
            {
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("-- Menu --");
                Console.WriteLine("1. Prompter");
                Console.WriteLine("2. Percent Passing");
                Console.WriteLine("3. Odd Sum");
                Console.WriteLine("4. Dice Game");
                Console.WriteLine("5. Random Numbers");
                Console.WriteLine("6. Quit");
                Console.WriteLine();
                Console.WriteLine("Choose what program to run (1-6): ");
                choice = Console.ReadLine().ToLower().Trim();

                switch (choice)
                {

                    case "1":
                        RunPrompter();
                        break;

                    case "2":
                        RunPercentPassing();
                        break;

                    case "3":
                        RunOddSum();
                        break;

                    case "4":
                        RunDiceGame();
                        break;

                    case "5":
                        RunRandomNumbers();
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Choose from (1-6)");
                        break;
                }
            }
        }
        public static void RunPrompter()
        {
            Console.WriteLine();
            Console.WriteLine("Prompter Program");
            Console.WriteLine();

            int min, max, number;
            bool exit = false;

            Console.Write("Enter a minimum value: ");
            while (!int.TryParse(Console.ReadLine(), out min))
            {
                Console.Write("Invalid input. Enter a minimum value again: ");
            }

            Console.Write("Enter a maximum value: ");
            while (!int.TryParse(Console.ReadLine(), out max) || max < min)
            {
                if (max < min)
                {
                    Console.Write("Maximum value must be greater than or equal to the minimum value. Enter a maximum value again: ");
                }
                else
                {
                    Console.Write("Invalid input. Enter a maximum value again: ");
                }
            }

            while (!exit)
            {
                Console.WriteLine("Enter a number between {0} and {1} (or 'exit' to quit):", min, max);
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    exit = true;
                }
                else if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or 'exit'.");
                }
                else if (number < min || number > max)
                {
                    Console.WriteLine($"The entered number must be between {min} and {max}.");
                }
                else
                {
                    Console.WriteLine($"{number} is between {min} and {max}.");
                }
            }
        }
        public static void RunPercentPassing()
        {
            int score, count = 0, above70 = 0;
            string input;

            do
            {
                Console.Write("Enter a score (or enter 'exit' when done): ");
                input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                if (!int.TryParse(input, out score))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer (or enter 'exit' when done).");
                    continue;
                }
                if (score >= 0)
                {
                    count++;
                    if (score > 70)
                    {
                        above70++;
                    }
                }
            } while (true);

            double percentAbove70 = count > 0 ? (double)above70 / count * 100 : 0;
            Console.WriteLine("{0}% of the scores entered are above 70", percentAbove70);

        }

        public static void RunOddSum()
        {
            Console.WriteLine();
            Console.WriteLine("Odd Sum Program");
            Console.WriteLine();
            int number;
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(),out number))
            {
                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum += i;
                    }

                }
                Console.WriteLine("The sum of the odd numbers from 1 to {0} is {1}.", number, sum);
            }
        }
        public static void RunRandomNumbers()
        {
            Console.WriteLine();
            Console.WriteLine("Random Numbers Program");
            Console.WriteLine();

            Random random = new Random();
            int min, max;

            Console.Write("Enter a minimum value: ");
            while (!int.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter a minimum value: ");
                Console.WriteLine();
            }

            Console.Write("Enter a maximum value: ");
            while (!int.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter a maximum value: ");
                Console.WriteLine();
            }

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                Console.Write(" "+ randomNumber);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void RunDiceGame()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Dice Game Program");

            Die die1 = new Die();
            Die die2 = new Die();
            double bankAccount = 100.00;
            double betAmount;

            Console.WriteLine("Welcome to the Dice Game");
            Thread.Sleep(500);
            Console.WriteLine();

            Console.WriteLine($"You have ${bankAccount} in your bank account");
            Console.WriteLine();

            while (bankAccount > 0)
            {
                Console.ResetColor();
                Console.WriteLine("Choose an outcome: ");
                Console.WriteLine("1. Doubles");
                Console.WriteLine("2. Not double");
                Console.WriteLine("3. Even sum");
                Console.WriteLine("4. Odd sum");
                Console.Write("Enter choice (1-4): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice < 1 || choice > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invaild Outcome. Choose from choices (1-4).");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine();
                Console.Write("Enter bet amount: ");
                betAmount = Convert.ToInt32(Console.ReadLine());

                if (betAmount == 0)
                {
                    break;
                }

                if (betAmount > bankAccount)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Not enough money, you only have ${bankAccount} in your bank account.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Rolling Dice...");
                Thread.Sleep(800);

                int roll1 = die1.RollDie();
                int roll2 = die2.RollDie();
                int total = roll1 + roll2;

                Console.WriteLine();

                Console.WriteLine($"You rolled a {roll1} and {roll2}");

                Thread.Sleep(500);

                die1.DrawRoll();
                die2.DrawRoll();

                double winnings = 0.00;

                switch (choice)
                {

                    case 1:
                        if (choice == 1 && roll1 == roll2)
                        {
                            winnings = betAmount * 2;
                            bankAccount += winnings;
                            Console.WriteLine($"You won ${winnings} !!!");
                            Console.WriteLine();
                            Console.WriteLine($"You have ${bankAccount} in your bank account");
                        }

                        else
                        {
                            Console.WriteLine($"You lost ${betAmount}");
                            bankAccount -= betAmount;
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                        }
                        break;

                    case 2:
                        if (choice == 2 && roll1 == roll2)
                        {
                            Console.WriteLine($"You lost ${betAmount}");
                            bankAccount -= betAmount;
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                        }
                        else
                        {
                            winnings = betAmount / 2;
                            bankAccount += winnings;
                            Console.WriteLine($"Woohoo! You won ${winnings} !!");
                            Console.WriteLine();
                            Console.WriteLine($"You have ${bankAccount} in your bank account");
                        }
                        break;

                    case 3:
                        if (choice == 3 && total % 2 == 0)
                        {
                            winnings += betAmount;
                            Console.WriteLine("WooHoo! You won $" + betAmount + ".");
                            Console.WriteLine();
                            Console.WriteLine($"You have ${bankAccount} in your bank account");
                        }
                        else
                        {
                            Console.WriteLine($"You lost ${betAmount}");
                            bankAccount -= betAmount;
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                        }
                        break;

                    case 4:
                        if (choice == 4 && total % 2 != 0)
                        {
                            winnings += betAmount;
                            Console.WriteLine($"Woohoo! You won ${winnings} !!");
                            Console.WriteLine();
                            Console.WriteLine($"You have ${bankAccount} in your bank account");
                        }
                        else
                        {
                            Console.WriteLine($"You lost ${betAmount}");
                            bankAccount -= betAmount;
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                        }
                        break;

                }

                if (bankAccount <= 0)
                {
                    Console.WriteLine("GAME OVER. You have no more money to bet");
                    Console.WriteLine();
                    Console.Write("Add more money to bank account and play again? (y/n):");
                    string tryAgain = Console.ReadLine();
                    Console.WriteLine();

                    switch (tryAgain)
                    {
                        case "y":
                            Console.Write("Enter deposit amount: ");
                            double depositAmount = double.Parse(Console.ReadLine());
                            bankAccount += depositAmount;
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                            break;

                        case "n":
                            Console.WriteLine();
                            Console.WriteLine("See you next time.");
                            break;

                    }


                }

                Console.WriteLine();


            }
        }






    }
}