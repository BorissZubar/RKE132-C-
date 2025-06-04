using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = @"C:\data";
        string fileName = "shoppingList.txt";
        string filePath = Path.Combine(folderPath, fileName);
        List<string> myShoppingList = new List<string>();

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
            Console.WriteLine($"File {fileName} has been created.");
        }

        myShoppingList = GetItemsFromUser();
        File.WriteAllLines(filePath, myShoppingList);
        ShowItemsFromList(myShoppingList);
    }

    static List<string> GetItemsFromUser()
    {
        List<string> userList = new List<string>();

        while (true)
        {
            Console.WriteLine("Add an item (add) / Exit (exit):");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "add")
            {
                Console.WriteLine("Enter an item:");
                string userItem = Console.ReadLine();
                userList.Add(userItem);
            }
            else if (userChoice.ToLower() == "exit")
            {
                Console.WriteLine("Get out from here!");
                break;
            }
        }

        return userList;
    }

    static void ShowItemsFromList(List<string> someList)
    {
        Console.Clear();

        int listLength = someList.Count;
        Console.WriteLine($"You have added {listLength} items to your pooping list.");

        int i = 1;
        foreach (string item in someList)
        {
            Console.WriteLine($"{i}. {item}");
            i++;
        }
    }
}
