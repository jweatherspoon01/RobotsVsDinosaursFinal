using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Program
    {

        static void Main(string[] args)
        {
            //Dinosaur trex = new Dinosaur ("Trex", 100, 25);
            //Robot robot = new Robot("RobotBob", 100, 25); 
            
            Fleet robos = new Fleet("RobotBod", "RobotTed", "JeffTheRobot");

            Herd dinos = new Herd("Trex", "Brax","Tricep");

            Battlefield bunkerhill = new Battlefield(robos, dinos);

            bunkerhill.Battle();

            Console.ReadLine();





            //robos.robo1.healthLevel -= trex.Attack();
            //trex.healthLevel -= robos.robo1.Attack();
            //robos.robo1.healthLevel -= trex.Attack();
            //trex.healthLevel -= robos.robo1.Attack();
            //robos.robo1.healthLevel -= trex.Attack();
            //trex.healthLevel -= robos.robo1.Attack();
            //robos.robo1.healthLevel -= trex.Attack();
            //trex.healthLevel -= robos.robo1.Attack();




        }
    }
}
