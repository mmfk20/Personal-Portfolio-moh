using System;

namespace PolymorphismProject
{
    public class Employee : IQuittable
    {
        public string Name { get; set; } = "";

        public void Quit()
        {
            Console.WriteLine($"{Name} has quit.");
        }
    }
}
