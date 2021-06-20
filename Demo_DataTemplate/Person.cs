using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Persons_Demo
{
    public class Person
    {
        private DateTime _time;

        public DateTime Birthday
        {
            get { return _time; }
            set { _time = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public Person()
        { }
    }
}
