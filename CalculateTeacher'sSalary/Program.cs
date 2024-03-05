using CalculateTeacher_sSalary;
Teacher josh = new Teacher(
 "josh",
 "josh5@gmail.com",
 new DateOnly(1996, 4, 15),
 Status.MaritalStatus.married,
  Subjects.SubjectTaught.mathematics

);

Teacher leticia = new Teacher(
    "leticia", 
    "leticia@yahoo.com",
    new DateOnly(1992, 03, 23),
    Status.MaritalStatus.single, 
    Subjects.SubjectTaught.english);

leticia.DisplayTeacherDetails();

Grade.Grades teacherGrade = Grade.Grades.grade5; // Assuming the teacher teaches grade 5
decimal salary = Grade.CalculateSalaryByGrade(teacherGrade);
Console.WriteLine($"The salary recieved by the teacher for teaching {teacherGrade} is: {salary}");
