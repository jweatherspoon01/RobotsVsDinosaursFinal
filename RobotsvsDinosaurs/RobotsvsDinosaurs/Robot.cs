using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Robot

    {   //member variables
        public string robotName ;
        public int healthLevel ;
        public int powerLevel ;
        public int attackPower ;
        public Weapon Weapon ;

        //contructor
        public Robot(string robot, int healthLevel, int attackPower)
        {
            robotName = robot;
            this.healthLevel = healthLevel;
            this.attackPower = attackPower;
            this.Weapon = new Weapon("Twig");
        }

        //member methods

    }
}
