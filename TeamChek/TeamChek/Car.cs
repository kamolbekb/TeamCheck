using System;
namespace Hometask
{
	public class Car
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public string Brand { get; set; }
		public decimal Price { get; set; }
		public static decimal TaxPercentage { get; set; } = 10;
		public Car(int id,string model,string brand,decimal price)
		{
			Id = id;
			Model = model;
			Brand = brand;
			Price = price;
		}
		public void CalculateTotal()
		{
			Console.WriteLine($"Total price of the car including taxes: {Price + ((Price / 100) * TaxPercentage)}");
		}
	}
}

