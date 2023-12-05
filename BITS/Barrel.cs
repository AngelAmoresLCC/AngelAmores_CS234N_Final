using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITS
{
    public class Barrel
    {
        // there are several warnings in this file related to nullable properties and return values.
        // you can ignore them
        public Barrel() { }

        public Barrel(int b_c_id, string treatment)
        {
            brew_container_id = b_c_id;
            Treatment = treatment;
        }

        // this is an auto implemented property
        // it effectively creates a private instance variable
        // and creates "the usual" getter and setter
        // You can't use it when you're doing validation on a property
        public string Treatment { get; set; }

        private int brew_container_id;
        public int Brew_Container_Id
        {
            get
            {
                return brew_container_id;
            }
            set
            {
                // this would normally be == 2 but there's some bad data in the database
                // I didn't realize that until I wrote the test for GetStates in StateDB
                brew_container_id = value;
            }
        }

        public override string ToString()
        {
            return Brew_Container_Id + ", " + Treatment;
        }
    }
}
