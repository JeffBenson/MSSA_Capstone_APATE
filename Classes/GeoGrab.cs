using IPGeolocation;
using System;

namespace GeoGrab
{
    public class GeoGrab

        {
            public static void GetLocation()
            {
                // Create IPGeolocationAPI object, passing your valid API key
                IPGeolocationAPI api = new IPGeolocationAPI("7f568c0011f94605ab23aac3e1aa3ea6");

                // Get geolocation for IP address and fields

                GeolocationParams geoParams = new GeolocationParams();
                geoParams.SetIPAddress("172.220.225.50");
                geoParams.SetFields("geo,time_zone,currency");

                Geolocation geolocation;

                try
                {
                    geolocation = api.GetGeolocation(geoParams);
                    // Check if geolocation lookup was successful
                    if (geolocation.GetStatus() == 200)
                    {
                        Console.WriteLine("Last Know Location: ");
                        Console.WriteLine(geolocation.GetTimezone().GetCurrentTime());
                        Console.WriteLine("\nCountry: " + geolocation.GetCountryName());
                        Console.WriteLine("State/Province: " + geolocation.GetStateProvince());
                        Console.WriteLine("City: " + geolocation.GetCity());
                        Console.WriteLine("Lat: " + geolocation.GetLatitude());
                        Console.WriteLine("Long: " + geolocation.GetLongitude());

                    }
                    else if (geolocation.GetStatus() != 200)
                    {
                        Console.WriteLine("Data cannot be retrieved.");
                    }
                }
                catch
                {
                    Console.WriteLine("Cannot retrieve data.");
                }





                Console.ReadKey();
            }
        }
    }




    //7f568c0011f94605ab23aac3e1aa3ea6


