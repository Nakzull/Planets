using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    class Planet
    {
        private string name;
        private double mass;
        private int diameter;
        private int density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private int meanTemperature;
        private int numberOfMoons;
        private bool ringSystem;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Mass
        {
            get { return this.mass; }
            set { this.mass = value; }
        }
        public int Diameter
        {
            get { return this.diameter; }
            set { this.diameter = value; }
        }
        public int Density
        {
            get { return this.density; }
            set { this.density = value; }
        }
        public double Gravity
        {
            get { return this.gravity; }
            set { this.gravity = value; }
        }
        public double RotationPeroid
        {
            get { return this.rotationPeriod; }
            set { this.rotationPeriod = value; }
        }
        public double LengthOfDay
        {
            get { return this.lengthOfDay; }
            set { this.lengthOfDay = value; }
        }
        public double DistanceFromSun
        {
            get { return this.distanceFromSun; }
            set { this.distanceFromSun = value; }
        }
        public double OrbitalPeriod
        {
            get { return this.orbitalPeriod; }
            set { this.orbitalPeriod = value; }
        }
        public double OrbitalVelocity
        {
            get { return this.orbitalVelocity; }
            set { this.orbitalVelocity = value; }
        }
        public int MeanTemperature
        {
            get { return this.meanTemperature; }
            set { this.meanTemperature = value; }
        }
        public int NumberOfMoons
        {
            get { return this.numberOfMoons; }
            set { this.numberOfMoons = value; }
        }
        public bool RingSystem
        {
            get { return this.ringSystem; }
            set { this.ringSystem = value; }
        }

        public Planet(string Name, double Mass, int Diameter, int Density, double Gravity, double RotationPeriod, double LengthOfDay, double DistanceFromSun, double OrbitalPeriod, double OrbitalVelocity, int MeanTemperature, int NumberOfMoons, bool RingSystem)
        {
            name = Name;
            mass = Mass;
            diameter = Diameter;
            density = Density;
            gravity = Gravity;
            rotationPeriod = RotationPeroid;
            lengthOfDay = LengthOfDay;
            distanceFromSun = DistanceFromSun;
            orbitalPeriod = OrbitalPeriod;
            orbitalVelocity = OrbitalVelocity;
            meanTemperature = MeanTemperature;
            numberOfMoons = NumberOfMoons;
            ringSystem = RingSystem;
        }
    }
}
