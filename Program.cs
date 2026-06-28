using System;

namespace PolymorphismAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and set its properties
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
                Id = 1
            };

            // Call the SayName() method from the Person class
            employee.SayName();

            // POLYMORPHISM:
            // Create an object of type IQuittable and assign the Employee object to it.
            IQuittable quitter = employee;

            // Call the Quit() method using the interface reference
            quitter.Quit();

            // End of program
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
