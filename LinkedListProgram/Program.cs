using System;
namespace LinkedListProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to Linked List program");
            int choice;
            do
            {
                Console.WriteLine("\n1. Create simple Linked List of 56, 30 and 70");
                Console.WriteLine("2. Create Linked List by Adding 30 and 56 to 70");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LinkedList list = new LinkedList();
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        break;
                    case 2:
                        LinkedList list2 = new LinkedList();
                        list2.Add(70);
                        list2.Add(30);
                        list2.Add(56);
                        list2.Display();
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}