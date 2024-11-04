// https://github.com/edamiani/gamedev-dojo-csharp/wiki/White-Belt-Katas

namespace WhiteBelt;

class Program
{
    static void Main(string[] args)
    {
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