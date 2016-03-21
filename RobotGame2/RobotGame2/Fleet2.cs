using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame2
{
    public class Fleet2 : Robot
    {

        Defensive iceMan = new Defensive("IceMan", "Thailand", "4/9/2015", 200, 125, 75, 300);
        Offensive derek = new Offensive("Derek", "Omaha", "4/6/2001", 100, 150, 100, 300, 5, 750);
        Bomber baeMax = new Bomber("BaeMax", "Japan", "7/10/2009", 400, 100, 1000, 2000, 500, 1000);
        General norman = new General("Norman", "Sweden", "4/2/2010", 50, 200, 75, 25, 3);


        List<Robot> aTeam = new List<Robot>();
        

        public List<Robot> addToFleet2()
        {
            aTeam.Add(iceMan);
            aTeam.Add(derek);
            aTeam.Add(baeMax);
            aTeam.Add(norman);

            foreach (Robot member in aTeam)
                member.name;
            
            return aTeam;
        }
    }    
            
    }

