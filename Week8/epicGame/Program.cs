using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = @"C:\data";
        string heroFile = "heroes.txt";
        string villainFile = "villains.txt";

        string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
        string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
        string[] weapon = { "magic glock19", "guitar", "anchovy", "plastic sword", "uranium brick" };

        string hero = GetRandomValueFromArray(heroes);
        string heroWeapon = GetRandomValueFromArray(weapon);
        int heroHP = GetCharacterHP(hero);
        int heroStrikeStrength = heroHP;

        Console.WriteLine($"Today {hero} ({heroHP} HP) with {heroWeapon} saves the day!");

        string villain = GetRandomValueFromArray(villains);
        string villainWeapon = GetRandomValueFromArray(weapon);
        int villainHP = GetCharacterHP(villain);
        int villainStrikeStrength = villainHP;

        Console.WriteLine($"Today {villain} ({villainHP} HP) with {villainWeapon} tries to take over the world!");

        while (heroHP > 0 && villainHP > 0)
        {
            heroHP -= Hit(villain, villainStrikeStrength);
            villainHP -= Hit(hero, heroStrikeStrength);
        }

        Console.WriteLine($"Hero {hero} HP: {heroHP}");
        Console.WriteLine($"Villain {villain} HP: {villainHP}");

        if (heroHP > 0)
        {
            Console.WriteLine("Gero wins!");
        }
        else if (villainHP > 0)
        {
            Console.WriteLine("Drark side wins!");
        }
        else
        {
            Console.WriteLine("Draw!");
        }
    }

    static string GetRandomValueFromArray(string[] someArray)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);
        string randomStringFromArray = someArray[randomIndex];
        return randomStringFromArray;
    }

    static int GetCharacterHP(string characterName)
    {
        if (characterName.Length < 10)
        {
            return 10;
        }
        else
        {
            return characterName.Length;
        }
    }

    static int Hit(string characterName, int characterHP)
    {
        Random rnd = new Random();
        int strike = rnd.Next(0, characterHP);

        if (strike == 0)
        {
            Console.WriteLine($"{characterName} missed the bastard!");
        }
        else if (strike == characterHP - 1)
        {
            Console.WriteLine($"{characterName} made a critical hit!");
        }
        else
        {
            Console.WriteLine($"{characterName} hit {strike}!");
        }

        return strike;
    }
}
