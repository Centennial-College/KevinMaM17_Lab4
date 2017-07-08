using System;
using Kevin_Ma_Lab04_Ex1;

namespace Kevin_Ma_Lab04_Ex1_Test
{
    /// <summary>
    /// This driver class is used to test the implementation of the user defined Linked List 
    /// created in the Class Library Kevin-Ma_Lab04_Ex1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //create list container
            var linkedList = new List();

            //create data to store in the list
            double num1 = 23.42;
            double num2 = -923.11;
            double num3 = 0.0001;
            double num4 = 92323231;

            //use List insert methods
            Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
            linkedList.Display();
            Console.WriteLine();
            linkedList.InsertAtFront(num1);
            Console.WriteLine($"{num1} inserted at the front of the list.");
            Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
            linkedList.Display();
            linkedList.InsertAtFront(num2);
            Console.WriteLine($"{num2} inserted at the front of the list.");
            Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
            linkedList.Display();
            linkedList.InsertAtBack(num3);
            Console.WriteLine($"{num3} inserted at the back of the list.");
            Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
            linkedList.Display();
            linkedList.InsertAtBack(num4);
            Console.WriteLine($"{num4} inserted at the back of the list.");
            Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
            linkedList.Display();

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            //use List remove methods
            try
            {
                double removedValue = linkedList.RemoveFromFront();
                Console.WriteLine($"{removedValue} removed from the front of the list.");
                Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
                linkedList.Display();

                removedValue = linkedList.RemoveFromFront();
                Console.WriteLine($"{removedValue} removed from the front of the list.");
                Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
                linkedList.Display();

                removedValue = linkedList.RemoveFromBack();
                Console.WriteLine($"{removedValue} removed from the back of the list.");
                Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
                linkedList.Display();

                removedValue = linkedList.RemoveFromBack();
                Console.WriteLine($"{removedValue} removed from the back of the list.");
                Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
                linkedList.Display();
            }
            catch (EmptyListException ex)
            {
                Console.Error.WriteLine($"\n{ex}");
            }

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            //use List Search methods
            try
            {
                Console.WriteLine($"Re-inserting {num1}, {num2}, {num3}, and {num4} back into the list");
                linkedList.InsertAtBack(num1);
                linkedList.InsertAtBack(num2);
                linkedList.InsertAtBack(num3);
                linkedList.InsertAtBack(num4);
                Console.WriteLine($"There are currently {linkedList.Count()} numbers in the list.");
                linkedList.Display();

                Console.WriteLine("---------------------------------------------------------------");

                linkedList.Display();
                Console.WriteLine($"Searching the list for the number: {num3}");
                double queryResult;
                try
                {
                    queryResult = linkedList.Search(num3);
                    Console.WriteLine($"{queryResult} was found in the list!");
                }
                catch (ElementNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine();

                linkedList.Display();
                Console.WriteLine($"Searching the list for the number: 22424.11");
                try
                {
                    queryResult = linkedList.Search(22424.11);
                    Console.WriteLine($"{queryResult} was found in the list!");
                }
                catch (ElementNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (EmptyListException ex)
            {
                Console.Error.WriteLine($"\n{ex}");
            }

            Console.WriteLine($"\nPress enter to continue....");
            Console.ReadLine();
        }
    }
}
