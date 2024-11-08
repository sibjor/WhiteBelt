﻿namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Arin";
        int healthPoints = 100;
        float attackPower = 3.4f;
        bool isParalyzed = true;
        string currencyAmount = "150.3333333";

        // implicit conversion
        double healthPointsDouble = healthPoints;
        Console.WriteLine($"Healthpoints from int to double: {healthPointsDouble}");
        
        // explicit conversion (Casting)
        int attackPowerAsInt = (int)attackPower;
        Console.WriteLine($"Attack power from float to int: {attackPowerAsInt}");
        
        // using the Convert class
        Console.WriteLine($"Health points from double to int: {Convert.ToInt32(healthPointsDouble)}");

        try // instead of TryParse
        {
            // parsing a string to a double
            Console.WriteLine($"Currency amount from string to double: {double.Parse(currencyAmount)}");
        }
        catch
        {
            Console.WriteLine("Parse from string to double invalid");
        }
        
        
        // safe conversion example
        
        int.TryParse(name, out int nameInt);
        nameInt = - 1;
        Console.WriteLine("Safe int conversion of name: " + nameInt);
    }
}