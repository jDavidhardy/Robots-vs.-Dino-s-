using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsNet;

namespace Robots_vs.Dinosaurs
{
    class Dinosaur
    {
        //member variables
        public int health;
        public int energy;
        public int attackPower;
        string type;

        //constructor
        public Dinosaur(string dinotype, int atkpow)
        {
            health = 100;
            energy = 100;
            attackPower = atkpow;
            this.type = dinotype;
            
        }


        // member methods
        public void Attack(Robot robotName)
        {
            robotName.health -= attackPower;
        }
               
    }
}
