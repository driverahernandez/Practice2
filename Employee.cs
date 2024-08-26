using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Employee : IWorkable
    {

        private string Name { get; set; }
        private int EmployeeID { get; set; }
        private double Salary { get; set; }
        public Employee(string name, int employeeID, double salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }

        public virtual void Work() =>
            Console.WriteLine("Employee is working.");

        public virtual void TakeBreak() =>
            Console.WriteLine("Employee is taking a break.");
    }


    public class Manager : Employee
    {
        private int TeamSize { get; set; }
        public Manager(string name, int employeeID, double salary, int teamSize) : base(name, employeeID, salary)
        {
            TeamSize = teamSize;
        }

        public override void Work()=>
            Console.WriteLine("Manager is working.");

        public override void TakeBreak()=>
            Console.WriteLine("Manager is taking a break.");
        
    }
    public class Developer : Employee
    {
        private string GitHubUsername {  get; set; }
        public Developer(string name, int employeeID, double salary, string gitHubUsername) : base(name, employeeID, salary)
        {
            GitHubUsername = gitHubUsername;    
        }

        public override void Work()=>
            Console.WriteLine("Developer is working.");
        

        public override void TakeBreak()=>
            Console.WriteLine("Developer is taking a break.");
        
    }

}
