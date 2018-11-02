using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Drone_Class
{
    class Program
    {
        static void Main(string[] args)
        {
             Quadrotor_Drone newDrone = new Quadrotor_Drone();

            Console.WriteLine(newDrone.FlightSpeed(75,1840));

        }

        //SOLID:
        //each class only does 1 thing. Quad drone ONLY calcultes speed and the abstract class just sets it up 
        //the class is open to be extended but i cannot modify the original since it is private 
        //we are able to use polymorphism by taking the method and being able to overload it 
        //the drone method doesn't rely on Quad. the lower level depends on the higher level. 
    }
}
