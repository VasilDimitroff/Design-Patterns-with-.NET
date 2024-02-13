using AbstractFactory.FurnitureFactory.Interface;
using AbstractFactory.Products.Chair.Interface;
using AbstractFactory.Products.CoffeeTable.Interface;
using AbstractFactory.Products.Sofa.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FurnitureController : ControllerBase
	{
		private readonly IFurnitureFactory furnitureFactory;

		public FurnitureController(IFurnitureFactory furnitureFactory)
		{
			this.furnitureFactory = furnitureFactory;
		}

		[HttpGet]
		[Route("chair")]
		public ActionResult<IChair> GetChair()
		{
			var chair = this.furnitureFactory.CreateChair();

			return Ok(new
			{
				GetColor = chair.GetColor(),
				SitOn = chair.SitOn()
			});
		}

		[HttpGet]
		[Route("coffee-table")]
		public ActionResult<ICoffeeTable> GetCoffeeTable()
		{
			var coffeeTable = this.furnitureFactory.CreateCoffeeTable();

			return Ok(new
			{
				ServeCoffee = coffeeTable.ServeCoffee(),
				Empty = coffeeTable.Empty()
			});
		}

		[HttpGet]
		[Route("sofa")]
		public ActionResult<ISofa> GetSofa()
		{
			var sofa = this.furnitureFactory.CreateSofa();

			return Ok(new
			{
				GetCapacity = sofa.GetCapacity(),
				GetSeatedPeople = sofa.GetSeatedPeople()
			});
		}
	}
}
