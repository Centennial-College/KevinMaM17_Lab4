using Kevin_Ma_Lab04_Ex1;

namespace Kevin_Ma_Lab04_Ex3
{
    /// <summary>
    /// This class represents a Queue Data Structure which maintains a queue of elements of type string.
    /// It also inerhits from the user defined List class which is an implementation of a Linked List 
    /// data structure.
    /// </summary>
    public class QueueInheritance : List<string>
    {
        //CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //pass name "queue" to List constructor
        public QueueInheritance() : base("queue") { }

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void Enqueue(string dataValue)
        {
            InsertAtBack(dataValue);
        }

        public string Dequeue()
        {
            return (string)RemoveFromFront();
        }
    }
}
