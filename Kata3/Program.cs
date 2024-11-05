namespace Kata3;

class Program
{
    static void Main(string[] args)
    {
        int playerLuck = 5;
        string playerChoice;
        
        Console.WriteLine("You encountered a chest! Choose one option:\n 1. Try open the chest\n 2. Ignore the chest\n 3. Leave the area");
        playerChoice = Console.ReadLine();
        if (playerChoice == "1")
        {
            // nested if:s previously proven in MiniKata3, for variations sake I use a switch case this time
            switch (playerLuck) 
            {
                case > 7:
                {
                    Console.WriteLine("You found a rare gem inside the chest!");
                }
                    break;
                case >= 5:
                {
                    Console.WriteLine("You found some gold inside the chest!");
                }
                    break;
                case < 5:
                {
                    Console.WriteLine("The chest is trapped after trying to open it!");
                }
                    break;
            }
        }
        else if (playerChoice == "2")
        {
            Console.WriteLine("You continue your journey");
        }
        else if (playerChoice == "3")
        {
            Console.WriteLine("You leave the area, leaving the mystery unsolved");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}