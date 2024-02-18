using Facade.Image.ImageUploaderFacade;
using Facade.Image.ImageUploaderFacade.Interface;

namespace Facade
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllers();

			builder.Services.AddTransient<IImageUploaderFacade, ImageUploaderFacade>();

			var app = builder.Build();

			app.UseHttpsRedirection();
			app.MapControllers();

			app.Run();
		}
	}
}
