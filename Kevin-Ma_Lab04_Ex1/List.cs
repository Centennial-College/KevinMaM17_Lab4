using System;

namespace Kevin_Ma_Lab04_Ex1
{
    /// <summary>
    /// This class represents a Linked List whose nodes contain Double values.
    /// </summary>
    public class List
    {
        //FIELDS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private ListNode firstNode;
        private ListNode lastNode;
        private string name; //used in displaying the List

        //CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //construct empty List with specified name
        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }
        //construct empty list with "list" as its default name
        public List() : this("list") { }

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// Inserts object at front of the List.
        /// If list is empty, firstNode and lastNode will refer to the inserted node.
        /// Otherwise, firstNode refers to the newly inserted node, and the new node points to the 
        /// previous firstNode.
        /// </summary>
        /// <param name="insertValue">the double value to be inserted into the list</param>
        public void InsertAtFront(double insertValue)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertValue);
            }
            else
            {
                firstNode = new ListNode(insertValue, firstNode);
            }
        }

        /// <summary>
        /// Inserts object at end of list. If list is empty, first and last node will refer to same obj.
        /// Otherwise, last node's next property refers to the new node.
        /// </summary>
        /// <param name="insertValue">the double value to be inserted into the list</param>
        public void InsertAtBack(double insertValue)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertValue);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertValue);
            }
        }

        /// <summary>
        /// Removes the first node from the List.
        /// </summary>
        /// <returns>The double value contained in the removed list node.</returns>
        public double RemoveFromFront()
        {
            if (IsEmpty())
            {
                //throw exception, can't remove from an empty list
                throw new EmptyListException(name);
            }

            //retrieve the data before removing the node
            double removedValue = firstNode.Data;

            //if only one item in list, list becomes empty after removal
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
                //once there is no reference to an object, C#'s CLR will remove it (garbage collection)
            }

            return removedValue;
        }

        /// <summary>
        /// Removes the last node from the backc of the List.
        /// </summary>
        /// <returns>The double value contained in the removed list node.</returns>
        public double RemoveFromBack()
        {
            if (IsEmpty())
            {
                //throw exception, can't remove from an empty list
                throw new EmptyListException(name);
            }

            //retrieve the data before removing the node
            double removedValue = lastNode.Data;

            //if only one item in list, list becomes empty after removal
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                //need to find lastNode's previous node
                //loop through all nodes because this is not a doubly-linked list (no previousNode)
                ListNode current = firstNode;

                while (current.Next != lastNode)
                {
                    //move to next node
                    current = current.Next;
                }

                //current becomes lastNode
                lastNode = current;
                current.Next = null;
            }

            return removedValue;
        }

        /// <summary>
        /// Searches the linked list for a list node containing the param double value.
        /// </summary>
        /// <param name="value">The double value we are searching for in the linked list.</param>
        /// <returns>
        ///     If the element is found in the linked list, a reference to the list node containing the 
        ///     param value as its data.
        ///     
        ///     If not found, returns reference to null.
        /// </returns>
        public ListNode Search(double value)
        {
            if (IsEmpty())
            {
                //cannot search an empty list
                throw new EmptyListException(name);
            }
            else
            {
                //linked lists by nature are inefficient for searching.
                //we need to iterate through all the nodes in the list to search for an element
                ListNode current = firstNode;

                while (current != null)
                {
                    //if found matching element, end loop and return found node
                    if (current.Data == value)
                        return current;
                }
            }

            //no node found
            return null;
        }

        /// <summary>
        /// Counts the number of elements in the linked list
        /// </summary>
        /// <returns>an integer which represents the number of elements in the linked list</returns>
        public int Count()
        {
            if (IsEmpty())
                return 0;

            int numberOfNodesInList = 0;
            ListNode current = firstNode;

            while (current != null)
            {
                numberOfNodesInList++;
                current = current.Next;
            }

            return numberOfNodesInList;
        }

        /// <summary>
        /// Used to check whether the list is empty or not.
        /// </summary>
        /// <returns>
        ///     true    if the list is empty
        ///     false   otherwise
        /// </returns>
        public bool IsEmpty()
        {
            //if firstNode == null that means there is no node in the list
            return firstNode == null;
        }

        /// <summary>
        /// Outputs the List's contents to the console
        /// </summary>
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} contains: ");

                //iterate through all nodes in the list to display them
                ListNode current = firstNode;

                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
    }
}
