using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Robot
    {

        //member variables
        public int health;
        public int powerLevel;
        public int attackPower;
        public string name;
        public string weapon;

        //constructor
        public Robot(string robotName, int atkpow, string weaponType)
        {
            health = 100;
            powerLevel = 100;
            attackPower = atkpow;
            name = robotName;
            weapon = weaponType;

        }

       
    // member methods
    public void Attack(Dinosaur dinotype)
        {
            dinotype.health -= attackPower;
        }
    }
}
