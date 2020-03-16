using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Herd
    {

        //member variables
        public int health;
        public int energy;
        public int attackPower;
        public string type;

        //constructor
        public Herd(string dinotype, int atkpow)
        {
            health = 100;
            energy = 100;
            attackPower = atkpow;
            this.type = dinotype;
        }

        public void dinotype1()
        {
            Console.WriteLine("You chose the Tyrannosaurus Rex.");
            health = 110;
            energy = 210;
            attackPower = 20;
            Console.ReadLine();
        }
        public void dinotype2()
        {
            Console.WriteLine(" You chose the Spinosaurus.");
            health = 225;
            energy = 215;
            attackPower = 25;
            Console.ReadLine();
        }
        public void dinotype3()
        {
            Console.WriteLine("You chose the Carnotaurus");
            health = 180;
            energy = 275;
            attackPower = 15;
            Console.ReadLine();
        }


        // member methods
        public void Attack(Robot robotName)
        {
            robotName.health -= attackPower;

            int choice = 0;
            Console.WriteLine("Select your beast to enter the battle with:");
            choice = int.Parse(Console.ReadLine());
        switch (choice)
            {
                case 1:
                    dinotype1();
                    break; 

                case 2:
                    dinotype2();
                    break;

                case 3:
                    dinotype3();
                    break;
                    Console.ReadLine();
            }
            


        }           
    }
}