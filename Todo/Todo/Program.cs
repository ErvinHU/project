using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> tasks = new List<string>();
            int userChoice = 6;

            Console.WriteLine("Welcome to my\nTo-do List app\n--------------\n--------------");


            while (userChoice != 5)
            {
                DisplayMenu();

                string input = Console.ReadLine();
                if (Int16.TryParse(input, out short result))
                {
                    userChoice = result;

                    switch (userChoice)
                    {
                        case 1:
                            Console.Clear();
                            AddTask(tasks);
                            break;
                        case 2:
                            RemoveTask(tasks);
                            break;
                        case 3:
                            ManageTask(tasks);
                            break;
                        case 4:
                            DisplayTasks(tasks);
                            break;
                        case 5:
                            Console.WriteLine("Press any key to exit the program...");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid choice. Please enter a valid number.");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Entered character is not an option, please enter a valid number");
                }
            }
            Console.ReadKey();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("What do you want to do? \n");
            Console.WriteLine("1 Add a task");
            Console.WriteLine("2 Remove a task");
            Console.WriteLine("3 Manage a task");
            Console.WriteLine("4 See my tasks");
            Console.WriteLine("5 Exit the program");
            Console.WriteLine("--------------");
        }
        static void AddTask(List<string> tasks)
        {
            Console.Write("Add task: ");
            tasks.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Task Added succesfully");
        }
        static void RemoveTask(List<string> tasks)
        {
            Console.Clear();
            if (tasks.Count == 0)
            {
                Console.WriteLine("You do not have any tasks!");
                Console.WriteLine("But you can add a task now if you want to!");
                AddTask(tasks);
            }
            else
            {
                Console.WriteLine("Your tasks are the following");
                Console.WriteLine("--------------");
                foreach (string task1 in tasks)
                {
                    Console.WriteLine(task1);
                }
                Console.Write("\nRemove a task : ");
                tasks.Remove(Console.ReadLine());
            }
            Console.Clear();
        }
        static void ManageTask(List<string> tasks)
        {
            Console.Clear();
            Console.WriteLine("Your tasks are the following \n");
            Console.WriteLine("--------------");
            foreach (string task1 in tasks)
            {
                Console.WriteLine(task1);
            }
            Console.Write("\nManaged task : ");
            String selected = Console.ReadLine();
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] == selected)
                {
                    Console.Write("Change to : ");
                    String change = Console.ReadLine();
                    tasks[i] = change;
                }
                else
                {
                    Console.WriteLine($"You do not have a task named {selected}");
                }
                Console.Clear();
            }
        }
        static void DisplayTasks(List<string> tasks)
        {
        Console.Clear();
        Console.WriteLine("Your tasks are the following \n");
        foreach (string task1 in tasks)
            {
                Console.WriteLine(task1);
            }
        Console.WriteLine("\n");
        }

    }
}