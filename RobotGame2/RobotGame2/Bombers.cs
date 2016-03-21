using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame2 
{
    class Bomber : Robot
    {
        int flightSpeed;
        int missles;
        int radar;
        public Bomber(string Name, string MadeIn, string ProductionDate, int PowerLevel, int Iq, int Speed, int FlightSpeed, int Missles, int Radar)
        {
            name = Name;
            madeIn = MadeIn;
            productionDate = ProductionDate;
            powerLevel = PowerLevel;
            iq = Iq;
            speed = Speed;
            flightSpeed = FlightSpeed;
            missles = Missles;
            radar = Radar;
        }
            public int launchMissles ()
            {
            int resultLaunchMissles = missles -= 2;
                return resultLaunchMissles;
            }

            public int damageMissleHit ()
            {
            int resultMissleHit = powerLevel -= 50;
            return resultMissleHit;
            }
    }
}
