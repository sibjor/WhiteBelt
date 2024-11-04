namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        Character myCharacter = new("Arin", 100, 15.5f, true, 24.75);
    }


    class Character
    {
        public Character
        ( // Parameters below
            string name,
            int healthPoints,
            float attackPower,
            bool isParalyzed,
            double currencyAmount
        )
        {
            // Constructor
            _name = name;
            _healthPoints = healthPoints;
            _attackPower = attackPower;
            _isParalyzed = isParalyzed;
            _currencyAmount = currencyAmount;

            PrintCharacterInfo();
        }

        public void PrintCharacterInfo()
        {
            Console.WriteLine($"Character name: {_name}" +
                              $"\n Health Points: {_healthPoints}" +
                              $"\n Attack Power: {_attackPower}" +
                              $"\n IsParalyzed: {_isParalyzed}" +
                              $"\n Gold Amount: ${_currencyAmount}");
        }

        string _name;
        int _healthPoints;
        float _attackPower;
        bool _isParalyzed;
        double _currencyAmount;
    }
}
