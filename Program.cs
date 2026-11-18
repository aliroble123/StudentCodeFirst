using System;
using System.Linq;

namespace StudentCodeFirst
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // Create and save one student.
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "john.smith@example.com"
                };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student database created and student saved.");
                Console.WriteLine();

                // Read students from the database.
                var students = from s in db.Students
                               orderby s.LastName
                               select s;

                Console.WriteLine("Students in the database:");
                foreach (var item in students)
                {
                    Console.WriteLine("{0}: {1} {2} - {3}",
                        item.StudentId, item.FirstName, item.LastName, item.Email);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
