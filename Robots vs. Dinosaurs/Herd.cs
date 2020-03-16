using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    public class Herd
    {
        public List<Dinosaur> dinoHerd;
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;
        public Herd()
        {
            dinoHerd = new List<Dinosaur>();
            dino1 = new Dinosaur("Tyrannosaurus Rex", 100);
            dino2 = new Dinosaur("Spinosaurus", 100);
            dino3 = new Dinosaur("Carnotaurus", 100);
            dinoHerd.Add(dino1);
            dinoHerd.Add(dino2);
            dinoHerd.Add(dino3);
            
        }
    

        //public void dinotype1()
        //{
        //    console.writeline("you chose the tyrannosaurus rex.");
        //    health = 110;
        //    energy = 210;
        //    attackpower = 20;
        //    console.readline();
        //}
        //public void dinotype2()
        //{
        //    console.writeline(" you chose the spinosaurus.");
        //    health = 225;
        //    energy = 215;
        //    attackpower = 25;
        //    console.readline();
        //}
        //public void dinotype3()
        //{
        //    console.writeline("you chose the carnotaurus");
        //    health = 180;
        //    energy = 275;
        //    attackpower = 15;
        //    console.readline();
        //}


        //// member methods
        //public void attack(robot robotname)
        //{
        //    robotname.health -= attackpower;

        //    int choice = 0;
        //    console.writeline("select your beast to enter the battle with:");
        //    choice = int.parse(console.readline());
        //    switch (choice)
        //    {
        //        case 1:
        //            dinotype1();
        //            break;

        //        case 2:
        //            dinotype2();
        //            break;

        //        case 3:
        //            dinotype3();
        //            break;
        //            console.readline();
        //    }



        //}
    }
}