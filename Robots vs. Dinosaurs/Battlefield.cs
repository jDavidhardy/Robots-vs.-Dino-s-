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
            Console.WriteLine("Select your class: Enter 1 for Dinosaurs & Enter 2 for Robots.");
            int Answer1 = int.Parse(Console.ReadLine());

            if (Answer1 == 1)
            {
                Console.WriteLine("You are in the Herd.");
            }

            else
            {
                Console.WriteLine("You are in the Fleet.");
            }
            Console.ReadLine();
        }

        public void Battle()
        {
            Console.WriteLine("Welcome to the Battlefield");
            Console.ReadLine();

            attack1();

        }
    }
}
