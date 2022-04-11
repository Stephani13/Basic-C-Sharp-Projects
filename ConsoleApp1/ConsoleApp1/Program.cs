using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.Write("Enter student first name: ");

                string firstName = Console.ReadLine();


                Console.Write("Enter student last name: ");
                string lastName = Console.ReadLine();


                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName

                };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from i in db.Students
                            orderby i.FirstName, i.LastName
                            select i;

                Console.WriteLine("All the students enrolled: ");
                foreach (var students in query)
                {
                    Console.WriteLine(students.FirstName + " " + students.LastName);
                }

                


            }
        }
    }


    public class Student
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

}
