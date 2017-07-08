namespace Kevin_Ma_Lab04_Ex1
{
    /// <summary>
    /// This class represents a list node whose values are of the type Double.
    /// NOTE: this class was later refactored to be generically typed. This is because in Ex3,
    /// the data type requirement changed from Double to String, so it is better to be generically
    /// typed than statically typed as Double only.
    /// </summary>
    public class ListNode<T>
    {
        //PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //auto implemented properties
        //type of the data should be double
        public T Data { get; set; }
        //reference to next node in the LinkedList
        public ListNode<T> Next { get; set; }

        //CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //constructor to create ListNode that refers to dataValue and is last node in list
        public ListNode(T dataValue) : this(dataValue, null) { }

        //constructor to create ListNode that refers to dataValue and refers to the next ListNode in the List
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
