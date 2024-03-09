namespace CalculateTeacher_sSalary
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly BirthDay { get; set; }
        public SubjectsTaught Subject;
        public Grades Grade;
        public MaritalStatus Status { get; set; }


        public decimal CalculateSalaryByGrade(Grades grade)
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
                default:
                    salary = 0;
                    break;
            }

            return salary;
        }
    }
}

