using System;
using System.Collections;
using System.Collections.Generic;
using WeatherBalloonInterfaces;

namespace WeatherBalloonDataSource
{
    public static class DataSource
    {
        public static IList<IAtmosphericMeasurement> GetAtmosphericMeasurements(string launchSiteId)
        {
            //will refine this later, but initially the goal is to just collect the measurements of all time for a certain launch site

            //download zip file

            //unzip zip file

            //read file line by line

            //identify line as header line or measurement

            //parse header or measurement

            throw new NotImplementedException();
        }

        public static IList<ILaunchSite> GetLaunchSites()
        {
            throw new NotImplementedException();
        }

        //get launch stations all

        //get atmospheric measurements per launch station all

        //get atmospheric measurements per launch station per data

    }



}
