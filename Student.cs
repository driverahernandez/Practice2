using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Student
    {
        public string Name { get; private set; }
        public int RollNumber { get; private set; }
        private double Grade { get; set; }
        private List<double> Marks { get; set; }

        public Student(string name, int rollNumber)
        {
            Name = name;
            RollNumber = rollNumber;
            Marks = new List<double>();
        }       

        public void DisplayDetails()
        {
            Console.WriteLine("**********");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine("Grade: {0:0.00}", Grade);
            Console.WriteLine("**********");
        }
        public void inputMarks()
        {
            while (true)
            {
                Console.WriteLine($"Input {Name}\'s Marks.");
                Console.WriteLine("Type in the number or press enter to finish:");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                Marks.Add(Convert.ToDouble(input));
            }
        }
        public void CalculateGrade()
        {
            if (Marks.Count > 0)
                Grade = Marks.Average();
            else
                Grade = 0.0;
        }
        public override string ToString() => $"Name: {Name}\nRoll Number: {RollNumber}";

    }
}
