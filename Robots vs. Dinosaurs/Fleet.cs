using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Fleet
    {
        //member variables
        public int health;
        public int powerLevel;
        public int attackPower;
        public string name;
        public string weapon;

        //constructor
        public Fleet(string robotName, int atkpow, string weaponType)
        {
            health = 100;
            powerLevel = 100;
            attackPower = atkpow;
            name = robotName;
            weapon = weaponType;

        }
    }
}
