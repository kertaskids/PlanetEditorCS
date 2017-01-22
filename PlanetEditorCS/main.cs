using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                }
                else if (command.Equals("ac")) {

                }
                else if (command.Equals("ro")) {

                }
                else if (command.Equals("up")) { 
                
                }
            }

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
