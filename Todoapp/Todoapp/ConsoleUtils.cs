using System;
using System.Collections.Generic;
using System.Text;

namespace Todoapp
{
    class ConsoleUtils
    {
        public static void DisplayMenu()
        {
            string menu = @"Welcome to my ToDo App Choose an option to continue.
1: List all Items
2: Add a new item
3: Update an item
4: Delete and item
9: Quit the program";
            Console.WriteLine(menu);
        }
        public static  void ProcessInput(UserChoice choice)
        {
            while (choice != UserChoice.Quit)
            {
                switch (choice)
                {
                    case UserChoice.ListItem:

                        break;
                }
            }
        }
        public enum UserChoice
        {
            ListItem,
            AddItem,
            UpdateItem,
            DeleteItem,
            Quit
        }
        public static string PrintMenu()
        {
            Console.WriteLine("Please choose your option to continue.");
            Console.WriteLine("1: Add a new ToDo item");
            Console.WriteLine("2: List all ToDo items");
            Console.WriteLine("3: Update the list");
            Console.WriteLine("4: Delete an Item");
            Console.WriteLine("9: Quit the program");
            string action = Console.ReadLine();
            return action;
        }
        public static int GetItemId()
        {

            Console.WriteLine("Enter the Id of the Item:");
            string UserInput = Console.ReadLine();
            int itemId = int.Parse(UserInput);
            return itemId;
        }

        public static string AskForItemInfo()// use GetItemid() as example
        {
            Console.WriteLine("Enter the info:");
            string userInfo = Console.ReadLine();
            return userInfo;
        }

        public static void PrintToDoItems(List<Todoitem> list)
        {
            foreach (Todoitem item in list)
            {
                Console.WriteLine($"(item.Id) - (item.Description) - (item.Status)");
            }
        }
    }
}   





