using AbstractFactory.FurnitureFactory;
using AbstractFactory.FurnitureFactory.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// here we instantiate the type of the factory !
ConfigureFurnitureFactory(builder);

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

static void ConfigureFurnitureFactory(WebApplicationBuilder builder)
{
	var isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

	if (isWindows)
	{
		builder.Services.AddTransient<IFurnitureFactory, ModernFurnitureFactory>();
	}
	else
	{
		builder.Services.AddTransient<IFurnitureFactory, VictorianFurnitureFactory>();
	}
}