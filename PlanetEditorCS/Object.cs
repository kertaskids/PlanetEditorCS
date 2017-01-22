using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.UInt32;

namespace PlanetEditorCS
{
    class Object
    {
        private static Object instance = null;
        public static Object _Instance
        {
            get
            {
                return instance; //? ==null? instance : _Instance;
            }
        }

        private static uint s_next_ID;
        private uint _ID;
        private String _Name;

        public Object(){
           // if (_Instance == null) {
             //   instance = this;
            //} //awlays be null?

        } //*
        
        public Object(Object src)
        {
            _Name = src._Name;
        }
        
        public Object(String name)
        {
            _ID = s_next_ID;
            _Name = name;
        }

        public Object(Object src) {
            _Name = src._Name;
            _ID = s_next_ID;
        }

        /*public virtual Object Object()
        {
            return this;
        }*/

        public uint getID() { return _ID; } //*
        public String getName() { return _Name; } //*
        
        public virtual void Update() {}

        public static List<Object> ObjPtr; //* ; unsafe instead
        public List<Object> getO() { return ObjPtr; }
    }
}
