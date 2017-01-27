﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PlanetEditorCS
{
    class main
    {
        static void Main(string[] args)
        {
            string command = null;
            Planet p = null;

            while (!command.Equals("exit")) // Loop indefinitely
            {
                if (command.Equals("cp")) {
                    float r;
                    Coordinate pos;
                    string name;
                    string[] input = System.Console.ReadLine().Split(' ');
                    name = input[0];
                    pos = new Coordinate(float.Parse(input[1]), float.Parse(input[2]), float.Parse(input[3]));
                    r = float.Parse(input[4]);

                    try{
                        p = new Planet(name, pos, r);
                        System.Console.WriteLine(p.obj.getName() + " has been created.");
                    
                    }catch (Exception e)
                    {
                        if (p != null) {
                            p = null;
                        }
                        Console.WriteLine("{0} You shall not pass!!.", e);
                    }

                }
                else if (command.Equals("ac")) {
                    string c_type;
                    string name;
                    string[] input = System.Console.ReadLine().Split(' ');
                    c_type = input[0];
                    name = input[1];
                    Object optr;
                    if (c_type == "Lion") {
                        optr = new Creature<Lion>(name)._object;
                    }
                    else if (c_type == "Plant"){
                        optr = new Creature<Plant>(name)._object;
                    }else {
                        System.Console.WriteLine("You shall not pass!");
                        continue;
                    }
                    
                    if (p == null)
                    {
                        System.Console.WriteLine("Please create planet first!");
                        continue;
                    }else {
                        p.addObject(optr);
                        System.Console.WriteLine(optr.getName()+" added");
                    }
                }
                else if (command.Equals("ro")) {
                    uint id;
                    id = uint.Parse(System.Console.ReadLine());
                    if (p == null){
                        System.Console.WriteLine("Please create planet first!");
                    }
                    else {
                        p.Update();
                    }
                }
                else if (command.Equals("up")) {
                    if (p == null)
                    {
                        System.Console.WriteLine("Please create planet first!");
                    }
                    else
                    {
                        p.Update();
                    }
                }
            }

            //System.Console.ReadKey();
            return;
        }
    }

    class Lion : CreatureType {
        public Lion() { }
        public virtual ~Lion() { }
        public virtual void Move() { System.Console.WriteLine("Run Run Run"); }
        public virtual void Absorb() { System.Console.WriteLine("Eat Eat Eat"); }
        public virtual int DeadOrAlive() { System.Console.WriteLine("Alive"); return 0; }
        public virtual bool Alive() { return true; }
        public virtual int Birth() { return 0; }
    }

    class Plant : CreatureType {
        public Plant() { }
        public virtual ~Plant() { }
        public virtual void Move() { System.Console.WriteLine("Plant cannot move :("); }
        public virtual void Absorb() { System.Console.WriteLine("Growth"); }
        public virtual int DeadOrAlive() { System.Console.WriteLine("Alive"); return 0; }
        public virtual bool Alive() { return true; }
        public virtual int Birth() { System.Console.WriteLine("Spread seeds"); return 0; }
    } 
}
