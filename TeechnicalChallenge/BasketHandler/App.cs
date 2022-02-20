using BasketHandler.Models;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace BasketHandler
{
	public class App
	{
		private readonly IConfiguration _config;

		private readonly IInitialiser _initialiser;

		public App (IInitialiser initialiser, IConfiguration config)
		{
			_config = config;
			_initialiser = initialiser;
		}
		public void Run()
		{
			//var logDirectory = _config.GetValue<string>("Runtime:LogOutputDirectory");
			//using serilog for logging information
			var log = new LoggerConfiguration()
				.CreateLogger();

			log.Information("The application is stated");

			_initialiser.InitiliseBasketHandler();

			log.Information("Finished Initialiser");

		}
	}
}
