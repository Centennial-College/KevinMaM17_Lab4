using System;

namespace Kevin_Ma_Lab04_Ex1
{
    public class ElementNotFoundException : Exception
    {
        //CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //     Initializes a new instance of the System.Exception class with a specified error
        //     message. Calls base class constructor.
        public ElementNotFoundException(string name) : base($"The element could not be found in the {name}.") { }

        //     Initializes a new instance of the System.Exception class with a specified error
        //     message and a reference to the inner exception that is the cause of this exception.
        //     Calls base class constructor.
        public ElementNotFoundException(string exception, Exception inner) : base(exception, inner) { }
    }
}
