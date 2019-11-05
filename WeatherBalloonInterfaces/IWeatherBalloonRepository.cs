using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBalloonInterfaces
{
    public interface IWeatherBalloonRepository
    {

        IList<IAtmosphericMeasurement> GetAtmosphericMeasurements(string launchSiteId);

        IList<ILaunchSite> GetLaunchSites();

        void SetAtmosphericMeasurements(IList<IAtmosphericMeasurement> atmosphericMeasurements);

        void SetLaunchSites(IList<ILaunchSite> launchSites);

    }
}
