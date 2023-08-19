namespace Hometask
{
    internal class Teamcheck
    {
        static void Main(string[] args)
        {
            Car car = new Car(23, "Roadster", "Tesla", 15000);
            Car car1 = new Car(21, "SVJ", "Lamborghini", 10000);
            Car car2 = new Car(20, "M4 Competition", "BMW", 100000);
            car.CalculateTotal();
            car1.CalculateTotal();
            car2.CalculateTotal();
            Console.WriteLine("--------changed--------");
            Car.TaxPercentage = 20;
            car.CalculateTotal();
            car1.CalculateTotal();
            car2.CalculateTotal();
        }
    }
}
