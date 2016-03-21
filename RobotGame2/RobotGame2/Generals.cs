using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame2
{
    class General : Robot
    {
        int yearsExperience;
        int nuke;

        public General(string Name, string MadeIn, string ProductionDate, int PowerLevel, int Iq, int Speed, int YearsExperience, int Nuke)
        {
            name = Name;
            madeIn = MadeIn;
            productionDate = ProductionDate;
            powerLevel = PowerLevel;
            iq = Iq;
            speed = Speed;
            yearsExperience = YearsExperience;
            nuke = Nuke;
        }
        public int dropANuke()
        {
            nuke -= 1;
            return nuke;
        }
        public int damageDropNuke()
        {
            int resultDamageTaken = powerLevel -= 100;
            return resultDamageTaken;
        }
    }
}
