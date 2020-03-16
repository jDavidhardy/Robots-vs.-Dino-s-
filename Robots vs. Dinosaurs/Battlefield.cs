using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Battlefield
    {
        static void RunBattle()
        {
            Dinosaur dinotype = new Dinosaur("Tyrannosaurus Rex", 20);  //  public Herd(string dinotype, int atkpow)
            dinotype.Attack();                                                           //needs robot names

            Dinosaur dinotype = new Dinosaur("Spinosaurus", 25);        //  public Herd(string dinotype, int atkpow)
            dinotype.Attack();                                                           //needs robot names

            Dinosaur dinotype = new Dinosaur("Carnotaurus", 15);        //  public Herd(string dinotype, int atkpow)
            dinotype.Attack();                                                           //needs robot names

                                                                        //  Bring over from Robot/Fleet class --> public Robot(string robotName, int atkpow, string weaponType)  like same as above from dino herd.
        }

    }
}
