namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var victor = new BankAccount();
            string? answer;
            bool exit;
            Greetings();
            do
            {
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("How much money would you like to deposit?");
                            Console.WriteLine("If you didn´t wanted to deposit money just type \"cancel\"");
                            var userInput = Console.ReadLine();
                            if (double.TryParse(userInput, out double result))
                            {
                                if (result > 1)
                                {
                                    victor.Deposit(result);
                                    Console.WriteLine($"\n${result} dollars have been deposited into your account!\n");
                                    exit = true;
                                }
                                else if (result == 1)
                                {
                                    victor.Deposit(result);
                                    Console.WriteLine($"\n${result} dollar has been deposited into your account!\n");
                                    exit = true;
                                }
                                else
                                {
                                    Console.WriteLine("Please try again with a correct amount.\n");
                                    exit = false;
                                }
                            }
                            else
                            {
                                if (userInput == "cancel")
                                {
                                    Console.WriteLine("\nYou have cancelled this procedure.\n");
                                    exit = true;
                                }
                                else
                                {
                                    Console.WriteLine("\nPlease write a correct amount!\n");
                                    exit = false;
                                }
                            }
                        } while (exit == false);
                        Return();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"Your balance is: ${victor.GetBalance()}.\n");
                        Return();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("\n\n\t\t\t\tThank you for using our services. Have a great day!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice!\n");
                        Wrong();
                        break;

                }

            } while (answer != "3");

        }

        public static void Greetings()
        {
            Console.WriteLine("Hello! What would you like to do today?\n" +
                    "1: Deposit money in your account\n" +
                    "2: To check your balance\n" +
                    "3: Exit the program");
        }
        
        public static void Return()
        {
            Console.WriteLine("Do you need something else?\n" +
                        "1: Deposit money in your account\n" +
                        "2: To check your balance\n" +
                        "3: Exit the program");
        }

        public static void Wrong()
        {
            Console.WriteLine("What would you like to do?\n" +
                    "1: Deposit money in your account\n" +
                    "2: To check your balance\n" +
                    "3: Exit the program");
        }
    }
}
