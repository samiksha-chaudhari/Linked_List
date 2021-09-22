using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList list = new LinkedList();
            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {
                Console.WriteLine("1:Add  2:Print 3:Insert at position  4:Exit");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        list.Add(56);
                       // list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.Display();
                        break;
                    case 3:
                        list.InsertAtPosition(2, 30);
                        break;

                    default:
                        Console.WriteLine("End");//default condition
                        defcount++;
                        break;
                }
            }
        }
    }
}
