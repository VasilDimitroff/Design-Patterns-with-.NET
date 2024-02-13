using AbstractFactory.Products.Sofa.Interface;

namespace AbstractFactory.Products.Sofa
{
	public class ModernSofa : ISofa
	{
		public string GetCapacity()
		{
			return $"I am {nameof(ModernSofa)} and you are in {nameof(GetCapacity)} method";
		}

		public string GetSeatedPeople()
		{
			return $"I am {nameof(ModernSofa)} and you are in {nameof(GetSeatedPeople)} method";
		}
	}
}
