namespace CalculateTeacher_sSalary
{
    public class Teacher
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateOnly birthDay = new DateOnly();
        

        public enum SubjectTaught;

        

        public enum Grades;

    public Teacher(string name, string email, DateOnly birthday, Status.MaritalStatus maritalStatus, Subjects.SubjectTaught subject)
    {
        Name = name;
        Email = email;
        birthDay = birthday;
        MStatus = maritalStatus; // Corrected from MaritalStatus to MStatus
        subjectTaught= subject;
    }

    public Status.MaritalStatus MStatus { get; set; }


    public Subjects.SubjectTaught subjectTaught{get; set; }

    public void DisplayTeacherDetails()
    {
        Console.WriteLine($"\nFirst name: \t {Name} \nBirthday: \t{birthDay.ToShortDateString()}\nEmail: {Email}\nMarital Status: {MStatus} \nSubject Taught: {subjectTaught}");
    }
    }
    }

