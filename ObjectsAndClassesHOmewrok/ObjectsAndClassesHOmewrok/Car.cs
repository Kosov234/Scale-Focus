using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClassesHOmewrok
{
    class Car
    {
        public int ImmobilizerId { get; set }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Array[] Tyre = new Tyre;
        public IgnitionKey IgnitionKey { set; get; }
        public Engine Engine { set; get; }
        public Human Driver { set; get; }
    }

    public string EnterTheCar()
    { if (Human.Age >= 18)
        {
            Console.WriteLine("You are allowed to drive!");
        }
        else 
        {
            Console.WriteLine("You are not allowed to drive!");
        }
    }
}
