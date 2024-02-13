using AbstractFactory.Products.Chair.Interface;
using AbstractFactory.Products.CoffeeTable.Interface;
using AbstractFactory.Products.Sofa.Interface;

namespace AbstractFactory.FurnitureFactory.Interface
{
	public interface IFurnitureFactory
	{
		IChair CreateChair();
		ISofa CreateSofa();
		ICoffeeTable CreateCoffeeTable();
	}
}
