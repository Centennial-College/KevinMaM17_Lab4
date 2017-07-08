namespace Kevin_Ma_Lab04_Ex1
{
    /// <summary>
    /// This class represents a list node whose values are of the type Double.
    /// </summary>
    public class ListNode
    {
        //PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //auto implemented properties
        //type of the data should be double
        public double Data { get; set; }
        //reference to next node in the LinkedList
        public ListNode Next { get; set; }

        //CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //constructor to create ListNode that refers to dataValue and is last node in list
        public ListNode(double dataValue) : this(dataValue, null) { }

        //constructor to create ListNode that refers to dataValue and refers to the next ListNode in the List
        public ListNode(double dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
