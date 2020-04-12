using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Fleet
    {   // member variables
        Robot robo1;
        Robot robo2;
        Robot robo3;

        //contructor
        public Fleet(string robo1, string robo2, string robo3)
        {
            this.robo1 = new Robot(robo1, 100, 25);
            this.robo2 = new Robot(robo2, 100, 25);
            this.robo3 = new Robot(robo3, 100, 25);

        }
        //member methods
    }
}
