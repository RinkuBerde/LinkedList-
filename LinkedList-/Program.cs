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
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter the option : ");
            int num = Convert.ToInt32(Console.ReadLine());
            LinkedList linkedListStack = new LinkedList();
            switch (num)
            {
                case 1:
                    linkedListStack.Append(56);
                    linkedListStack.Append(30);
                    linkedListStack.Append(70);
                    linkedListStack.Display();
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;

            }
        }
    }
}