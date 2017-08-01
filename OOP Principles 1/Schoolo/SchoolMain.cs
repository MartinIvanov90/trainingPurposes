using Schoolo.School;
using System;


namespace Schoolo
{
    class SchoolMain
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Mincho");
            teacher.AddDiscipline("matematika", 5, 5);
            teacher.AddDiscipline("geografiq", 5, 5);
            teacher.AddDiscipline("istoriq", 5, 5);
            Teacher teacherTwo = new Teacher("Stoimen");
            teacherTwo.AddDiscipline("matematika", 5, 5);
            teacherTwo.AddDiscipline("geografiq", 5, 5);
            teacherTwo.AddDiscipline("istoriq", 5, 5);
            Class klas = new Class("1a");
            klas.AddTeacher(teacher);
            klas.AddTeacher(teacherTwo);
            Student ucheniche = new Student("Genovev", klas);
            Console.WriteLine(ucheniche.ToString());
            Schule school = new Schule();
            school.AddClass(klas);
            Console.WriteLine(school.ToString());
        }
    }
}
