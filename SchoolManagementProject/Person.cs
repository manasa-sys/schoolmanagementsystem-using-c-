using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementProject
{
    abstract class Person
    {
        string firstname;
        string lastname;
        int departmentCode;

        protected Person(string firstname, string lastname, int departmentCode)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.departmentCode = departmentCode;
        }

        public virtual string toString()
        {
            return "first name:" + this.firstname + " " + "lastname:" + this.lastname + " " + " deptcode:" + this.departmentCode;
        }
    }
}
