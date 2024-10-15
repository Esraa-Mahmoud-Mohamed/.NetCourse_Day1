using System;

class Program
{
    static string storedUsername;
    static string storedPassword;

    // Function to register a new user
    static void Register()
    {
        Console.WriteLine("### Registration ###");
        Console.Write("Enter your username: ");
        storedUsername = Console.ReadLine();
        Console.Write("Enter your password: ");
        storedPassword = Console.ReadLine();
    }

    // Function to log in the user
    static void Login()
    {
        Console.WriteLine("\n### Login ###");
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        if (username == storedUsername && password == storedPassword)
        {
            Console.WriteLine("Login successful! Welcome!");
        }
        else
        {
            Console.WriteLine("Invalid username or password. Please try again.");
        }
    }

    // Main function
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the User Login System!");

        // Register user
        Register();

        while (true)
        {
            Console.WriteLine("\nWould you like to (1) Login or (2) Exit?");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Login();
                    break;
                case "2":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid option. Please enter 1 or 2.");
                    break;
            }
        }
    }
}
