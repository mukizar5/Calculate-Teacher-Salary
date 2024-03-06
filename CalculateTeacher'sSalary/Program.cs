
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

decimal salary = josh.CalculateSalaryByGrade(josh.Grade);
Console.WriteLine($"The salary received by {josh.Name} is: {salary}");
