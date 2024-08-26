namespace Practice2
{
    public class Motorcycle : Vehicle
    {
        protected string Color { get; set; }
        public Motorcycle(string make, string model, int year, string color) : base(make, model, year)
        {
            Color = color;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Color: {Color}");
        }

        public override void StartEngine() => Console.WriteLine("Start Engine of Motorcycle.");

    }
}

