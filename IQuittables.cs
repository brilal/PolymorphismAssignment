using System;

namespace PolymorphismAssignment
{
    // This interface defines a contract that any class implementing it
    // MUST include a Quit() method.
    public interface IQuittable
    {
        void Quit();
    }
}
