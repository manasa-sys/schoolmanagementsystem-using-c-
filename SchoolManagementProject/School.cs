using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementProject
{
    class School
    {
        public School() { }
        Students mystudents = new Students();
        Teachers myTeachers = new Teachers();

        public bool studentidVerifier(string studentid)
        {
            bool flag = false;
            foreach (Student student in mystudents)
            {
                if (student.getId() == studentid)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool teacheridVerifier(string teacherid)
        {
            bool flag = false;
            foreach (Teacher teacher in myTeachers)
            {
                if (teacher.getId() == teacherid)
                {
                    flag = true;
                }
            }
            return flag;

        }

        public bool getsemesteridfromstudentid(string std)
        {
            bool flag = false;
            string semesterid = "";
            foreach (Student student in mystudents)
            {
                if (student.StudentId == std)
                {
                    semesterid = student.SemesterId;
                    flag = true;
                }
            }
            return flag;
        }
        /* public bool semesteridVerifier(string semesterid)
         {
             bool flag = false;
             foreach (Student student in mystudents)
             {
                 if (student.SemesterId == semesterid)
                 {
                     flag = true;
                 }
             }
             return flag;

         }*/


        public void addStudent()
        {
            Console.WriteLine("please enter the student id");
            string studentid = Console.ReadLine();
            if (studentid.Length != 6)
            {
                Console.WriteLine("error! id should be exactly 6 characters");
            }
            else
            {
                if (studentidVerifier(studentid) == true)
                {
                    Console.WriteLine("error! id already exists!!!!");
                }
                else
                {
                    Console.WriteLine("Please enter the cohortnumber");
                    string cohortnum = Console.ReadLine();
                    if (cohortnum.Length != 6)
                    {
                        Console.WriteLine("Error!! length should be exactly 6 characters");
                    }
                    else
                    {
                        Console.WriteLine("Please enter the balance");
                        double balance = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("please enter the semester id");
                        string semesterid = Console.ReadLine();
                        if (semesterid.Length != 6)
                        {
                            Console.WriteLine("Error!length should be 6 cahracters!!");
                        }
                        else
                        {

                            Console.WriteLine("please enter the firstname");
                            string fname = Console.ReadLine();
                            Console.WriteLine("please enter the last name");
                            string lname = Console.ReadLine();
                            if (fname.Length + lname.Length > 70)
                            {
                                Console.WriteLine("total length cannot exceed 70 caharacters");
                            }
                            else
                            {
                                Console.WriteLine("please enter the departmentcode");
                                int deptCode = Convert.ToInt32(Console.ReadLine());

                                Student student = new Student(studentid, cohortnum, balance, semesterid, fname, lname, deptCode);
                                mystudents.add(student);
                                Console.WriteLine("student added successfully");
                            }

                        }
                    }
                }

            }
        }

        public void addTeacher()
        {
            Console.WriteLine("Please enter the teacherid");
            string teachid = Console.ReadLine();
            if (teachid.Length != 6)
            {
                Console.WriteLine("error id should be exactly 6 characters");
            }
            else
            {
                if (teacheridVerifier(teachid) == true)
                {
                    Console.WriteLine("Error! id already exists");
                }
                else
                {
                    Console.WriteLine("please enter years of experience");
                    int yearsofexperience = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the teaching hours");
                    double teachhours = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("please enter the firstname");
                    string fname = Console.ReadLine();
                    Console.WriteLine("please enter the lastname");
                    string lname = Console.ReadLine();
                    if (fname.Length + lname.Length > 70)
                    {
                        Console.WriteLine("error!! length of name cannot be more than 70 characters!!");
                    }
                    else
                    {
                        Console.WriteLine("please enter the departmentcode");
                        int deptcode = Convert.ToInt32(Console.ReadLine());
                        Teacher teacher = new Teacher(teachid, yearsofexperience, teachhours, fname, lname, deptcode);
                        myTeachers.add(teacher);
                        Console.WriteLine("Teacher added successfully!!");
                    }
                }
            }
        }

        public void RemoveStudentFromSemester()
        {
            Console.WriteLine("Please enter your student ID");
            string studentID = Console.ReadLine();
            if (studentidVerifier(studentID) != true)
            {
                Console.WriteLine("Error! This stduent ID does not exist!");
            }
            else
            {
                Console.WriteLine("Please enter your semester ID:");
                string semesterID = Console.ReadLine();

                for (int i = 0; i < mystudents.Count; i++)
                {
                    if (mystudents[i].StudentId == studentID)
                    {
                        mystudents.RemoveAt(i);
                        Console.WriteLine("This student have been remove from this semester.");
                    }
                }

            }
        }
        /* public void removeStudentFromSemester()
         {
             Console.WriteLine("please enter the studentid");
             string studentid=Console.ReadLine();
             Console.WriteLine("please enter the semester id of the student");
             string semesterid=Console.ReadLine();

             foreach(Student student in mystudents)
             {
                 if (student.getId() == studentid)
                 {
                     if (getsemesteridfromstudentid(semesterid)==true)
                     {
                         mystudents.RemoveAt(student);



                     }
                 }

             }  
         }*/

        public void addBalanceTostudentProfile()
        {
            Console.WriteLine("please enter the amount");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the studentid");
            string studid = Console.ReadLine();
            foreach (Student student in mystudents)
            {
                if (student.getId() == studid)
                {
                    student.Balance = student.Balance + amount;
                }
            }
            Console.WriteLine("balance added succesfully");
        }

        public void deductBalanceFromstudentProfile()
        {
            Console.WriteLine("please enter the amount");
            double amount = Convert.ToDouble(Console.ReadLine());
            double balance = 0.0;
            Console.WriteLine("please eenter the studentid");
            string studid = Console.ReadLine();
            foreach (Student student in mystudents)
            {
                if (student.getId() == studid)
                {
                    student.Balance -= amount;
                }
            }
            Console.WriteLine("balance deducted succesfully");
        }



        public void changeStudentCohortNumber()
        {
            Console.WriteLine("please enter the student id");
            string studentid = Console.ReadLine();
            Console.WriteLine("please enter the cohort number to change");
            string cohortnum = Console.ReadLine();
            foreach (Student student in mystudents)
            {
                if (student.getId() == studentid)
                {
                    student.CohortNumber = cohortnum;

                }
            }
            Console.WriteLine("cohortnumber changed successfully");
        }

        public void incrementTheTeacherExperience(int month)
        {

            Console.WriteLine("please enter the teacherid");
            string teacherid = Console.ReadLine();
            int years = month / 12;

            foreach (Teacher teacher in myTeachers)
            {

                if (teacher.getId() == teacherid)
                {
                    if (month < 12)
                    {
                        teacher.YearsOfExperinece = 0;
                    }
                    else
                    {
                        teacher.YearsOfExperinece += years;
                    }

                    Console.WriteLine("incremented successfully");
                }
            }

        }

        public void incrementTheTeacherHours(int hours)
        {

            Console.WriteLine("please enter the teacherid");
            string teacherid = Console.ReadLine();
            foreach (Teacher teacher in myTeachers)
            {
                if (teacher.getId() == teacherid)
                {
                    teacher.TeachingHours += hours;
                }
            }

        }

        public void decrementTheTeacherHours(int hours)
        {

            Console.WriteLine("please enter the teacherid");
            string teacherid = Console.ReadLine();

            foreach (Teacher teacher in myTeachers)
            {

                if (teacher.TeachingHours < hours)
                {
                    Console.WriteLine("cannot deduct the teach hours");
                }
                if (teacher.getId() == teacherid)
                {
                    teacher.TeachingHours -= hours;
                }
            }

        }
        public void printAllstudentList()
        {
            foreach (Student student in mystudents)
            {
                Console.WriteLine(student.toString());
            }

        }

        public void printAllTeacherList()
        {
            foreach (Teacher teacher in myTeachers)
            {
                Console.WriteLine(teacher.toString());
            }

        }

        public void findTeacherswithAboveFiveYearsOfExperience()
        {
            foreach (Teacher teacher in myTeachers)
            {
                if (teacher.YearsOfExperinece >= 5)
                {
                    Console.WriteLine(teacher.toString());
                }
                else
                {
                    Console.WriteLine("no data available");
                }
            }

        }
        public void savestudentInformationintoText()
        {
            string msg = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\LASALLE COLLEGE\SEMESTER 3\Multi tier Applications\My class files\students.txt"))
                {
                    foreach (Student student in mystudents)
                    {
                        sw.WriteLine(student.toString());
                    }
                    Console.WriteLine("record added successfully");

                }
            }
            catch (Exception e)
            {
                msg = e.ToString();
            }
        }
        public void saveteacherInformationintoText()
        {
            string msg = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\LASALLE COLLEGE\SEMESTER 3\Multi tier Applications\teachers.txt"))
                {
                    foreach (Teacher teacher in myTeachers)
                    {
                        sw.WriteLine(teacher.toString());
                    }
                    Console.WriteLine("record added successfully");

                }
            }
            catch (Exception e)
            {
                msg = e.ToString();
            }
        }

    }
}
