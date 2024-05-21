using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_interface_task_5
{
    internal class Vehicle
    {
        public string Brand { get; }
        public string Model { get; }
        public int Year { get; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
}
