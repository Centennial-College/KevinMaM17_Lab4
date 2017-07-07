using System;

namespace Kevin_Ma_Lab04_Ex1
{
    public class EmptyListException : Exception
    {
        //CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //parameterless - default message calls other EmptyListException constructor
        public EmptyListException() : base("The list is empty") { }

        //     Initializes a new instance of the System.Exception class with a specified error
        //     message. Calls base class constructor.
        public EmptyListException(string name) : base($"The {name} is empty") { }

        //     Initializes a new instance of the System.Exception class with a specified error
        //     message and a reference to the inner exception that is the cause of this exception.
        //     Calls base class constructor.
        public EmptyListException(string exception, Exception inner) : base(exception, inner) { }
    }
}
