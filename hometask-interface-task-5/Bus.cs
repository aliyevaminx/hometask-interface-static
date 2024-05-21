using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_interface_task_5
{
    internal class Bus : Vehicle, IVehicle
    {
        public  int Capacity { get; set; }

        public Bus(string brand, string model, int year, int capacity) : base(brand, model, year) 
        {
            Capacity = capacity;
        }

        public void Start()
        {
            Console.WriteLine("Bus has started");
        }

        public void Stop()
        {
            Console.WriteLine("Bus has stopped");
        }
        public void GetDetails()
        {
            Console.WriteLine($"Brand: {Brand} Model: {Model} Year: {Year} Capacity: {Capacity}");
        }

    }
}
