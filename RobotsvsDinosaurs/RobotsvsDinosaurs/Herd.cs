using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Herd
    {   //member varialbes
        Dinosaur dino1;
        Dinosaur dino2; 
        Dinosaur dino3; 

        //contructor
        public Herd(string dino1, string dino2, string dino3)
        {
         this.dino1 = new Dinosaur(dino1, 100, 25);
         this.dino2 = new Dinosaur(dino2, 100, 25);
         this.dino3 = new Dinosaur(dino3, 100, 25);


        }

        //member methods
    }
}
