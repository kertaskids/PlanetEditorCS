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
        public virtual ~CreatureType() { }
        public virtual void Move() { }
        public virtual void Absorb() { }
        public virtual int DeadOrAlive() { return 0; }
        public virtual bool Alive() { return false; }
        public virtual int Birth() { return 0; }
    }

    class Creature <T> : Object
    {
        //-----PROPERTIES-----//
        public Object _object; //*
        private int _p_implement = 0; //*
        private int _amount = 0;
        CreatureType creatureType = new CreatureType();

        //-----METHODS-----//
        public Creature();
        //overload operator
        public Creature(Creature<T> src) { //*
            _object = new Object(src._object.getName());
            _amount = src._amount;
            _p_implement = src._p_implement;
        }

        public Creature(String name) { //*
            _object = new Object(name);
        }

        public virtual ~Creature() {
            if (_p_implement != 0){ //null) {
                _p_implement = 0;
            }
        }

        public virtual void Update() { //*
            creatureType.Move();
            creatureType.Absorb();
            _amount -= creatureType.DeadOrAlive();
            if (creatureType.Alive()) {
                _amount += creatureType.Birth();
                _amount = _amount < 0 ? 0 : _amount;
            }
        }
    }

}
