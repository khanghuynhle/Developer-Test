using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using BasketHandler.Models;
using BasketHandler.Property;

namespace BasketHandler
{
	public class Program
	{
		static void Main(string[] args)
		{
			var services = ConfigureServices();

			var serviceProvider = services.BuildServiceProvider();

			// calls the Run method in App, which is replacing Main
			serviceProvider.GetService<App>().Run();
		}
		private static IServiceCollection ConfigureServices()
		{
			IServiceCollection services = new ServiceCollection();

			var config = LoadConfiguration();
			services.AddSingleton(config);

			//add services to run the application:
			services.AddTransient<ICostCalculation, CostCalculation>();
			services.AddTransient<IDefineDiscountCodes, DefineDiscountCodes>();
			services.AddTransient<IDefineItems, DefineItems>();
			services.AddTransient<IDisplayingCostHandler, DisplayingCostHandler>();
			services.AddTransient<IDisplayingItems, DisplayingItems>();
			services.AddTransient<IUpdateBasket, UpdateBasket>();
			services.AddTransient<IInitialiser, Initialiser>();

			services.AddSingleton<DiscountCode>();
			services.AddSingleton<ItemsInBasket>();
			services.AddSingleton<Item>();

			services.AddTransient<App>();

			return services;

		}

		public static IConfiguration LoadConfiguration()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

			return builder.Build();
		}
	}
}
