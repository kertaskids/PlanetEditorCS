using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetEditorCS
{
    class Object
    {
        //-----PROPERTIES-----//
        private static Object _instance;
        public static Object Instance
        {
            get {
                return _instance ?? (_instance = new Object());
            }
        }

        private static uint s_next_ID = 0;
        private uint _ID;
        private string _Name;
        
        //public static List<Object> ObjPtr; //affects planet.cs L16  //* ; unsafe instead
        public struct ObjPtr : IEnumerable<Object>
        {
            public List<Object> ObjPt {get;set;}

            public IEnumerator<Object> GetEnumerator() {
                return ((IEnumerable<Object>)ObjPt).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator() {
                return ((IEnumerable<Object>)ObjPt).GetEnumerator();
            }
        };

        //-----METHODS-----//
        public Object(){
            if (_instance==null) {
                _instance = this;
            }
        }

        /*
         Object& operator=(const Object& src);
        The operator= can't be overloaded. 
        Ref : http://stackoverflow.com/questions/599367/why-can-not-be-overloaded-in-c
        public Object(Object src)
        {
            _Name = src._Name;
        }
         */

        public Object(string name)
        {
            _ID = s_next_ID++;
            _Name = name;
        }
        public void ObjectT(string name)
        {
            _ID = s_next_ID++;
            _Name = name;
        }
        
        public Object(Object src) {
            _Name = src._Name;
            _ID = s_next_ID++;
        }
        public void ObjectT(Object src)
        {
            _Name = src._Name;
            _ID = s_next_ID++;
        }

        //public virtual ~Object() { } //* return this; }

        public uint getID() { 
            return _ID; 
        }

        public string getName() { 
            return _Name; 
        } 
        
        public virtual void Update() {}

        //public List<Object> getO() { return ObjPtr; }
    }
}
