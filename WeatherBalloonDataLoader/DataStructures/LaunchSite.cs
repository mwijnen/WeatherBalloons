using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBalloonDataSource.DataStructures
{
    public class LaunchSite
    {
        public string Id { get; set; }

        public double Latitude { get; set;}

        public double Longitude { get; set; }

        public double Elevation { get; set; }

        public string State { get; set; }

        public string Name { get; set; }

        public int YearOfFirstMeasurement { get; set; }

        public int YearOfLastMeasurement { get; set; }

        public int NumberOfMeasurements { get; set; }
    }
}
