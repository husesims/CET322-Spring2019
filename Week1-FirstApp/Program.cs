using System;
using System.Threading;
using System.Threading.Tasks;

namespace firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Hello Cet322 Class!");
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

           

            GradStudent mehmet=new GradStudent {
                 StudentNo ="2013121",
                 FullName ="Mehmet Şimşek"
            };

           
            mehmet.Courses.Add(new StudentCourse(math101, Grade.AA));
            mehmet.Courses.Add(new StudentCourse(cet322, Grade.BA));

      GradStudent gs2;
        Student s2;

        s2=mehmet;
       
        gs2=huseyin;
        


            Print(mehmet);
            Print(huseyin);
            */
            var starTime=DateTime.Now;
            Calculate1();
            Calculate2();
            Calculate3();
            var sure=DateTime.Now-starTime;
            Console.WriteLine("Toplam ms:" + sure.TotalSeconds);

           Calculator().GetAwaiter().GetResult();
            
        }
        public static async Task Calculator() {
            var starTime2=DateTime.Now;

            Task Calc1=Calculate1Async();
            Task Calc2=Calculate2Async();
            Task<int> Calc3=Calculate3Async();

            await Calc1;
            await Calc2;
            await Calc3;
            /*
            await Calculate1Async();
            await Calculate2Async();
            await Calculate3Async();
            
            var sure2=DateTime.Now-starTime2;
            Console.WriteLine("Toplam ms:" + sure2.TotalSeconds);
*/
        }

        public static void Print(Student student) {
            Console.WriteLine($" Adı :{student.FullName} GPA : {student.CalculateGPA()} Meznuniyet : {student.CanGradute()}");
        }

        public static void Calculate1() {
              Console.WriteLine("Calculate 1 Start " + DateTime.Now.ToLongTimeString());
            Thread.Sleep(2000);
            Console.WriteLine("Calculate 1 End " + DateTime.Now.ToLongTimeString());
        }

         public static void Calculate2() {
               Console.WriteLine("Calculate 2 Start " + DateTime.Now.ToLongTimeString());
           Thread.Sleep(3000);
               Console.WriteLine("Calculate 2 End " + DateTime.Now.ToLongTimeString());
    
        }

         public static int Calculate3() {
               Console.WriteLine("Calculate 3 Start " + DateTime.Now.ToLongTimeString());

           Thread.Sleep(1000);
               Console.WriteLine("Calculate 3 End " + DateTime.Now.ToLongTimeString());
           
            return 3;
        }

         public static async Task Calculate1Async() {
               Console.WriteLine("Calculate 1 Start " + DateTime.Now.ToLongTimeString());

             await Task.Delay(2000);
               Console.WriteLine("Calculate 1 End " + DateTime.Now.ToLongTimeString());
          
        }

         public static async Task Calculate2Async() {
                 Console.WriteLine("Calculate 2 Start " + DateTime.Now.ToLongTimeString());
             await Task.Delay(3000);
               Console.WriteLine("Calculate 2 End " + DateTime.Now.ToLongTimeString());          
        }
       

        public static async Task<int> Calculate3Async() {
                Console.WriteLine("Calculate 3 Start " + DateTime.Now.ToLongTimeString());
             await Task.Delay(1000);
            Console.WriteLine("Calculate 3 End "  + DateTime.Now.ToLongTimeString());
            return 3;
        }
       

    }
}
