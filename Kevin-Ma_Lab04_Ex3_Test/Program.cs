using Kevin_Ma_Lab04_Ex1;
using Kevin_Ma_Lab04_Ex3;
using System;

namespace Kevin_Ma_Lab04_Ex3_Test
{
    /// <summary>
    /// This console application tests the implementation of the user defined
    /// QueueInheritance class created in the Kevin_Ma_Lab04_Ex3 namespace.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //ENVIRONMENT SETUP++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //creating queue container
            QueueInheritance queue = new QueueInheritance();

            //create string objects to be added to the queue
            string name1 = "Stephanie";
            string name2 = "Alicica";
            string name3 = "Irene";
            string name4 = "Theresa";

            //TESTING INSERTIONS+++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("ENQUEUEING items into the queue!");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"ENQUEUEING {name1} into the queue.");
            queue.Enqueue(name1);
            Console.WriteLine("Using List's Display method to see entire contents of the queue:");
            queue.Display();

            Console.WriteLine($"ENQUEUEING {name2} into the queue.");
            queue.Enqueue(name2);
            Console.WriteLine("Using List's Display method to see entire contents of the queue:");
            queue.Display();

            Console.WriteLine($"ENQUEUEING {name3} into the queue.");
            queue.Enqueue(name3);
            Console.WriteLine("Using List's Display method to see entire contents of the queue:");
            queue.Display();

            Console.WriteLine($"ENQUEUEING {name4} into the queue.");
            queue.Enqueue(name4);
            Console.WriteLine("Using List's Display method to see entire contents of the queue:");
            queue.Display();

            //TESTING DELETIONS++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("DEQUEUEING items from the queue!");
            Console.WriteLine("---------------------------------------------------------------");
            string removedName = null;
            try
            {
                while (true)
                {
                    removedName = queue.Dequeue();
                    Console.WriteLine($"{removedName} was dequeued");
                    queue.Display();
                }
            }
            catch (EmptyListException ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }
        }
    }
}
