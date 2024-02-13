using AbstractFactory.FurnitureFactory.Interface;
using AbstractFactory.Products.Chair;
using AbstractFactory.Products.Chair.Interface;
using AbstractFactory.Products.CoffeeTable;
using AbstractFactory.Products.CoffeeTable.Interface;
using AbstractFactory.Products.Sofa;
using AbstractFactory.Products.Sofa.Interface;
using System.Diagnostics;

namespace AbstractFactory.FurnitureFactory
{
	public class ModernFurnitureFactory : IFurnitureFactory
	{
		public IChair CreateChair()
		{
			Debug.WriteLine($"I am {nameof(ModernFurnitureFactory)} and you are in {nameof(CreateChair)} method");
			return new ModernChair();
		}

		public ICoffeeTable CreateCoffeeTable()
		{
			Debug.WriteLine($"I am {nameof(ModernFurnitureFactory)} and you are in {nameof(CreateCoffeeTable)} method");
			return new ModernCoffeeTable();
		}

		public ISofa CreateSofa()
		{
			Debug.WriteLine($"I am {nameof(ModernFurnitureFactory)} and you are in {nameof(CreateSofa)} method");
			return new ModernSofa();
		}
	}
}
