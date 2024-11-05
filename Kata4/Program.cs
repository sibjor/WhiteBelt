namespace Kata4;

class Program
{
    static void Main(string[] args)
    {
        int enemyCount = 5;
        int waveCount = 2;

        for (int i = 1; i <= waveCount; i++)
        {
            Console.WriteLine($"Wave #{i} starting...");

            for (int o = 0; o < enemyCount; o++)
            {
                Console.WriteLine($"Enemy #{o + 1} entering the arena");
            }
        }
        Console.WriteLine("All waves completed! Victory is yours!");
    }
}