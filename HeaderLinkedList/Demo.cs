using System;

namespace HeaderLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            HeaderLinkedList list = new HeaderLinkedList();
            list.CreateList();

            while (true)
            {

                Console.WriteLine("1.Display List ");
                Console.WriteLine("2.insert a node at the end ");
                Console.WriteLine("3.Insert a new node before a node ");
                Console.WriteLine("4.Insert at a given position ");
                Console.WriteLine("5.Delete a node ");
                

                Console.Write(" enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 8)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        Console.Write("enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 3:
                        Console.Write("enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 4:
                        Console.Write("enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element position at which to insert");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;
                    case 5:
                        Console.Write("enter the element to be deleted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    

                }
            }
        }
    }
}
