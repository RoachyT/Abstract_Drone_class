using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Drone_Class
{
    abstract class Drone
    {
       private double TotalFlyTime { get; set; }
        private double TotalDistance_Feet { get; set; }
        public Drone()
        {
        }

        public Drone(double totalFlyTime, double totalDistance_feet)
        {
            TotalFlyTime = totalFlyTime;
            TotalDistance_Feet = totalDistance_feet;
        }
        
        public virtual double FlightSpeed(double totalFlyTime, double totalDistance_feet)
        {
            return totalDistance_feet / totalFlyTime;
        }
      

    }
}
