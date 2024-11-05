namespace MiniKata4;

class Program
{
    static void Main(string[] args)
    {
        int enemyCount = 1;
        
        Console.WriteLine("This is a for loop: ");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Enemy {i} spawned");
        }
        
        Console.WriteLine("This is a while loop: ");

        while (enemyCount <= 5)
        {
            Console.WriteLine($"Enemy {enemyCount} spawned");
            enemyCount++;
        }
    }
}