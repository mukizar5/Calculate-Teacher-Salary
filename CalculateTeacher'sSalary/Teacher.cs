using static CalculateTeacher_sSalary.Grade;

namespace CalculateTeacher_sSalary
{
    public class Teacher
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateOnly birthDay = new DateOnly();
        

        public enum SubjectTaught;
        public Status.MaritalStatus MStatus { get; set; }


        public Subjects.SubjectTaught subjectTaught { get; set; }


        public  Grade.Grades grad;

    public Teacher(string name, string email, DateOnly birthday, Status.MaritalStatus maritalStatus, Subjects.SubjectTaught subject, Grade.Grades grades)
    {
        Name = name;
        Email = email;
        birthDay = birthday;
        MStatus = maritalStatus; // Corrected from MaritalStatus to MStatus
        subjectTaught= subject;
            grad = grades;
    }

    

   

        public static decimal CalculateSalaryByGrade(Grade.Grades grad)
        {
            decimal salary = 0;
            switch (grad)
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

        public void DisplayTeacherDetails()
        {
            Console.WriteLine($"\nFirst name: \t {Name} \nBirthday: \t{birthDay.ToShortDateString()}\nEmail: {Email}\nMarital Status: {MStatus} \nSubject Taught: {subjectTaught} \tGrade taught: {grad}");
        
        }
    }
    }

