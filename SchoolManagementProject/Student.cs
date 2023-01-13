using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementProject
{
    class Student : Person
    {
        string studentId;
        string cohortNumber;
        double balance;
        string semesterId;

        public Student(string studentId, string cohortNumber, double balance, string semesterId, string firstname, string lastname, int departmentCode) : base(firstname, lastname, departmentCode)
        {
            this.studentId = studentId;
            this.cohortNumber = cohortNumber;
            this.balance = balance;
            this.semesterId = semesterId;
        }

        public string StudentId
        {
            get { return this.studentId; }
            set { this.studentId = value; }
        }
        public string CohortNumber
        {
            get { return this.cohortNumber; }
            set { this.cohortNumber = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public string SemesterId
        {
            get { return this.semesterId; }
            set
            {
                this.semesterId = value;
            }
        }
        public string getId()
        {
            return this.studentId;
        }

        public override string toString()
        {
            return base.toString() + "  " + "studentid:" + this.studentId + " " + "cohortnumber:" + this.cohortNumber + " " + "balance:" + this.balance + " " + "semesterid:" + this.semesterId;
        }

        public string getCohortNumber()
        {
            return this.cohortNumber;
        }
        public double getBalance()
        {
            return this.balance;
        }


    }
}
