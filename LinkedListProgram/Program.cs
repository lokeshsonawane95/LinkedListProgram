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
                Console.WriteLine("3. Create Linked List by Appending 30 and 56 to 70");
                Console.WriteLine("4. Insert 30 between 56 and 70");
                Console.WriteLine("5. Delete first element in list of sequence 56->30->70");
                Console.WriteLine("6. Delete last element in list of sequence 56->30->70");
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
                    case 3:
                        LinkedList list3 = new LinkedList();
                        list3.Append(56);
                        list3.Append(30);
                        list3.Append(70);
                        list3.Display();
                        break;
                    case 4:
                        LinkedList list4 = new LinkedList();
                        list4.Append(56);
                        list4.Append(70);
                        list4.Display();
                        list4.AddAtPosition(2, 30);
                        Console.Write("After insertion ");
                        list4.Display();
                        break;
                    case 5:
                        LinkedList list5 = new LinkedList();
                        list5.Append(56);
                        list5.Append(30);
                        list5.Append(70);
                        list5.Display();
                        list5.Pop();
                        Console.Write("After deleting first node ");
                        list5.Display();
                        break;
                    case 6:
                        LinkedList list6 = new LinkedList();
                        list6.Append(56);
                        list6.Append(30);
                        list6.Append(70);
                        list6.Display();
                        list6.PopLast();
                        Console.Write("After deleting last node ");
                        list6.Display();
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}