using System;
using System.Collections.Generic;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet mercury = new Planet("Mercury", 0.333, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88, 47.4, 167, 0, false);
            Planet venus = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802, 108.2, 224.7, 35, 464, 0, false);
            Planet earth = new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24, 149.6, 365.2, 29.8, 15, 1, false);
            Planet mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687, 24.1, -65, 2, false);
            Planet jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
            Planet saturn = new Planet("Saturn", 568, 120536, 687, 9, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, true);
            Planet uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, true);
            Planet neptun = new Planet("Neptun", 102, 49528, 1638, 11, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true);
            Planet pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);

            List<Planet> Planets = new List<Planet>();
            Planets.Add(mercury);
            Planets.Add(earth);
            Planets.Add(mars);
            Planets.Add(jupiter);
            Planets.Add(saturn);
            Planets.Add(uranus);
            Planets.Add(neptun);
            Planets.Add(pluto);
            Planets.Insert(1, venus);
            Planets.Remove(pluto);
            Planets.Add(pluto);

            List<Planet> MeanTemperatureNegative = new List<Planet>();
            foreach (var items in Planets)
            {
                if (items.MeanTemperature < 0)
                    MeanTemperatureNegative.Add(items);
            }

            List<Planet> Diameter10kmTo50km = new List<Planet>();
            foreach (var items in Planets)
            {
                if (items.Diameter > 10000 && items.Diameter < 50000)
                    Diameter10kmTo50km.Add(items);
            }

            foreach (var items in MeanTemperatureNegative)
                Console.WriteLine(items.Name);

            Console.WriteLine(Planets.Count);

            foreach (var items in Diameter10kmTo50km)
                Console.WriteLine((items.Name));
        }
    }
}
