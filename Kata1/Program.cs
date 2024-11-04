// https://github.com/edamiani/gamedev-dojo-csharp/wiki/White-Belt-Katas

namespace WhiteBelt;

class Program
{
    static void Main(string[] args)
    {
        /*
Prompt the player to enter their name.
Read the player’s name from the console.
Greet the player using their name, displaying a personalized message.
Ask the player about their excitement level (from 1 to 10).
Read the excitement level and display a response based on the value:
7 or higher: Display an enthusiastic response.
Lower than 7: Display a message encouraging the player.
         */
        Console.WriteLine("Please provide your name: ");
        string answerName = Console.ReadLine();
        Console.WriteLine($"Hello {answerName.ToUpper()}! Nice to have you here");
        Console.WriteLine("From 1-10, please provide your level of excitement: ");
        int answerExcitement = int.Parse(Console.ReadLine());
        switch (answerExcitement)
        {
            case <7:
                Console.WriteLine("Sorry to hear that, how about trying again after a snack?");
                break;
            case >= 7:
                Console.WriteLine("Nice to hear that! I hope you look forward to continuing as much as I do!");
                break;
        }
    }
}