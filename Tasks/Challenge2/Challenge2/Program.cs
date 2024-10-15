using System;

class HighScoreApp
{
    static int highscore = 0;
    static string highscorePlayer = "No player yet";

    // Method to check and update the highscore
    static void CheckHighscore(int score, string playerName)
    {
        if (score > highscore)
        {
            highscore = score;
            highscorePlayer = playerName;

            Console.WriteLine("\nNew highscore is: " + highscore);
            Console.WriteLine("New highscore holder is: " + highscorePlayer);
        }
        else
        {
            Console.WriteLine("\nThe old highscore of " + highscore + " could not be broken.");
            Console.WriteLine("It is still held by " + highscorePlayer);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the High Score Application!");

        while (true)
        {
            Console.Write("\nEnter player's name (or type 'exit' to stop): ");
            string playerName = Console.ReadLine();

            if (playerName.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            Console.Write("Enter player's score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            CheckHighscore(score, playerName);
        }
    }
}
