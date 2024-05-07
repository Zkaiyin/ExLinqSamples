static List<TeacherInfo> CreateTeachers()
{
    return new List<TeacherInfo>()
    {
        new TeacherInfo {ClassName ="1A" , CreateTeachers ="Bill"},
        new TeacherInfo {ClassName ="1B" , CreateTeachers ="David"}
    };
}
static List<studentInfo> CreateStudents()
{
    return new List<StudentInfo>()
    {
        new StudentInfo {ClassName ="1A" , CreateStudents ="魯夫"},
        new StudentInfo {ClassName ="1A" , CreateStudents ="索隆"},
        new StudentInfo {ClassName ="1B" , CreateStudents ="櫻木"},
        new StudentInfo {ClassName ="1A" , CreateStudents ="香吉士"},
        new StudentInfo {ClassName ="1B" , CreateStudents ="流川風"},
    }
}
static void Main(string[] args)
     {
     var teachers = CreateTeachers();
     var students = CreateStudents();
     var result = from t in teachers
                  join s in students
                  on t.ClassName equals s.ClassName
                  select
                  new ResultInfo
          { ClassName = t.ClassName, teachers = t.teachers, Student = s.Students };
          foreach (var item in result)
          {
          Console.WriteLine($"{item.ClassName}:{item.Teacher}:{item.Student});
          }
           Console.ReadLine();
}
