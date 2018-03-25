using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClassesHOmewrok
{
    class Car
    {
        public int ImmobilizerId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Array[] Tyre = new Array[4];
        public IgnitionKey IgnitionKey { set; get; }
        public Engine Engine { set; get; }
        public Human Driver { set; get; }
    }

    public string EnterTheCar()
    {
        if (Human.Age >= 18)
        {
            Console.WriteLine("You are allowed to drive!");
        }
        else
        {
            Console.WriteLine("You are not allowed to drive!");
        }
    }

    public string StartEngine()
    {
        if (Car.ImmobilizerId == IgnitionKey.ImmobilizerId)
        {
            if (Engine.IsRunning == false)
            {
                Console.WriteLine("Everything is OK");
                Engine.IsRunning = true;
            }
            else
            {
                Console.WriteLine("Engine is already running!");
            }
        }
        else
        { Console.WriteLine("Ignition Key is not from this car"); }
    }
}
