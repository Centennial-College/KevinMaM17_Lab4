using System;
using Kevin_Ma_Lab04_Ex2;
using Kevin_Ma_Lab04_Ex1;

namespace Kevin_Ma_Lab04_Ex2_Test
{
    /// <summary>
    /// This driver class is used to test the implementation of the user defined Stack
    /// created in the Class Library Kevin-Ma_Lab04_Ex2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //ENVIRONMENT SETUP++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //create stack container
            StackInheritance stack = new StackInheritance();

            //create data values to be added to the stack
            double num1 = 23.42;
            double num2 = -923.11;
            double num3 = 0.0001;
            double num4 = 92323231;

            //TESTING PUSH+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("PUSHING items onto the stack!");
            Console.WriteLine("---------------------------------------------------------------");
            try
            {
                Console.WriteLine($"PUSHING {num1} onto the stack.");
                stack.Push(num1);
                Console.WriteLine($"Currently, the top item in the stack is {stack.Peek()}");
                Console.WriteLine("Using List's Display method to see entire contents of the stack:");
                stack.Display();

                Console.WriteLine($"PUSHING {num2} onto the stack.");
                stack.Push(num2);
                Console.WriteLine($"Currently, the top item in the stack is {stack.Peek()}");
                Console.WriteLine("Using List's Display method to see entire contents of the stack:");
                stack.Display();

                Console.WriteLine($"PUSHING {num3} onto the stack.");
                stack.Push(num3);
                Console.WriteLine($"Currently, the top item in the stack is {stack.Peek()}");
                Console.WriteLine("Using List's Display method to see entire contents of the stack:");
                stack.Display();

                Console.WriteLine($"PUSHING {num4} onto the stack.");
                stack.Push(num4);
                Console.WriteLine($"Currently, the top item in the stack is {stack.Peek()}");
                Console.WriteLine("Using List's Display method to see entire contents of the stack:");
                stack.Display();
            }
            catch (EmptyListException e)
            {
                Console.WriteLine(e.Message);
            }


            //TESTING POP++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("POPPING items from the stack!");
            Console.WriteLine("---------------------------------------------------------------");
            try
            {
                Console.WriteLine($"POPPING {stack.Pop()} from the stack.");
                Console.WriteLine($"Currently, the top item in the stack is {stack.Peek()}");
                Console.WriteLine("Using List's Display method to see entire contents of the stack:");
                stack.Display();

                Console.WriteLine($"POPPING {stack.Pop()} from the stack.");
                Console.WriteLine($"Currently, the top item in the stack is {stack.Peek()}");
                Console.WriteLine("Using List's Display method to see entire contents of the stack:");
                stack.Display();

                Console.WriteLine($"POPPING {stack.Pop()} from the stack.");
                Console.WriteLine($"Currently, the top item in the stack is {stack.Peek()}");
                Console.WriteLine("Using List's Display method to see entire contents of the stack:");
                stack.Display();

                Console.WriteLine($"POPPING {stack.Pop()} from the stack.");
                Console.WriteLine($"Currently, the top item in the stack is {stack.Peek()}");
                Console.WriteLine("Using List's Display method to see entire contents of the stack:");
                stack.Display();
            }
            catch (EmptyListException e)
            {
                Console.WriteLine(e.Message);
            }

            //TESTING PEEK+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("NOTE: Peek was used throughout this program to look at the top of the stack.");
        }
    }
}
