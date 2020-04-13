using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{   
    public class Battlefield
    {   //member variables
        Fleet robos;
        Herd dinos;
        int livedinos = 3;
        int liverobos = 3;

        //contructor
        public Battlefield(Fleet robos, Herd dinos)
        {
            this.robos = robos;
            this.dinos = dinos;
        }

        //member methods
        public void Battle()
        {
            //fight
            //death
            //winner
            robos.RoboList();        
            
            int dinocounter = 0;
            int roboscounter = 0;

            while(robos.robots.Count == dinos.dinosaurs.Count)
            {
                if (dinocounter < livedinos)
                {
                    dinoattack(dinocounter);
                }
                if (roboscounter < liverobos)
                {
                    robotattack(roboscounter);
                }
                
                dinocounter++;
                roboscounter++;
                if (dinocounter > 2)
                {
                    dinocounter = 0;
                    roboscounter = 0;
                }
                

            }
            winner();
        }
        public void robotattack(int i)
        {
            //it checks for and an opponent and deals damage and checks if a dino is dead
            if (i < livedinos)
            {
                Console.WriteLine("Robot " + (i+1) + " Is Attacking");
                dinos.dinosaurs[i].healthLevel -= robos.robots[i].attackPower;
                if (dinos.dinosaurs[i].healthLevel <= 0)
                {
                    dinos.dinosaurs.RemoveAt(i);
                    livedinos--;

                }
            }
        }
        public void dinoattack(int i)
        {
            if (i < liverobos)
            {
                Console.WriteLine("Dinosuar " + (i+1) + " Is Attacking");
                robos.robots[i].healthLevel -= dinos.dinosaurs[i].attackPower;
                if (robos.robots[i].healthLevel <= 0)
                {
                    robos.robots.RemoveAt(i);
                    liverobos--;

                }
            }
        }
        public void winner()
        {
            //liverobos
            if (liverobos > livedinos)
            {
                Console.WriteLine("Robots are Winners");
            }
            else if (livedinos > liverobos)
            {
                Console.WriteLine("Dinos are WinnerS");
            }
            
            //livedinos 

        }
        
    }
}
//for (int i = 0; i < 3; i++)
//{
//attack each other
//if (robos.robots.Count <= liverobos && i < livedinos)
//{
//   dinos.dinosaurs[i].healthLevel -= robos.robots[i].attackPower;

//    if (dinos.dinosaurs[i].healthLevel <= 0)
//    {
//        dinos.dinosaurs.RemoveAt(i);

//        livedinos--;

//        Console.WriteLine("DeadDino");

//    }                          

//    //Console.WriteLine(dinos.dinosaurs[i].healthLevel);
//    //Console.ReadLine();
//}
//else if(1==1)
//{


//}
//}