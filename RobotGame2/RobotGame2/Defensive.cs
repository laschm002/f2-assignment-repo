using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame2
{
    class Defensive : Robot
    {
        int shieldStrength;

        public Defensive(string Name, string MadeIn, string ProductionDate, int PowerLevel, int Iq, int Speed, int ShieldStrength)
        {
            name = Name;
            madeIn = MadeIn;
            productionDate = ProductionDate;
            powerLevel = PowerLevel;
            iq = Iq;
            speed = Speed;
            shieldStrength = ShieldStrength;
        }
    }
}
