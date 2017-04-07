using System;
using System.Collections.Generic;

namespace CitiesAndRestaurants
{
   public class City
    {
        public string Name { get; set; }
        public string State { get; set; }
        public LatLng Coords { get; set; }

        public List<Neighborhood> Neighborhoods { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        //public List<City> NeighboringCities { get; set; }

    }
    public class Neighborhood
    {
        public string Name { get; set; }
        public City City { get; set; }
        public List<Restaurant> Restaurants { get; set; }
    }
    public class Restaurant
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Category Type { get; set; }
        public string WebsiteUrl { get; set; }

    }
    public class LatLng
    {
        public double Lat { get; set; }
        public double Long { get; set; }
    }
    public class Address
    {
        public LatLng LatLng { get; set; }
        public string StreetAddress { get; set; }
        public int Zip { get; set; }
        public string State { get; set; }
        public int MyProperty { get; set; }
        public City City { get; set; }

    }

    public enum Category {

        Italian,
        American,
        Thai,
        German,
        French,
        English,
        Mexican,
        Spanish,
        Chinese,
        Korean,
        Japanese,
        Other
    }
    class Program
    {
        static void Main(string[] args)
        {
            City dallas = new City();
            dallas.Name = "Dallas";
            dallas.State = "TX";

            LatLng dallasCoords = new LatLng();
            dallasCoords.Lat = 39.8918;
            dallasCoords.Long = 75.259064;
            dallas.Coords = dallasCoords;

            dallas.Neighborhoods = new List<Neighborhood>();
            Neighborhood deepEllum = new Neighborhood();
            deepEllum.City = dallas;
            deepEllum.Name = "Deep Ellum";

            deepEllum.Restaurants = new List<Restaurant>();

            dallas.Neighborhoods.Add(deepEllum);
//1st restaurant
            Restaurant uncleUber = new Restaurant();

            uncleUber.Name = "Uncle Uber's";
            uncleUber.WebsiteUrl = "http://www.uncleubers.com/";

            //after = we're asking for a new instance
            //LatLng is a reference type, not primitive, so we have to say 'new'
            //even though address is a string, u must delcare a 'new' before creating the address components

            uncleUber.Address = new Address();
            uncleUber.Address.StreetAddress = "2713 Commerce Street";
            uncleUber.Address.City = dallas;
            uncleUber.Address.State = "TX";
            uncleUber.Address.Zip = 75226;
            uncleUber.Address.LatLng = new LatLng();

            uncleUber.Address.LatLng.Lat = 46.098765;
            uncleUber.Address.LatLng.Long = 43.123456;
            uncleUber.Type = Category.American;

            deepEllum.Restaurants.Add(uncleUber);
//2nd restaurant

            Restaurant freeMan = new Restaurant();

            uncleUber.Name = "The Free Man Cajun Cafe";
            uncleUber.WebsiteUrl = "http://www.freemandallas.com/";

            //after = we're asking for a new instance
            //LatLng is a reference type, not primitive, so we have to say 'new'
            //even though address is a string, u must delcare a 'new' before creating the address components

            freeMan.Address = new Address();
            freeMan.Address.StreetAddress = "2713 Commerce Street";
            freeMan.Address.City = dallas;
            freeMan.Address.State = "TX";
            freeMan.Address.Zip = 75226;
            freeMan.Address.LatLng = new LatLng();

            freeMan.Address.LatLng.Lat = 46.098765;
            freeMan.Address.LatLng.Long = 43.123456;
            freeMan.Type = Category.American;

            deepEllum.Restaurants.Add(freeMan);













        }
    }
}