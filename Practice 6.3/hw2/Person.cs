using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Person
    {
        public Person(string sID, string sGender, string sPhone, string sLocation) {
            personID = sID;
            personGender = sGender;
            personPhone = sPhone;
            personLcation = sLocation;
        }

        public string personID;
        public string personGender;
        public string personPhone;
        public string personLcation;
    }
}
