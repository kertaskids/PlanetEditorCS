/*              
 *               _________________________
 *	            |____   ____    ____   ___|
 *	                /  /   /    \   | |
 *	               /  /   /  /\  \  | |
 *	              /  /   /  /__\  \ | |
 *	             /  /___/  _____   \| |
 *	            |_________/      \____|
 *            Created by ZAT, copyright 2017. 
 *     Feel free to use and modify the source codes. 
 */

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
            string command = null;
            Planet p = null;
            Console.WriteLine("============================================================================");
            Console.WriteLine("Welcome to the planet simulator. Following are available commands : ");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("'cp' to create planet. Then, input : <planet> <pos.x> <pos.y> <pos.z> <radius>");
            Console.WriteLine("'ac' to assign creature.Then, input <creature type> <name>");
            Console.WriteLine("'ro' assign ID. Then, input <object/creature ID>");
            Console.WriteLine("'up' to update");
            Console.WriteLine("============================================================================");
            Console.WriteLine("Please initial command!");

            command = System.Console.ReadLine();

            while (!command.Equals("exit")) // Loop indefinitely
            {
                if (command.Equals("cp")) {
                    float r;
                    Coordinate pos; //=new Coordinate();
                    string name;
                    Console.Write("Create Planet. Input -> name x y z radius : ");
                    string[] input = System.Console.ReadLine().Split(' ');
                    name = input[0];
                    pos = new Coordinate(float.Parse(input[1]), float.Parse(input[2]), float.Parse(input[3]));
                    r = float.Parse(input[4]);

                    System.Console.WriteLine(input.Length+", Planet : "+name+","+ float.Parse(input[1]) + "," + float.Parse(input[2]) + "," + float.Parse(input[3]) + "," + float.Parse(input[4]));
                    try {
                        p = new Planet(name, pos, r);
                        System.Console.WriteLine(p.getName() + " has been created.");
                    
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
                    Console.Write("Assign Creature. Input -> type name : ");
                    string[] input = System.Console.ReadLine().Split(' ');
                    c_type = input[0];
                    name = input[1];
                    System.Console.WriteLine("type "+input[0]+", name "+input[1]);

                    Planet.ObjPtr obj; //PlanetEditorCS.Object.ObjPtr
                    obj = new Object.ObjPtr();
                    //Object optr;
                    
                    if (c_type == "Lion") {
                        if (obj.ObjPt == null) {
                            obj.ObjPt = new List<Object>();
                        }
                        obj.ObjPt.Add(new Creature<Lion>(name));
                        //optr = new Creature<Lion>(name);
                        Console.WriteLine("Created a creature ({0}-{1}).", c_type, name);
                    }
                    else if (c_type == "Plant"){
                        if (obj.ObjPt == null) {
                            obj.ObjPt = new List<Object>();
                        }
                        obj.ObjPt.Add(new Creature<Plant>(name));
                        //optr = new Creature<Plant>(name);
                        Console.WriteLine("Created a creature ({0}-{1}).", c_type, name);
                    }else {
                        System.Console.WriteLine("You shall not pass!");
                        continue;
                    }
                    
                    if (p == null)
                    {
                        System.Console.WriteLine("Please create planet first!");
                        continue;
                    }else {
                        p.addObject(obj);
                        //p.addObject(optr);
                        System.Console.WriteLine(obj.ObjPt[0].getName()+" added");
                    }
                }
                else if (command.Equals("ro")) {
                    uint id;
                    Console.Write("Assign ID. Input -> ID : ");
                    id = uint.Parse(System.Console.ReadLine());
                    if (p == null){
                        System.Console.WriteLine("Please create planet first!");
                    }
                    else {
                        p.Update();
                    }
                }
                else if (command.Equals("up")) {
                    //Console.WriteLine("Updating...");
                    if (p == null)
                    {
                        System.Console.WriteLine("Please create planet first!");
                    }
                    else
                    {
                        p.Update();
                    }
                }
                Console.Write("\nInsert command : ");
                command = System.Console.ReadLine();
            }

            
            //System.Console.ReadKey();
            return;
        }
    }

    class Lion : CreatureType {
        public Lion() { }
        //public virtual ~Lion() { }
        new public virtual void Move() { System.Console.WriteLine("Run Run Run"); }
        new public virtual void Absorb() { System.Console.WriteLine("Eat Eat Eat"); }
        new public virtual int DeadOrAlive() { System.Console.WriteLine("Alive"); return 0; }
        new public virtual bool Alive() { return true; }
        new public virtual int Birth() { return 0; }
    }

    class Plant : CreatureType {
        public Plant() { }
        //public virtual ~Plant() { }
        new public virtual void Move() { System.Console.WriteLine("Plant cannot move :("); }
        new public virtual void Absorb() { System.Console.WriteLine("Growth"); }
        new public virtual int DeadOrAlive() { System.Console.WriteLine("Alive"); return 0; }
        new public virtual bool Alive() { return true; }
        new public virtual int Birth() { System.Console.WriteLine("Spread seeds"); return 0; }
    } 
}
