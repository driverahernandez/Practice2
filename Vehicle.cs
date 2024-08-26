using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Practice2
{
    public class Vehicle
    {
        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }
        
        public Vehicle(string make, string model, int year) 
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("********");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }

        public virtual void StartEngine() => Console.WriteLine("Start Engine of Vehicle.");
    }
}
