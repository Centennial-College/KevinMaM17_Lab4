using Kevin_Ma_Lab04_Ex1;   //to inherit from the User defined Linked List

namespace Kevin_Ma_Lab04_Ex2
{
    /// <summary>
    /// This class represents a Stack Data Structure which maintains a stack of elements of type double.
    /// It also inerhits from the user defined List class which is an implementation of a Linked List 
    /// data structure.
    /// </summary>
    public class StackInheritance : List
    {
        //CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //pass name "stack" to base class, List's constructor
        public StackInheritance() : base("stack") { }

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// Pushes a double value to the front of the Stack.
        /// </summary>
        /// <param name="dataValue">the double value to be pushed onto the stack</param>
        public void Push(double dataValue)
        {
            InsertAtFront(dataValue);
        }

        /// <summary>
        /// Removes item from top of stack by removing item at front of linked list
        /// </summary>
        /// <returns>The double data value contained in the first item of the stack</returns>
        public double Pop()
        {
            return (double)RemoveFromFront();
        }

        /// <summary>
        /// Returns the double data value at the top of the Stack without removing it.
        /// Similar to Pop() but does not modify the stack.
        /// </summary>
        /// <returns>The double data value at the top of the stack.</returns>
        public double Peek()
        {
            if (IsEmpty())
            {
                //cannot peek an empty stack
                throw new EmptyListException("stack");
            }
            else
            {
                //since we do not have access to the private fields of the base linked list implementation
                //we need to have a workaround where we can see the top value while giving off the 
                //impression to the client that the stack was not modified
                var topNode = Pop();
                Push(topNode);
                return topNode;
            }
        }
    }
}
