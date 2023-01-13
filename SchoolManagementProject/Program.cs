using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            while (true)
            {
                displaymenu();
                Console.WriteLine("please enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                switch (choice)
                {
                    case 1:
                        school.addStudent();
                        break;
                    case 2:
                        school.addTeacher();
                        break;
                    case 3:
                        school.RemoveStudentFromSemester();
                        break;
                    case 4:
                        school.addBalanceTostudentProfile();
                        break;
                    case 5:
                        school.deductBalanceFromstudentProfile();
                        break;
                    case 6:
                        school.changeStudentCohortNumber();
                        break;
                    case 7:
                        school.incrementTheTeacherExperience(13);
                        break;
                    case 8:
                        school.incrementTheTeacherHours(10);
                        break;
                    case 9:
                        school.decrementTheTeacherHours(10);
                        break;
                    case 10:
                        school.printAllstudentList();
                        break;
                    case 11:
                        school.printAllTeacherList();
                        break;
                    case 12:
                        school.findTeacherswithAboveFiveYearsOfExperience();
                        break;
                    case 13:
                        school.savestudentInformationintoText();
                        break;
                    case 14:
                        school.saveteacherInformationintoText();
                        break;


                }

            }

        }
        public static void displaymenu()
        {
            Console.WriteLine("1.add student");
            Console.WriteLine("2.add teacher");
            Console.WriteLine("3.remove student from the semester");
            Console.WriteLine("4.add balance to student account ");
            Console.WriteLine("5.deduct balance from student account");
            Console.WriteLine("6.change student cohort number");
            Console.WriteLine("7.increment the teacher experience");
            Console.WriteLine("8.increment the teacher hours");
            Console.WriteLine("9.decrement the teacher hours");
            Console.WriteLine("10.print all student list");
            Console.WriteLine("11.print all teacher list");
            Console.WriteLine("12.find teachers above five years of experience");
            Console.WriteLine("13.save student information into a file");
            Console.WriteLine("14.save teacher information into a text file");
        }
    }
}
