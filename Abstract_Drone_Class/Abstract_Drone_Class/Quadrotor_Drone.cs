using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Drone_Class
{
    class Quadrotor_Drone: Drone
    {
     

        public Quadrotor_Drone() 
        {

        }

        public override double FlightSpeed(double totalFlyTime1, double totalDistance_feet1)
        {
            return totalDistance_feet1 / totalFlyTime1;
        }
    }
}
