using System.Threading;
using System.Transactions;

namespace _6_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string choice = "";

            //while (choice != "q")
            //{
            //    Console.Clear();
            //    Console.WriteLine("-- Menu --");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Prompter");
            //    Console.WriteLine("2 - Percent Passing");
            //    Console.WriteLine("3 - Odd Sum");
            //    Console.WriteLine("4 - Dice Game");
            //    Console.WriteLine("5 - Random Numbers");
            //    Console.WriteLine("...");
            //    Console.WriteLine("x - Menu Option x");
            //    Console.WriteLine("Q - Quit");
            //    Console.WriteLine();
            //    choice = Console.ReadLine().ToLower().Trim();
            //    Console.WriteLine();

            //    if (choice == "1")
            //    {
            //        Console.WriteLine("You chose option 1");
            //        Console.WriteLine("Hit ENTER to continue.");
            //        Console.ReadLine();
            //        RunPrompter();

            //    }
            //    else if (choice == "2")
            //    {
            //        Console.WriteLine("You chose option 2");
            //        Console.WriteLine("Hit ENTER to continue.");
            //        Console.ReadLine();
            //    }
            //    else if (choice == "3")
            //    {
            //        Console.WriteLine("You chose option 3");
            //        Console.WriteLine("Hit ENTER to continue.");
            //        Console.ReadLine();
            //    }
            //    else if (choice == "4")
            //    {
            //        Console.WriteLine("You chose option 4");
            //        Console.WriteLine("Hit ENTER to continue.");
            //        Console.ReadLine();
            //    }
            //    else if (choice == "5")
            //    {
            //        Console.WriteLine("You chose option 5");
            //        Console.WriteLine("Hit ENTER to continue.");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid choice, press ENTER to continue.");
            //        Console.ReadLine();
            //    }
            //}
            bool running = true;

            while (running)
            {
                Console.WriteLine("-- Menu --");
                Console.WriteLine("1. Prompter");
                Console.WriteLine("2. Percent Passing");
                Console.WriteLine("3. Odd Sum");
                Console.WriteLine("4. Dice Game");
                Console.WriteLine("5. Random Numbers");

                Console.WriteLine("Choose what program to run (1-5): ");
                string choice = Console.ReadLine();

                //if (choice < 1 || choice > 4)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("Invaild Outcome. Choose from choices (1-4).");
                //    Console.WriteLine();
                //    continue;
                //}
                //else
                //{
                //    Console.WriteLine("Invalid choice, press ENTER to continue.");
                //    Console.ReadLine();
                //}

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


                    default:
                        Console.WriteLine();
                        break;

                }
            }

        }
        public static void RunPrompter()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Prompter Program");

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine();
            }
            

        }
        public static void RunPercentPassing()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Percent Passing Program");
                

        }

        public static void RunOddSum()
        {
            Console.WriteLine();
            Console.WriteLine("Odd Sum Program");

        }

        public static void RunDiceGame()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Dice Game Program");
            RunDiceGame();
        }


        public static void RunRandomNumbers()
        {
            Random generator = new Random();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Random Numbers Program");

            string min;
            Console.WriteLine("Enter minimum value");
            min = Console.ReadLine();

            string max;
            Console.WriteLine("Enter maximum value");
            max = Console.ReadLine();


        }
     
    }
}