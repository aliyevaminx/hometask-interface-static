using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_interface_task_5
{
    internal class Car : Vehicle, IVehicle
    {

        public Car(string brand, string model, int year) : base(brand, model, year) 
        {
           
        }

        public void Start()
        {
            Console.WriteLine("Car has started");
        }
        
        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
        public void GetDetails() 
        {
            Console.WriteLine($"Brand: {Brand} Model: {Model} Year: {Year}");
        }
    }
}
