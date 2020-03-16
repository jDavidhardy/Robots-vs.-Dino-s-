using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    public class Weapons
    {
        public int weaponPower;
        public string weaponType;
        public Weapons(string weaponType, int atkpow)
        {
            this.weaponPower = atkpow;
            this.weaponType = weaponType;
        }
    }
}
