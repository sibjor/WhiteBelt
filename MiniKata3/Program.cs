namespace Kata4;

class Program
{
    static void Main(string[] args)
    {
        int playerLuck = 5;
        Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (y/n)");
        string input = "";
        input = Console.ReadLine();
        if (input.ToLower() == "y")
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
        else if (input.ToLower() == "n")
        {
            Console.WriteLine("The player retreated...");
        }
        else
        {
            Console.WriteLine("Invalid input. Try again.");
        }
    }
}
