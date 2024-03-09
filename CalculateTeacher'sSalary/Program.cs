
using CalculateTeacher_sSalary;

Teacher josh = new Teacher
{
 Name ="josh",
 Email ="josh5@gmail.com",
 BirthDay =new DateOnly(1996, 4, 15),
 Subject = SubjectsTaught.mathematics,
 Status = MaritalStatus.married,
 Grade = Grades.grade5
};

//TODO
//fix leticia

// Teacher leticia = new Teacher(
//     "leticia", 
//     "leticia@yahoo.com",
//     new DateOnly(1992, 03, 23),
//     Status.MaritalStatus.single, 
//     Subjects.SubjectTaught.english
//     );

// leticia.DisplayTeacherDetails();

Teacher leticia = new Teacher
{
    Name = "leticia",
    Email = "leticia@yahoo.com",
    BirthDay = new DateOnly(1987, 6, 3),
    Subject = SubjectsTaught.mathematics,
    Status = MaritalStatus.married,
    Grade = Grades.grade6
};

decimal salary = josh.CalculateSalaryByGrade(josh.Grade);
Console.WriteLine($"The salary received by {josh.Name} is: {salary}");

decimal salaryleticia = leticia.CalculateSalaryByGrade(leticia.Grade);
Console.WriteLine($"The salary received by {leticia.Name} is: {salary}");
