using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            //master loop example
            //try catch exceptions
            try {
                while (true) {
                Console.WriteLine("Type a message and I will yell it:");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit") {
                    break;
                }
                if (input == "kev") {
                    throw new Exception();
                }
                if (input.ToLower() == "oil") {
                    Console.WriteLine("...Opening Oil-Change Program...");
                    
                    while (true) {
                        Console.WriteLine("Please enter your mileage:");
                        string oilInput = Console.ReadLine();
                        if (oilInput.ToLower() == "x") {
                            Console.WriteLine("User entered X-key, back to main program...");
                            break;
                        }
                        if (Convert.ToInt32(oilInput) > 0) {
                            int nextMileage = Convert.ToInt32(oilInput) + 3000;
                            Console.WriteLine($"Your next oil change is at {nextMileage} miles.");
                        }
                    }
                }
                Console.WriteLine(input.ToUpper(), "!");
            }
            } catch (Exception ex) {
                Console.WriteLine("You are Kev, throwing my exception:");
                Console.WriteLine(ex);
            }
            

        }
    }
}
