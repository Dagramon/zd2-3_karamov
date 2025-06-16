using System;

public class Product
{

	public decimal price { get; set; }
	public string name { get; set; }

	public Product(string Name, decimal Price) //Конструктор
	{
		this.name = Name;
		this.price = Price;
	}

	public string GetInfo() //Получение информации о продукте
	{
		return $"{name}| Цена: {price}";
	}
}
