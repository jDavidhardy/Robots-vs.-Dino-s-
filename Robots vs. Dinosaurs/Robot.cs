using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    public class Robot
    {

        //member variables
        public int health;
        public int powerLevel;
        public string name;
        public Weapons weapon;

        //constructor
        public Robot(string robotName, string weaponType, int weaponPower)
        {
            health = 100;
            powerLevel = 100;
       
            name = robotName;
            weapon = new Weapons(weaponType, weaponPower);

        }


        // member methods
        public void Attack(Dinosaur dinotype)
        {

            dinotype.health -= weapon.weaponPower;
        }
    }
}
