using CalculateTeacher_sSalary;
Teacher josh = new Teacher(
 "josh",
 "josh5@gmail.com",
 new DateOnly(1996, 4, 15),
 Status.MaritalStatus.married,
 Subjects.SubjectTaught.mathematics,
 Grade.Grades.grade3
);

Teacher leticia = new Teacher { 
    Name="leticia", 
    Email="leticia@yahoo.com",
    birthday=new DateOnly(1992, 03, 23),
    Status.MaritalStatus.single, 
    Subjects.SubjectTaught.english,
    Grade.Grades.grade6
);

var edema = new Teacher(
    "Edema",
    "micheal@gmail.com",
    new DateOnly(1995, 03, 31),
    Status.MaritalStatus.widower,
    Subjects.SubjectTaught.biology,
    Grade.Grades.grade1
);

leticia.DisplayTeacherDetails();
edema.DisplayTeacherDetails();


