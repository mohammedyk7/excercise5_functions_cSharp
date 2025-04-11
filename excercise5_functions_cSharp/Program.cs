using System;

class Program
{
    static void Main()
    {
        string wink = " ;D "; // Added wink variable 
        int choice;


        DisplayWelcomeMessage(); // Call this first to show the welcome message
        choice = ShowMainMenu(); // to capture the return value of ShowMainMenu
        HandleMenuChoice(choice, wink); // Pass the choice to HandleMenuChoice
        ShowFlightDetails(); // Call this method to show flight details
        BookFlight(); // Call this method to book a flight
        CancelFlight(); // Call this method to cancel a flight
        ExitProgram(); // Call this method to exit the program
        ViewFlightDetails(); // Call this method to view flight details
    }
    static void p(string message) // Added print method istead of console.writeline 
    {
        Console.WriteLine(message);
    }

    static void DisplayWelcomeMessage()
    {
        Console.Clear();
        p("                                                ");
        p("          C O D L I N E A I R W A Y S                   ");
        p("=======================================");
        p("          WELCOME TO SKYWAYS AIRLINES         ");
        p("=======================================");
        p("          Relax and stay calm ");
        p("          Enjoy your flight.");
        p("=======================================");
        p("Press any key to continue...");
        Console.ReadKey(); // Corrected method name from Readkey to ReadKey  
    }

    static int ShowMainMenu()
    {
        Console.Clear();
        p("=======================================");
        p("          MAIN MENU         ");
        p("=======================================");
        p("1. Book a flight");
        p("2. Cancel a flight");
        p("3. View flight details");
        p("4. Exit");
        p("=======================================");

        Console.Write("Please enter your choice: ");
        string? input = Console.ReadLine(); // Allow null input
        if (int.TryParse(input, out int choice)) // Safely parse input  
        {
            return choice; // Return integer
        }
        else
        {
            p("Invalid input. Please enter a number between 1 and 4.");
            return ShowMainMenu(); // Recursively prompt again  
        }
    }

    static void HandleMenuChoice(int choice, string wink) // Parameter added with no return
    {
        switch (choice)
        {
            case 1:
                p("You chose to book a flight." + wink);
                break;
            case 2:
                p("You chose to cancel a flight.");
                break;
            case 3:
                p("Viewing flight details...");
                break;
            case 4:
                p("Exiting the program. Thank you!");
                break;
            default:
                p("Invalid choice. Please try again.");
                break;
        }

        Console.ReadKey(); // Pause before closing or looping
    }

    static void ShowFlightDetails()
    {
        p("Flight details are as follows:");
        p("Flight Number: 1234");
        p("Destination: New York");
        p("Departure Time: 10:00 AM");
        p("Arrival Time: 1:00 PM");
        p("=======================================");
        Console.ReadKey(); // Pause before closing
    }
    static void BookFlight()
    {
        p("Booking a flight...");
        // Add booking logic here
        Console.ReadKey(); // Pause before closing
    }
    static void CancelFlight()
    {
        p("Cancelling a flight...");
        // Add cancellation logic here
        Console.ReadKey(); // Pause before closing
    }
    static void ExitProgram()
    {
        p("Exiting the program...");
        // Add exit logic here
        Console.ReadKey(); // Pause before closing
    }
    static void ViewFlightDetails()
    {
        p("Viewing flight details...");
        // Add logic to view flight details here
        Console.ReadKey(); // Pause before closing
    }
    static void ShowFlightDetails(string flightNumber)
    {
        p($"Flight details for {flightNumber}:");
        p("Flight Number: 1234");
        p("Destination: New York");
        p("Departure Time: 10:00 AM");
        p("Arrival Time: 1:00 PM");
        p("=======================================");
        Console.ReadKey(); // Pause before closing
    }
    static void BookFlight(string flightNumber)
    {
        p($"Booking flight {flightNumber}...");
        // Add booking logic here
        Console.ReadKey(); // Pause before closing
    }
    static void CancelFlight(string flightNumber)
    {
        p($"Cancelling flight {flightNumber}...");
        // Add cancellation logic here
        Console.ReadKey(); // Pause before closing
    }
    static void ExitProgram(string flightNumber)
    {
        p($"Exiting the program for flight {flightNumber}...");
        // Add exit logic here
        Console.ReadKey(); // Pause before closing
    }
    static void ViewFlightDetails(string flightNumber)
    {
        p($"Viewing flight details for {flightNumber}...");
        // Add logic to view flight details here
        Console.ReadKey(); // Pause before closing
    }
    static void ShowFlightDetails(string flightNumber, string destination)
    {
        p($"Flight details for {flightNumber} to {destination}:");
        p("Flight Number: 1234");
        p("Destination: New York");
        p("Departure Time: 10:00 AM");
        p("Arrival Time: 1:00 PM");
        p("=======================================");
        Console.ReadKey(); // Pause before closing
    }
}

