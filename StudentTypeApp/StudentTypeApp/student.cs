using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTypeApp
{
    class Student
    {
        public string regNo;
        public string lastName;
        public string firstName;

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

    }

}
