namespace OOPractice
{
    using System;
    public interface IEngine
    {
        public int GetSpeed();
    }

    public class ElectricalEngine : IEngine
    {
        public int GetSpeed()
        {
            return 25;
        }
    }

    public class GasEngine : IEngine
    {
        public int GetSpeed()
        {
            return 30;
        }
    }

    public class Driver
    {
        private Vehicle vehicle;
        public Driver(Vehicle vehicle)
        {
            vehicle = vehicle;
        }

        public string SpeedUp()
        {
            return vehicle.SpeedUp();
        }
    }

    public class Vehicle
    {
        private string name;
        private int speed;
        public Vehicle(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
            //return "Cool Car: speed up 30 km/h";
        }
    }

    public class Car : Vehicle
    {
        private string name;
        private int speed;
        public Car(string name, IEngine engine) : base(name, engine.GetSpeed())
        {
        }
    }

    public class Truck : Vehicle
    {
        private string name;
        private string speed;
        public Truck(string name, IEngine engine) : base(name, engine.GetSpeed())
        {
        }
    }
}
