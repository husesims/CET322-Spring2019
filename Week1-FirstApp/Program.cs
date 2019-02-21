using System;

namespace firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Cet322 Class!");
            Student.MiniumumGPA=2;
            Course cet322=new Course();
            cet322.Code="CET322";
            cet322.Credit=4;

            Course cet301=new Course {
                 Code = "CET301",
                 Credit = 3

            };

            Course math101=new Course("Math101",4);


            StudentCourse huseyinCet301=new StudentCourse();
            huseyinCet301.TakenCourse = cet322;
            huseyinCet301.StudentGrade= Grade.BA;

            Student huseyin=new Student {
                 StudentNo ="9902131",
                 FullName ="Hüseyin Şimşek"
            };

            huseyin.Courses.Add(huseyinCet301);
            huseyin.Courses.Add(new StudentCourse(math101, Grade.AA));
            huseyin.Courses.Add(new StudentCourse(cet322, Grade.F));
            
            Console.WriteLine(huseyin.CalculateGPA());

            Console.WriteLine(huseyin.CanGradute());

        }
    }
}
