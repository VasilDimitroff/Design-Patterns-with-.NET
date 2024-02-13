using AbstractFactory.Products.Sofa.Interface;

namespace AbstractFactory.Products.Sofa
{
	public class VictorianSofa : ISofa
	{
		public string GetCapacity()
		{
			return $"I am {nameof(VictorianSofa)} and you are in {nameof(GetCapacity)} method";
		}

		public string GetSeatedPeople()
		{
			return $"I am {nameof(VictorianSofa)} and you are in {nameof(GetSeatedPeople)} method";
		}
	}
}
