using System;

class Program
{
    static void Main()
    {
        string wink = " ;D "; // Added wink variable

        DisplayWelcomeMessage(wink); // Call this first to show the welcome message
        int choice = ShowMainMenu(); // Capture the return value of ShowMainMenu
        HandleMenuChoice(choice);    // Pass the choice to HandleMenuChoice
    }

    static void DisplayWelcomeMessage( string wink)
        // No parameters
       
    {
        Console.Clear();
        Console.WriteLine("                                                ");
        Console.WriteLine("          C O D L I N E A I R W A Y S" + wink);
        Console.WriteLine("=======================================");
        Console.WriteLine("          WELCOME TO SKYWAYS AIRLINES         ");
        Console.WriteLine("=======================================");
        Console.WriteLine("          Relax and stay calm ");
        Console.WriteLine("          Enjoy your flight.");
        Console.WriteLine("=======================================");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(); // Corrected method name from Readkey to ReadKey  
    }

    static int ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine("          MAIN MENU         ");
        Console.WriteLine("=======================================");
        Console.WriteLine("1. Book a flight");
        Console.WriteLine("2. Cancel a flight");
        Console.WriteLine("3. View flight details");
        Console.WriteLine("4. Exit");
        Console.WriteLine("=======================================");

        Console.Write("Please enter your choice: ");
        string? input = Console.ReadLine(); // Allow null input  + i added it here because i cant add it as a parameter in the method above
        if (int.TryParse(input, out int choice)) // Safely parse input  
        {
            return choice; //return integer
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            return ShowMainMenu(); // Recursively prompt again  
        }
    }

    static void HandleMenuChoice(int choice) //parameter added with no return 
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("You chose to book a flight.");
                break;
            case 2:
                Console.WriteLine("You chose to cancel a flight.");
                break;
            case 3:
                Console.WriteLine("Viewing flight details...");
                break;
            case 4:
                Console.WriteLine("Exiting the program. Thank you!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        Console.ReadKey(); // Pause before closing or looping
    }
}

