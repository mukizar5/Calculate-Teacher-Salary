using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTeacher_sSalary
{
    public class Grade
    {
        public enum Grades 
        {
            grade1=0,
            grade2=1,
            grade3=2,
            grade4=3,
            grade5=4, 
            grade6=5, 
            grade7=6,
        }

    
public static decimal CalculateSalaryByGrade(Grade.Grades grade)
{
  decimal salary = 0;
            switch (grade)
            {
                case Grades.grade1:
                    salary = 3000;
                    break;
                case Grades.grade2:
                    salary = 3500;
                    break;
                case Grades.grade3:
                    salary = 4000;
                    break;
                case Grades.grade4:
                    salary = 4500;
                    break;
                case Grades.grade5:
                    salary = 5000;
                    break;
                case Grades.grade6:
                    salary = 5500;
                    break;
                case Grades.grade7:
                    salary = 6000;
                    break;
            }

                    return salary;
            }
       }         
}

