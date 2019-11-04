using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBalloonInterfaces
{
    public interface ILaunchSite
    {
        string Id { get; set; }

        double Latitude { get; set; }

        double Longitude { get; set; }

        double Elevation { get; set; }

        string State { get; set; }

        string Name { get; set; }

        int YearOfFirstMeasurement { get; set; }

        int YearOfLastMeasurement { get; set; }

        int NumberOfMeasurements { get; set; }
    }
}
