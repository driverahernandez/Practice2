using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Practice2
{
    public class Car : Vehicle
    {
        protected int Seats { get; set; }
        protected Transmission Type { get; set; }
        public Car(string make, string model, int year, int seats, Transmission type) : base(make, model, year)
        {
            Seats = seats;
            Type = type;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Transmission: {Type}");
        }

        public override void StartEngine() => Console.WriteLine("Start Engine of Car.");

    }
    public enum Transmission
    {
        Manual,
        Automatic
    }
}

