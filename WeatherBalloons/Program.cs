using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using WeatherBalloonDataSource;
using WeatherBalloonInterfaces;
using WeatherBalloons.Repository;

namespace WeatherBalloons
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TempRunProgram();

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static void TempRunProgram()
        {
            IWeatherBalloonRepository weatherBalloonRepository = new WeatherBalloonInMemoryRepository();
            weatherBalloonRepository.SetAtmosphericMeasurements(DataSource.GetAtmosphericMeasurements("bluh"));
            weatherBalloonRepository.SetLaunchSites(DataSource.GetLaunchSites());

        }
    }
}
