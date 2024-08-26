namespace Practice2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ClassesExercise();

            //AssociationBetweenClasses();

            //Inheritance();

            //Polymorphism();

            //Interfaces1();

            //Interfaces2();

        }

        private static void Interfaces2()
        {
            //Create a base class Employee with properties like Name,
            //EmployeeID, and Salary. Derive two classes Manager and
            //Developer from Employee, each with additional properties
            //specific to them. Implement an interface IWorkable with
            //methods Work() and TakeBreak(). Implement this interface
            //in both Manager and Developer classes. Demonstrate polymorphism
            //by creating a list of Employee objects and calling the Work()
            //method on each object.

            var employees = new List<Employee>();
            employees.Add(new Manager("Alice", 12345, 30.000, 5));
            employees.Add(new Developer("Ben", 98765, 12.000, "bensgithub"));
            foreach (var employee in employees)
            {
                employee.Work();
            }
        }

        private static void Interfaces1()
        {
            // Define an interface IPlayable with methods Play() and Pause().
            // Implement this interface in two classes MusicPlayer and
            // VideoPlayer. Demonstrate the use of the interface by creating
            // objects of both classes and calling the methods.

            var musicPlayer = new MusicPlayer();
            musicPlayer.Play();
            musicPlayer.Pause();

            var videoPlayer = new VideoPlayer();
            videoPlayer.Play();
            videoPlayer.Pause();
        }

        private static void Polymorphism()
        {

            // Extend the previous exercise by adding a method StartEngine()
            // in the Vehicle class. Override this method in the Car and
            // Motorcycle classes to provide specific implementations.
            // Create a list of Vehicle objects and demonstrate polymorphism
            // by calling StartEngine() on each object.

            var vehicles = new List<Vehicle>();
            vehicles.Add(new Car("Volkswagen", "Virtus", 2019, 4, Transmission.Manual));
            vehicles.Add(new Motorcycle("Massimo Motor", "Warrior200", 2018, "Red"));
            foreach (var vehicle in vehicles)
            {
                vehicle.StartEngine();
            }
        }

        private static void Inheritance()
        {
            //Create a base class Vehicle with properties like Make, Model,
            //and Year. Derive two classes Car and Motorcycle from Vehicle,
            //each with additional properties specific to them.Implement
            //methods to display details of each vehicle.


            var car = new Car("Volkswagen", "Virtus", 2019, 4, Transmission.Manual);
            var motorcycle = new Motorcycle("Massimo Motor", "Warrior200", 2018, "Red");
            car.DisplayDetails();
            motorcycle.DisplayDetails();
        }

        private static void AssociationBetweenClasses()
        {
            //Create a Library class that contains a list of Book objects.
            //Implement methods to add a book, remove a book, and list all
            //books in the library.

            var library = new Library();
            library.displayBooksList();

            library.AddBook(new Book("Dracula", "B. Stoker", 9798721052927));
            library.AddBook(new Book("Frankenstein", "M. Shelley", 9780143131847));
            library.AddBook(new Book("Picture of Dorian Gray", "O. Wilde", 9780141439570));
            library.displayBooksList();
            
            library.RemoveBook("Dracula");
            library.RemoveBook(9780141439570);
            library.displayBooksList();
        }

        private static void ClassesExercise()
        {
            //Create a Student class with properties like Name, RollNumber,
            //and Grade. Implement methods to display student details and
            //calculate the grade based on marks. Create a Classroom class
            //that contains a list of Student objects and methods to add,
            //remove, and list students.

            Console.WriteLine("----Single Student----\n");
            var Student = new Student("Zoe", 7890);
            Student.DisplayDetails();
            Student.inputMarks();
            Student.CalculateGrade();
            Student.DisplayDetails();

            Console.WriteLine("\n------Classroom------\n");

            var classroom = new Classroom();
            classroom.AddStudent(new Student("Alice", 1234));
            classroom.AddStudent(new Student("Ben", 2345));
            classroom.AddStudent(new Student("Chris", 3456));
            classroom.AddStudent(new Student("Daisy", 4567));
            classroom.AddStudent(new Student("Emily", 5678));
            classroom.RemoveStudent("Chris");
            classroom.RemoveStudent(5678);
            classroom.displayStudentList();
        }
    }
}
