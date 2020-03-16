using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Battlefield
    {
        public Herd herd;
        public Fleet fleet;
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }
        public void attack1()
        {



            //int response = int.Parse(Console.ReadLine());
       
            //herd.dinoHerd[response].Attack(fleet.robotFleet[response]);
            //while(response > 0)
            //{
            //    herd.dinoHerd.RemoveAt(0);
            //    Console.WriteLine();
            //}
            //List<string> dinoHerd = new List<string> { "Tyrannosaurus Rex ", "Spinosaurus", "Carnotaurus" };

            //foreach (string Dinosaur in dinoHerd)
            //{
            //    Console.WriteLine(Dinosaur);
            //}
        }
    }

}

