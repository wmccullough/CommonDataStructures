using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataStructures.Primitives.Geography
{
    public class LatitudeLongitudeLocation
    {
        public LatitudeLongitudeLocation()
        {

        }

        public LatitudeLongitudeLocation(
            double latitude,
            double longitude,
            CoordinateSystems coordinateSystem = CoordinateSystems.NULL)
        {
            Latitude = latitude;
            Longitude = longitude;
            CoordinateSystem = coordinateSystem;
        }

        public double Latitude { get; }
        public double Longitude { get; }
        public CoordinateSystems CoordinateSystem { get; }
    }
}
