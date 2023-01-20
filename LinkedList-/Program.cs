namespace LinkedList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Practice Problems!!!");
            Console.WriteLine("-------------LinkedList Operations-------------");
            Console.WriteLine("1.Create simple Linked List of 56, 30 and 70 ");
            Console.WriteLine("2. Create Linked List by Adding 30 and 56 to 70");
            Console.WriteLine("3. Create Linked List by Appending 30 and 56 to 70");
            Console.WriteLine("4. Insert 30 between 56 and 70");
            Console.WriteLine("5. Delete first element in list of sequence 56->30->70");
            Console.WriteLine("6. Delete last element in list of sequence 56->30->70");
            Console.WriteLine("7. Search Linked List to find node with value 30");
            Console.WriteLine("8. Insert 40 after 30 in list of sequence 56->30->70");
            Console.WriteLine("9. Delete 40 from the list and show size of the list");
            Console.WriteLine("10. Ordered linked list in ascending order ");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter the option : ");
            int num = Convert.ToInt32(Console.ReadLine());
            LinkedList linkedList = new LinkedList();
            switch (num)
            {
                case 1:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    break;
                case 2:
                    linkedList.Add(70);
                    linkedList.Add(30);
                    linkedList.Add(56);
                    linkedList.Display();
                    break;
                case 3:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    break;
                case 4:
                    linkedList.Append(56);
                    linkedList.Append(70);
                    linkedList.Display();
                    linkedList.AddAtPosition(2, 30);
                    Console.Write("After insertion ");
                    linkedList.Display();
                    break;
                case 5:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    linkedList.Pop();
                    Console.Write("After deleting first node ");
                    linkedList.Display();
                    break;
                case 6:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    linkedList.PopLast();
                    Console.Write("After deleting last node ");
                    linkedList.Display();
                    break;
                case 7:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    linkedList.Search(30);
                    break;
                case 8:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    linkedList.AddAfter(30, 40);
                    Console.Write("After insertion ");
                    linkedList.Display();
                    break;
                case 9:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(40);
                    linkedList.Append(70);
                    linkedList.Display();
                    linkedList.DeleteValue(40);
                    Console.Write("Final sequence of ");
                    linkedList.Display();
                    linkedList.Size();
                    break;
                case 10:
                    linkedList.OrderedList(56);
                    linkedList.OrderedList(30);
                    linkedList.OrderedList(40);
                    linkedList.OrderedList(70);
                    Console.Write("Ordered sequence of ");
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;

            }
        }
    }
}