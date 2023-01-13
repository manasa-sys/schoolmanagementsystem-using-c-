using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementProject
{
    class Teacher : Person
    {
        string teacherId;
        int yearsOfExperience;
        double teachingHours;

        public Teacher(string teacherId, int yearsOfExperience, double teachingHours, string firstname,
            string lastname, int departmentCode) : base(firstname, lastname, departmentCode)
        {
            this.teacherId = teacherId;
            this.yearsOfExperience = yearsOfExperience;
            this.teachingHours = teachingHours;
        }

        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }
        public int YearsOfExperinece
        {
            get { return yearsOfExperience; }
            set { yearsOfExperience = value; }
        }
        public double TeachingHours
        {
            get { return teachingHours; }
            set { teachingHours = value; }
        }
        public override string toString()
        {
            return base.toString() + " " + "teacher id:" + this.teacherId + " " + "years of experiene:" + this.yearsOfExperience + " " + "teachinghours:" + this.TeachingHours;
        }
        public string getId()
        {
            return this.teacherId;
        }
        public int getYearsOfExperience()
        {
            return this.yearsOfExperience;
        }

        public double getTeachingHours()
        {
            return this.teachingHours;
        }

    }
}
