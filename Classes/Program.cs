namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car coolCar = new Car();
            coolCar.Make = "Jeep";
            coolCar.Model = "Grand Cherokee";
            coolCar.Year = 2011;

            Console.WriteLine($"Make:{coolCar.Make} Model:{coolCar.Model} Year:{coolCar.Year}");
        }
    }
}
