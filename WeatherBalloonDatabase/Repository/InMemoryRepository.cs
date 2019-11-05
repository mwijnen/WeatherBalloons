using System.Collections.Generic;
using WeatherBalloonInterfaces;

namespace WeatherBalloons.Repository
{
    public class WeatherBalloonInMemoryRepository : IWeatherBalloonRepository
    {
        private IList<IAtmosphericMeasurement> atmosphericMeasurements;

        private IList<ILaunchSite> launchSites;
        
        public IList<IAtmosphericMeasurement> GetAtmosphericMeasurements(string launchSiteId)
        {
            return atmosphericMeasurements;
        }

        public IList<ILaunchSite> GetLaunchSites()
        {
            return launchSites;
        }

        public void SetAtmosphericMeasurements(IList<IAtmosphericMeasurement> atmosphericMeasurements)
        {
            this.atmosphericMeasurements = atmosphericMeasurements;
        }

        public void SetLaunchSites(IList<ILaunchSite> launchSites)
        {
            this.launchSites = launchSites;
        }

    }
}
