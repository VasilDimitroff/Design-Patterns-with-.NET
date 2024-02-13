using AbstractFactory.Products.CoffeeTable.Interface;

namespace AbstractFactory.Products.CoffeeTable
{
	public class ModernCoffeeTable : ICoffeeTable
	{
		public string Empty()
		{
			return $"I am {nameof(ModernCoffeeTable)} and you are in {nameof(Empty)} method";
		}

		public string ServeCoffee()
		{
			return $"I am {nameof(ModernCoffeeTable)} and you are in {nameof(ServeCoffee)} method";
		}
	}
}
