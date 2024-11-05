namespace ExamKata;

class Program
{
    static void Main(string[] args)
    {
        int playerDamage = 20;
        int playerHealth = 100;
        int playerMaximumHealth = 100;
        int playerHeal = 20;
        string playerName = "Player";

        int enemyDamage = 30;
        int enemyHealth = 80;
        int enemyMaximumHealth = 80;
        int enemyHeal = 15;
        string enemyName = "Enemy";

        int playerInput;

        while (true)
        {
            Console.WriteLine($"Player Health: {playerHealth}\n Enemy Health: {enemyHealth}");
            Console.WriteLine("Choose one of the following options: \n1. Attack\n2. Heal");
            
            playerInput = int.Parse(Console.ReadLine());
            if (playerInput == 1)
            {
                enemyHealth -= playerDamage;
                Console.WriteLine($"{playerName} deals {playerDamage} of damage to {enemyName}");
            }
            else if (playerInput == 2)
            {
                while (playerHealth < playerMaximumHealth)
                {
                    playerHealth += playerHeal;
                    // see to it that its never higher than playerMaximumHealth!
                }
            }
        }
    }
}