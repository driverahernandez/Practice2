using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Classroom
    {
        private List<Student> Students { get; set; }
        public Classroom() 
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student) => Students.Add(student);

        // remove by name
        public void RemoveStudent(string name)
        {
            foreach (var student in Students)
            {
                if (student.Name == name)
                {
                    Students.Remove(student);
                    break;
                }
                throw new InvalidOperationException("Student with given name was not found.");
            }
        }
        //remove by roll number
        public void RemoveStudent(int rollNumber)
        {
            foreach (var student in Students)
            {
                if (student.RollNumber == rollNumber)
                {
                    Students.Remove(student);
                    break;
                }

                throw new InvalidOperationException("Student with given roll number was not found.");
            }
        }

        public void displayStudentList()
        {
            Console.WriteLine("****All students****");
            foreach (var student in Students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

    }
}
