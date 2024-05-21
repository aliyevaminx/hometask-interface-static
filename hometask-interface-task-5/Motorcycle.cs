using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_interface_task_5
{
    internal class Motorcycle : Vehicle, IVehicle
    {
        public int MaxSpeed { get; }

        public Motorcycle(string brand, string model, int year, int maxSpeed) : base(brand, model, year)
        {
            MaxSpeed = maxSpeed;
        }

        public void Start()
        {
            Console.WriteLine("Motorcycle has started");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle has stopped");
        }
        public void GetDetails()
        {
            Console.WriteLine($"Brand: {Brand} Model: {Model} Year: {Year} Max Speed: {MaxSpeed}");
        }
    }
}
