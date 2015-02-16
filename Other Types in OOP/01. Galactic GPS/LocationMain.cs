namespace Galactic_GPS
{
    using System;
    using Galactic_GPS.Enumerations;
    using Galactic_GPS.Models;

    public class LocationMain
    {
        public static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
