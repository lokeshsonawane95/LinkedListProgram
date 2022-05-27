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
                Console.WriteLine("7. Search Linked List to find node with value 30");
                Console.WriteLine("8. Insert 40 after 30 in list of sequence 56->30->70");
                Console.WriteLine("9. Delete 40 from the list and show size of the list");
                Console.WriteLine("10. Ordered linked list in ascending order of data entered in following sequence 56, 30, 40 and 70");
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
                    case 7:
                        LinkedList list7 = new LinkedList();
                        list7.Append(56);
                        list7.Append(30);
                        list7.Append(70);
                        list7.Display();
                        list7.Search(30);
                        break;
                    case 8:
                        LinkedList list8 = new LinkedList();
                        list8.Append(56);
                        list8.Append(30);
                        list8.Append(70);
                        list8.Display();
                        list8.AddAfter(30, 40);
                        Console.Write("After insertion ");
                        list8.Display();
                        break;
                    case 9:
                        LinkedList list9 = new LinkedList();
                        list9.Append(56);
                        list9.Append(30);
                        list9.Append(40);
                        list9.Append(70);
                        list9.Display();
                        list9.DeleteValue(40);
                        Console.Write("Final sequence of ");
                        list9.Display();
                        list9.Size();
                        break;
                    case 10:
                        LinkedList list10 = new LinkedList();
                        list10.OrderedList(56);
                        list10.OrderedList(30);
                        list10.OrderedList(40);
                        list10.OrderedList(70);
                        Console.Write("Ordered sequence of ");
                        list10.Display();
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}