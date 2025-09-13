using System;
using System.Linq;

namespace FinalAssignment
{
    internal class Program
    {
        static void Main()
        {
            using var ctx = new SchoolContext();
            ctx.Database.EnsureCreated();

            if (!ctx.Students.Any())
            {
                var student = new Student
                {
                    FirstName = "Alex",
                    LastName = "Johnson",
                    EnrolledOn = DateTime.UtcNow
                };
                ctx.Students.Add(student);
                ctx.SaveChanges();
                Console.WriteLine($"Added student: {student.StudentId} {student.FirstName} {student.LastName}");
            }
            else
            {
                foreach (var s in ctx.Students.ToList())
                {
                    Console.WriteLine($"{s.StudentId}: {s.FirstName} {s.LastName} (enrolled {s.EnrolledOn})");
                }
            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
