using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleUsingAdoDotNet
{
    public enum Color
    {
        White = 0,
        Black,
        Red,
        Grey,
        Brown
    }
    public abstract class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string RegNo { get; set; }
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public decimal Price { get; }
        protected decimal _CurrentPrice; 
        public decimal CurrentPrice
        {
            get
            {
                _CurrentPrice = Price;
                int difference = DateTime.Now.Year - DateOfManufacture.Year;
                if (difference < Car.ServiceYear)
                {
                    for (int i = 1; i <= difference; i++)
                    {
                        _CurrentPrice = (_CurrentPrice - (_CurrentPrice / 10));
                    }
                }
                else
                {
                    _CurrentPrice = 0;
                }
                return _CurrentPrice;
            }
        }
        public int Speed { get; set; }
        public static int MaxAccelerateSpeed = 10;
        public static int MinDeaccelerateSpeed = 10;
        public static int ServiceYear = 15;
        public DateTime DateOfManufacture { get; set; }
        protected string _Status;
        public string Status
        {
            get
            {
                return _Status;
            }
        }
        //public byte[] VehicleImage;
        public Vehicle()
        { 
        }
        public Vehicle(string regNo, string typeOfVehicle, string make, string model, Color color, decimal price, DateTime dateOfManufacture)
            : this()
        {
            this.RegNo = regNo;
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Price = price;
            this.DateOfManufacture = dateOfManufacture;
            this.TypeOfVehicle = typeOfVehicle;
        }
        public abstract void Start();
        public void Stop()
        {
            Speed = 0;
            _Status = " Your " + TypeOfVehicle + " Stopped at the speed of " + Speed;
        }
        public abstract void Accelerate(int offsetSpeed);
        public void DeAccelerate(int offsetSpeed)
        {
            if (offsetSpeed <= MinDeaccelerateSpeed)
            {
                throw new ApplicationException(TypeOfVehicle+  "Cannot decrease speed by this amount");
            }
            if (Speed <= 120)
            {
                throw new ApplicationException("Speed of" + TypeOfVehicle + "cannot be accelerate");
            }
            Speed -= offsetSpeed;
            _Status = "Your" + TypeOfVehicle + "has slow down the speed and \r\n Current speed of your" + TypeOfVehicle + " is" + Speed;
        }
        public override string ToString()
        {
            return "Your" + TypeOfVehicle + " is running at the Speed: " + Speed + "\r\n Color:" + Color + "\r\n Make:" + Make + "\r\n Model: " + Model;
        }
    }
    class Car : Vehicle
    {
        public Car()
        {
            //default constructor
        }
        public Car(string regNo, string typeOfVehicle, string make, string model, Color color, decimal price, DateTime dateofmanufacture)
            : base(regNo, typeOfVehicle, make, model, color, price, dateofmanufacture)
        {
            if ((DateTime.Now.Year - DateOfManufacture.Year) == 0)
            {
                _Status = "Congratulations on Purchasing a new Car";
            }
            else
            {
                _Status = "Current Price of your Car is:" + CurrentPrice;
            }
        }
        public override void Start()
        {
            Speed = 20;
            _CurrentPrice = Price;
            int difference = DateTime.Now.Year - DateOfManufacture.Year;
            if (difference > Car.ServiceYear)
            {
                throw new ApplicationException("Car Expired");
            }
            _Status = "Your Car started at the speed of 20";
        }
        public override void Accelerate(int offsetSpeed)
        {
            if (offsetSpeed <= MaxAccelerateSpeed)
            {
                throw new ApplicationException("Car cannot increase speed by this amount");
            }
            if (Speed >= 140)
            {
                throw new ApplicationException("Car cannot cross beyond Max Speed");
            }
            Speed += offsetSpeed;
            _Status = "Your Car Started at the speed of 20 and \r\n Current Speed of your Car is: " + Speed;
        }
    }
    class Truck : Vehicle
    {
        public Truck()
        { }
        public Truck(string regNo, string typeOfVehicle, string make, string model, Color color, decimal price, DateTime dateofmanufacture)
            : base(regNo, typeOfVehicle, make, model, color, price, dateofmanufacture)
        {
            if ((DateTime.Now.Year - DateOfManufacture.Year) == 0)
            {
                _Status = "Congratulations on Purchasing a new Truck";
            }
            else
            {
                _Status = "Current Price of your Truck is:" + CurrentPrice;
            }
        }
        public override void Start()
        {
            Speed = 20;
            _CurrentPrice = Price;
            int difference = DateTime.Now.Year - DateOfManufacture.Year;
            if (difference > Car.ServiceYear)
            {
                throw new ApplicationException("Truck Expired");
            }
            _Status = "Truck started at the speed of 20";
        }
        public override void Accelerate(int offsetSpeed)
        {
            if (offsetSpeed < MaxAccelerateSpeed)
            {
                throw new ApplicationException("Your Truck cannot start");
            }
            if (Speed >= 120)
            {
                throw new ApplicationException("Truck cannot cross beyond Max Speed");
            }
            Speed += offsetSpeed;
            _Status = "Your Truck Started at the speed of 20 and \r\n Current Speed of your Truck is: " + Speed;
        }
    }
}

    