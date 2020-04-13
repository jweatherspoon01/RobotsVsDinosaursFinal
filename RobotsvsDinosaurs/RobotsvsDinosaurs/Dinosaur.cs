using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{ 
    public class Dinosaur
    {   
        //member variables
        public string dinosaurType ;
        public int healthLevel ;
        public int energy ;
        public int attackPower ;

    
        //contructor
        public Dinosaur(string dinosaur, int healthLevel, int attackPower)
        {
         dinosaurType = dinosaur;
         this.healthLevel = healthLevel;
         this.attackPower = attackPower;
                
        }
        //member methods
        //Fleet robos = new Fleet("RobotBod", "RobotTed", "JeffTheRobot");
        //int RobotHealth = 100; 
        public int Attack()
        {
            //use attackpower on robot
            return attackPower;
            

            
        }


    }
        
 
}
