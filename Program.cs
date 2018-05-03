using System;

namespace carClass2
{
    class Car
    {
        public string Make {get; set;}
        public string Color {get; set;}
        public string Gearbox {get; set;}

        public string DescribeCar() {
            return $"This car is a {Make} and is {Color}, the transmission is a {Gearbox}.";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter new car below");
            Console.Write("Make: "); 
            var make = Console.ReadLine();
            Console.Write("Color: ");
            var color = Console.ReadLine();
            Console.Write("Gearbox; ");
            var gearbox = Console.ReadLine();

            Console.WriteLine();

            var car = new Car(); 
            car.Make = make; 
            car.Color = color; 
            car.Gearbox = gearbox; 
            Console.WriteLine(car.DescribeCar()); 

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
