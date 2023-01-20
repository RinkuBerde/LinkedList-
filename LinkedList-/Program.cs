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
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;

            }
        }
    }
}