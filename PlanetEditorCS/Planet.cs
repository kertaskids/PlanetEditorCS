using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetEditorCS
{
    class Planet
    {
        private Coordinate _position;
        private float _radius;
        private Object obj;
        //public static List<Object> ObjPtr; //* 
        private bool radiusCheck() { return _radius > 0.0f; }

        public Planet() { }
        
        public Planet(Planet src) { //*
            obj = new Object(src.obj.getName());
            foreach (Object op in src.obj.getO())
            {
                obj.getO().Add(op);
            }
        }

        public Planet(String name, float radius) { //*
            obj = new Object(name);
            _position = new Coordinate();
            _radius = radius;
            if (!radiusCheck()) {
                System.Console.WriteLine("Radius must be bigger than 0");
            }
        }

        public Planet(String name, Coordinate position, float radius) { //*
            obj = new Object(name);
            _position = position;
            _radius = radius;
            if (!radiusCheck())
            {
                System.Console.WriteLine("Radius must be bigger than 0");
            }
        }

        public void setPosition(Coordinate position) {
            _position = position;
        }

        public void setRadius(float radius) { //*
            _radius = radius;
        }
        public void addObject(Object o) { //*
            o.getO().Add(o);
        }

        public void removeObject(UInt32 id) { //*
            foreach (Object o in obj.getO()) {
                if (id == o.getID()) {
                    obj.getO().Remove(o);
                }
            }
        }

        public virtual void Update(){ //*
            //* later
            foreach (Object o in obj.getO()) { 
                System.Console.WriteLine(o.getID()+" "+o.getName());
                o.Update();
            }
        }
    }
}
