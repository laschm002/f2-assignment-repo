using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("WarBots");

            Console.WriteLine("Enter your Name");

            string playerName = Console.ReadLine();

            Console.WriteLine("Hello " + playerName + " ,you must now choose the type of Robot you want to be!");

            Console.WriteLine("Press 1 to be a General, Press 2 to be an Offensive Robot, Press 3 to be a Defensive Robot, or Press 4 to be a Bomber!");

            int botChoice = Convert.ToInt32(Console.ReadLine());

            if (botChoice == 1)
            {
                Console.WriteLine(playerName + " ,you are now a General!");
            }
            else if (botChoice == 2)
            {
                Console.WriteLine(playerName + " ,you are now an Offensive Robot");
            }
            else if (botChoice == 3)
            {
                Console.WriteLine(playerName + " ,you are now a Defensive Robot");
            }
            else if (botChoice == 4)
            {
                Console.WriteLine(playerName + " ,you are now a Bomber Robot");

            }

            else
            {
                Console.WriteLine(playerName + " ,you must enter a number between 1 and 4");
                Console.WriteLine("Press 1 to be a General, Press 2 to be an Offensive Robot, Press 3 to be a Defensive Robot, or Press 4 to be a Bomber!");

                //maybe put in a loop 
                int botChoice2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Now that you are a robot you will need to customize your robot self!");
            Console.WriteLine("Type in your robot name!");

            string playerRobotName = Console.ReadLine();
            Console.WriteLine("What location was your robot self made?");

            string playerMadeIn = Console.ReadLine();

            Console.WriteLine("What date were you made?");
            string playerProductionDate = Console.ReadLine();

            Console.WriteLine("What is your robot IQ?  It cannot exceed 150!");
            int playerIQChoice = Convert.ToInt32(Console.ReadLine());

            if (playerIQChoice <= 150)
            {
                Console.WriteLine("Your iq is now " + playerIQChoice);
            }
            else
            {
                Console.WriteLine("Please re-enter an Iq number between 0-150");
                Console.WriteLine("What is your robot IQ?  It cannot exceed 150!");
                int playerIQChoice2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Alright " + playerRobotName + " finally it is time to go and fight the good fight");

            Console.WriteLine("Here is the scenerio, you are dropped behind enemy lines with a fleet of robots.  You need to fight an enemy fleet!");
            Console.WriteLine("The enemy spots you and fires first,  what do you want to do?");
            Console.WriteLine("How do you want to respond?");
            Console.WriteLine("Enter (1) to shoot back, enter (2) to have a general drop a nuke, enter (3) to have a bomber launch a missle");


            Defensive iceMan = new Defensive("IceMan", "Thailand", "4/9/2015", 200, 125, 75, 300);
            Offensive humanOffensive = new Offensive(playerRobotName, playerMadeIn, playerProductionDate, playerIQChoice, 150, 100, 400, 5, 750);
            Defensive humanDefense = new Defensive(playerRobotName, playerMadeIn, playerProductionDate, playerIQChoice, 125, 75, 300);
            Bomber humanBomber= new Bomber(playerRobotName, playerMadeIn, playerProductionDate, playerIQChoice, 100, 1000, 2000, 500, 1000);
            General humanNorman = new General (playerRobotName, playerMadeIn, playerProductionDate, playerIQChoice,200,75,25,3);

            Offensive derek = new Offensive("Derek", "Omaha", "4/6/2001", 100, 150, 100, 300, 5, 750);
            Offensive miller = new Offensive("Miller", "China", "5/9/2000", 100, 150, 100, 400,5,750);
           
            Bomber baeMax = new Bomber("BaeMax", "Japan", "7/10/2009", 400, 100, 1000, 2000, 500, 1000);
            Bomber zeus = new Bomber("Zeus", "Greece", "7/7/15000 bc", 500, 100, 2000, 3000, 500, 2000);
            General norman = new General("Norman", "Sweden", "4/2/2010", 50, 200, 75, 25, 3);
            General colin = new General("Colin", "Crotia", "5/34/2064", 50, 200, 75, 25, 3);

            List<Robot> human = new List<Robot>();
                human.Add(humanOffensive);

            foreach (Robot player in human)
            {
                Console.WriteLine("Alright this is what we have on record your name is " + player.name);
                Console.WriteLine("You were made in " + player.madeIn);
                Console.WriteLine("Your production date is " + player.productionDate);
                Console.WriteLine("Your self diagnosed iq is " + player.iq);
                Console.WriteLine("We have given you some default settings for your robot type");
                Console.WriteLine("You have a power level of " + player.powerLevel);

          
            }

           /* List<Robot> soldiers = new List<Robot>();
            {
                soldiers.Add(miller);
                soldiers.Add(iceMan);
                soldiers.Add(baeMax);
                soldiers.Add(norman);
*/

            int response1 = Convert.ToInt32(Console.ReadLine());
            int resultResponse1;
            int resultDamage1;
            switch (response1)
            {
                case 1:
                     
                   resultResponse1 = miller.FireWeapon();
                   resultDamage1 = derek.damageTaken();
                   Console.WriteLine("here is your result, your missle count has dropped to "+ resultResponse1);
                   Console.WriteLine("but the robot you hit was an offensice robot and his power level dropped from 100 to " + resultDamage1);
                   break;

                case 2:

                    resultResponse1 = norman.dropANuke();
                    resultDamage1 = colin.damageDropNuke();
                    Console.WriteLine("here is your result, your nuke fried everyone and everything within 100 miles your nuke general's nuke count went down to " + resultResponse1);
                    Console.WriteLine(resultDamage1);
                    break;

                case 3:

                    resultResponse1 = baeMax.launchMissles();
                    resultDamage1 = zeus.damageMissleHit();
                    Console.WriteLine("here is your result, your missle hit a bomber named Zeus and his power level dropped from 500 to " + resultDamage1 +" but your Missle count is down to" + resultDamage1);
                    break;

                default:
                    Console.WriteLine(" You missed your oppurtunity to strike back, you need to enter 1,2, or 3 next time");
                    break;
            }

            


            

           





                
           // ******randomn generator to create human input robot using if or while******
           // *****moves with a loop ******




     

          

            Console.ReadLine();
        }
    }
}
