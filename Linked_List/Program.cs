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
                Console.WriteLine("1:Add  2:Print 3:Insert at position  4:Remove 1st node  5:Remove last node");
                Console.WriteLine("6:Search value  7:Exit");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        Console.WriteLine("how many number want to add: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < a; i++)
                        {
                            Console.WriteLine("Enter number to add: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            list.Add(num);
                        }
                        break;
                    case 2:
                        list.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter number to add: ");
                        int no = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter position number: ");
                        int p = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(p, no);
                        break;
                    case 4:
                        list.RemoveFirstNode();
                        break;
                    case 5:
                        list.RemoveLastNode();
                        break;
                    case 6:
                        Console.WriteLine("Enter number to search: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        list.Search(n);
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
