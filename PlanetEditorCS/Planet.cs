using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetEditorCS
{
    class Planet : Object
    {
        //-----VARIABLES-----//
        private bool radiusCheck() { return _radius > 0.0f; }
        private Coordinate _position;
        private float _radius;

        public List<ObjPtr> ObjPtrs; //public static List<ObjectPtr> ObjPtrs; //* copy from the object class 

        //-----METHODS-----//
        public Planet() { }

        public Planet(Planet src) { //*
            Object(src.getName());
            foreach (ObjPtr op in src.ObjPtrs)
            {
                ObjPtrs.Add(op);
            }
        }

        public Planet(String name, float radius) { //*
            //handling an exception
            try {
                Object(name);
                _position = new Coordinate();
                _radius = radius;
                
                if (!radiusCheck()) {
                    System.Console.WriteLine("Radius must be bigger than 0");
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }            
        }

        public Planet(String name, Coordinate position, float radius) { //*
            Object(name);
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
        public void addObject(ObjPtr ptr) { //*
            ObjPtrs.Add(ptr);
        }

        public void removeObject(UInt32 id) { //*
            foreach (ObjPtr optrs in ObjPtrs) {
                foreach (Object optr in optrs) {
                    if (id == optr.getID()) {
                        optrs.ObjPt.Remove(optr);
                    }
                }
            }
        }
        /*public IEnumerator<ObjPtr> GetEnumerator(){
            return ObjPtrs.GetEnumerator();
            }*/

        public virtual void Update(){ //*
            //* later

            foreach (ObjPtr optrs in ObjPtrs) {
                foreach (Object optr in optrs) {
                    //optrs.ObjPt.Remove(optr);
                    System.Console.WriteLine("Obj ID : " + optr.getID() + ", Obj Name " + optr.getName());
                    optr.Update();
                    System.Console.WriteLine("");
                }
            }
        }
    }
}
