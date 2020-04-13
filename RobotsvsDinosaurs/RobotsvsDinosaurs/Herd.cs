using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Herd
    {   //member varialbes
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;
        public List <Dinosaur> dinosaurs;

        //contructor
        public Herd(string dino1, string dino2, string dino3)
        {
         this.dino1 = new Dinosaur(dino1, 100, 25);
         this.dino2 = new Dinosaur(dino2, 100, 25);
         this.dino3 = new Dinosaur(dino3, 100, 25);

         dinosaurs = new List<Dinosaur>(){this.dino1,this.dino2,this.dino3};
        
        }

        
        //member methods
    }
}
