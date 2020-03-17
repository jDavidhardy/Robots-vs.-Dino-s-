using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    public class Fleet
    {
        public List<Robot> robotFleet;              
        public Robot robotName1;                              
        public Robot robotName2;                                                  
        public Robot robotName3;                                        

        public Fleet()
        {
            robotFleet = new List<Robot>();                             
            robotName1 = new Robot("Maximillion", "Bite Force" , 50);            
            robotName2 = new Robot("Malachi", "Cloak" , 10);                
            robotName3 = new Robot("Gethin", "Hook Claw" , 25);     
            robotFleet.Add(robotName1);                    // .(dot) Notation
            robotFleet.Add(robotName2);                    // .(dot) Notation
            robotFleet.Add(robotName3);                    // .(dot) Notation
        }

        ////member variables
        //public int health;
        //public int powerLevel;
        //public int attackPower;
        //public string name;
        //public string weapon;

        ////constructor
        //public Fleet(string robotName, int atkpow, string weaponType)
        //{
        //    health = 100;
        //    powerLevel = 100;
        //    attackPower = atkpow;
        //    name = robotName;
        //    weapon = weaponType;
        //}
        //public void Robot1()
        //{
        //    Console.WriteLine("You selected Maximillion, the robot Indominus Rex.");
        //    health = 500;
        //    powerLevel = 350;
        //    attackPower = 20;
        //    //weaponType =  ;
        //    Console.ReadLine();
        //}
        //public void Robot2()
        //{
        //    Console.WriteLine(" You selected Malachi, the robot Rajasaurus.");
        //    health = 300;
        //    powerLevel = 105;
        //    attackPower = 25;
        //    //weaponType =  ;
        //    Console.ReadLine();
        //}
        //public void Robot3()
        //{
        //    Console.WriteLine("You selected Gethin, the robot Velociraptor.");
        //    health = 220;
        //    powerLevel = 215;
        //    attackPower = 15;
        //    //weaponType =  ;
        //    Console.ReadLine();
        //}


        //// member methods
        //public void Attack(Robot robotName)
        //{
        //    robotName.health -= attackPower;

        //    int choice = 0;
        //    Console.WriteLine("Select your beast to enter the battle with:");
        //    choice = int.Parse(Console.ReadLine());
        //    switch (choice)
        //    {
        //        case 1:
        //            Robot1();
        //            break;

        //        case 2:
        //            Robot2();
        //            break;

        //        case 3:
        //            Robot3();
        //            break;
        //            Console.ReadLine();
        //    }

    }
    
}
