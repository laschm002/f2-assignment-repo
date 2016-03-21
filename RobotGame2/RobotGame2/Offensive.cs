using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame2
{
    public class Offensive : Robot
    {
        int firePower;
        int weaponNum;
        int ammoLevel;

        public Offensive(string Name, string MadeIn, string ProductionDate, int PowerLevel, int Iq, int Speed,int FirePower, int WeaponNum, int AmmoLevel)
        {
            name = Name;
            madeIn = MadeIn;
            productionDate = ProductionDate;
            powerLevel = PowerLevel;
            iq = Iq;
            speed = Speed;
            firePower = FirePower;
            weaponNum = WeaponNum;
            ammoLevel = AmmoLevel;
        }


            public int FireWeapon ()
            {
                int firePowerResult = firePower -= 3;
                return firePowerResult;
            }
            public int damageTaken ()
            {
                int damageTakenResult = powerLevel -= 10;
                return damageTakenResult;
                
            }
    }
}
