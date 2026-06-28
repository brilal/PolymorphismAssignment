using System;

namespace PolymorphismAssignment
{
    // Abstract class that provides a base for Employee
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Abstract method that must be implemented by derived classes
        public abstract void SayName();
    }
}
