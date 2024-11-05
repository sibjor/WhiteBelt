namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Player";
        int level = 1;
        int levelUpgrade = 100;
        float healthPoints = 5.5f;
        double experiencePoints = 55.45;
        bool magicAbility = true;
        char rank = 'C';
        
        Console.WriteLine($"Name: {name}\nLevel: {level}\nHealthPoints: {healthPoints}\nXP: {experiencePoints}\nMagicAbility: {magicAbility}\nRank: {rank}" );
        
        if (experiencePoints == levelUpgrade)
        {
            level++;
        }
        Console.WriteLine($"Points needed to reach next level: {levelUpgrade-experiencePoints}");
    }
}