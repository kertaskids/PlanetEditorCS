using System;
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
            System.Console.WriteLine("Hello!");
            String command = null;
            Planet p = null;

            while (!command.Equals("exit")) // Loop indefinitely
            {
                if (command.Equals("cp")) {
                    float r;
                    Coordinate pos;
                    String name;
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
        virtual ~Lion() { }
        virtual void move() { System.Console.WriteLine ("Run Run Run"); }
        virtual void absorb() { System.Console.WriteLine("Eat Eat Eat"); }
        virtual int deadOrAlive() { System.Console.WriteLine("Alive"); return 0; }
        virtual bool alive() { return true; }
        virtual int birth() { return 0; }
    }

    class Plant : CreatureType {
        Plant() { }
        virtual ~Plant() { }
        virtual void move() { System.Console.WriteLine("Plant cannot move :("); }
        virtual void absorb() { System.Console.WriteLine("Growth"); }
        virtual int deadOrAlive() { System.Console.WriteLine("Alive"); return 0; }
        virtual bool alive() { return true; }
        virtual int birth() { System.Console.WriteLine ("Spread seeds"); return 0; }
    } 
}
