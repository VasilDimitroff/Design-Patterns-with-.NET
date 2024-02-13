using AbstractFactory.Products.Chair.Interface;

namespace AbstractFactory.Products.Chair
{
	public class VictorianChair : IChair
	{
		public string GetColor()
		{
			return $"I am {nameof(VictorianChair)} chair and you are in {nameof(GetColor)} method";
		}

		public string SitOn()
		{
			return $"I am {nameof(VictorianChair)} chair and you are in {nameof(SitOn)} method";
		}
	}
}
