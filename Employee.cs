using System;

namespace PolymorphismAssignment
{
    // Employee inherits from Person AND implements the IQuittable interface.
    public class Employee : Person, IQuittable
    {
        // Property unique to Employee
        public int Id { get; set; }

        // Implementation of the Quit() method required by IQuittable
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit the job.");
        }

        // Implementation of SayName() from the Person abstract class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
