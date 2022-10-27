namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
                car.Make = "Dodge";
                car.Model = "Challenger";
                car.Year = 2018;

            Console.WriteLine($"The make of the car is {car.Make}, the model is {car.Model}, and the year is {car.Year}");
        }
    }
}
