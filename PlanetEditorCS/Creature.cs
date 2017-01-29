using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PlanetEditorCS.Object; //same namepsace, don't need to do 'using'

namespace PlanetEditorCS
{
    class CreatureType {
        //-----METHODS-----//
        public CreatureType() {}
        //public virtual ~CreatureType() { }
        public virtual void Move() { }
        public virtual void Absorb() { }
        public virtual int DeadOrAlive() { return 0; }
        public virtual bool Alive() { return false; }
        public virtual int Birth() { return 0; }
    }

    class Creature <T> : Object
    {
        //-----PROPERTIES-----//
        private static Creature<T> _instance;
        public static Creature<T> Instance
        {
            get
            {
                return _instance ?? (_instance = new Creature<T>());
            }
        }

        private T _p_implement = default(T); //*
        private int _amount = 0;
        CreatureType creatureType = new CreatureType();

        //-----METHODS-----//
        public Creature() {
            if (_instance == null)
            {
                _instance = this;
            }
        }
        /*
        Operator = can't be overloaded 
         */

        public Creature(Creature<T> src) { //*
            ObjectT(src.getName());
            _amount = src._amount;
            _p_implement = src._p_implement; 
        }

        public Creature(string name) { //*
            ObjectT(name);
            _p_implement = Creature<T>.Instance._p_implement;
        }

        /*public virtual ~Creature() {
            if (_p_implement != null){ //* ; null) {
                _p_implement = default(T);
            }
        }*/

        new public virtual void Update() { //*
            Instance.creatureType.Move();
            Instance.creatureType.Absorb();
            _amount -= Instance.creatureType.DeadOrAlive();
            
            if (creatureType.Alive()) {
                _amount += creatureType.Birth();
                _amount = _amount < 0 ? 0 : _amount;
            }
        }
    }
}
