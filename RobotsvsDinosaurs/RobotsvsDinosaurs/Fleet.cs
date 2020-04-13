using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Fleet
    {   // member variables
        public Robot robo1;
        public Robot robo2;
        public Robot robo3;
        public List <Robot> robots;

        //contructor
        public Fleet(string robo1, string robo2, string robo3)
        {
         this.robo1 = new Robot(robo1, 100, 25);
         this.robo2 = new Robot(robo2, 100, 25);
         this.robo3 = new Robot(robo3, 100, 25);

            robots = new List<Robot>();   

        }
        //member methods

        public void RoboList()
        {
            robots.Add(this.robo1);
            robots.Add(this.robo2);
            robots.Add(this.robo3);

        }


    }
}
