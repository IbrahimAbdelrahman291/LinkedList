using LinkedList;

internal class Program
{
    private static void Main(string[] args)
    {
        CircularDoublyLinkedList l = new CircularDoublyLinkedList();
        int choice,value;
        do 
        {
            showOptions();
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 0:
                    Console.WriteLine("Bye");
                    break;
                case 1:
                    Console.WriteLine("Enter value to add");
                    value = Convert.ToInt32(Console.ReadLine());
                    l.Add(value);
                    break;
                case 2:
                    Console.WriteLine("Enter value to remove");
                    value = Convert.ToInt32(Console.ReadLine());
                    l.Remove(value);
                    break;
                case 3:
                    l.Display();
                    break;
                case 4:
                    Console.WriteLine("Enter value to search");
                    value = Convert.ToInt32(Console.ReadLine());
                    l.Search(value);
                    break;
                default:
                    Console.WriteLine("Invaild option");
                    break;
            }
        } while (choice!=0);
    }
    public static void showOptions() 
    {
        Console.WriteLine("_______________________________");
        Console.WriteLine("1-Add");
        Console.WriteLine("2-Remove");
        Console.WriteLine("3-Display");
        Console.WriteLine("4-Search");
        Console.WriteLine("0-Exit");
        Console.WriteLine("_______________________________");
    }
}