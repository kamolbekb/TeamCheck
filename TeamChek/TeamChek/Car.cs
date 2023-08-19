using System;
namespace Hometask
{
	public class Car
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public string Brand { get; set; }
		public decimal Price { get; set; }
		public static decimal TaxPercentage { get; set; } = 10; //this is a default value of a varible, if costumer will not change the value it will increase the final price depending to the default value)
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
