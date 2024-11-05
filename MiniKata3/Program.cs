namespace Kata4;

class Program
{
    static void Main(string[] args)
    {
        int playerLuck = 5;
        Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (y/n)");
        if (Console.ReadLine() == "y")
        {
            if (playerLuck > 7)
            {
                Console.WriteLine("Attack successful");
            }
            else if (playerLuck == 6 || playerLuck == 7)
            {
                Console.WriteLine("Attack barely successful");
            }
            else if (playerLuck < 6)
            {
                Console.WriteLine("Attack missed");
            }
        }
        else if (Console.ReadLine() == "n")
        {
            Console.WriteLine("The player wished not to attack...");
        }
        else
        {
            Console.WriteLine("Invalid input. Try again.");
        }
    }
}