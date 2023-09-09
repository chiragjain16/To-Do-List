using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.cj
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Welcome to the To Do List Program");
                List<string> tasklist = new List<string>();
                string option = "";

                while (option != "e")
                {
                    Console.WriteLine("What would like to do");
                    Console.WriteLine("Enter 1 to add a task to the list");
                    Console.WriteLine("Enter 2 to remove a task from the list");
                    Console.WriteLine("Enter 3 to view the list");
                    Console.WriteLine("Enter e to exit the program");

                    option = Console.ReadLine();

                    if (option == "1")
                    {
                        Console.WriteLine("Please enter the name of the task to add to the list");
                        string task = Console.ReadLine();
                        tasklist.Add(task);
                        Console.WriteLine("Task added to the list successfully");
                    }
                    else if (option == "2")
                    {
                        for (int i = 0; i < tasklist.Count; i++)
                        {
                            Console.WriteLine(i + " : " + tasklist[i]);
                        }
                        Console.WriteLine("Please enter the number of the task to remove from the list");
                        int taskNumber = Convert.ToInt32(Console.ReadLine());
                        tasklist.RemoveAt(taskNumber);
                        Console.WriteLine("Task Removed to the list successfully");
                    }
                    else if (option == "3")
                    {
                        Console.WriteLine("Current tasks in the list ");
                        for (int i = 0; i < tasklist.Count; i++)
                        {

                            Console.WriteLine(tasklist[i]);
                        }
                    }

                    else if (option == "e")
                    {
                        Console.WriteLine("Exiting program");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option, Please tr again");
                    }
                }
                Console.WriteLine("Thank you for using the program");
            }
        }
    }



