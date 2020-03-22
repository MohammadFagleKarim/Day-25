using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.BLL.BLL;

namespace MyEF
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager _studentManager = new StudentManager();
            DepartmentManager _departmentManager = new DepartmentManager();

            //Console.WriteLine("\t\tDepartment");
            //foreach (var department in _departmentManager.GetAll())
            //{
            //    Console.WriteLine("\nDepartment Name:\t" + department.Name + "\n\t\t\t\tStudents");
            //    if (department.students != null && department.students.Any())
            //    {

            //        foreach (var student in department.students)
            //        {
            //            Console.WriteLine("Student RollNo:\t" + student.RollNo + "\tName:\t" + student.Name + "\tAge:\t" + student.Age);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("\t\tNo Student Found!!!");
            //    }
            //}

            //Department department = new Department()
            //{
            //    Name = "ENG",
            //    students = new List<Student>()
            //    {
            //        new Student()
            //        {
            //            RollNo = "009",
            //            Name = "Fazle",
            //            Address = "Mirpur",
            //            Age = 40
            //        },
            //        new Student()
            //        {
            //            RollNo = "010",
            //            Name = "Arafat",
            //            Address = "Mirpur",
            //            Age = 16
            //        }
            //    }
            //};

            //Student student = new Student()
            //{
            //    RollNo = "011",
            //    Name = "Yusuf",
            //    Address = "Mirpur",
            //    Age = 24
            //};

            //department.students.Add(student);

            //_departmentManager.Add(department);

            Console.WriteLine("=================================LINQ===============================");

            int i = 1;

            //SELECT * FROM Student WHERE Age>20 AND Age<30

            var students = _studentManager.GetAll();
            var result = from s in students
                         where s.Age > 20 && s.Age < 30
                         select s;
            
            Console.WriteLine("Sl \t Name \t\t Roll No \t Address \t Age \t Department");
            foreach (var stu in result)
            {
                Console.WriteLine(i + "\t" + stu.Name + "\t\t" + stu.RollNo + "\t\t" + stu.Address + "\t\t" + stu.Age + "\t\t" + stu.DepartmentId);
                i++;
            }

            Console.WriteLine("=====================================================================");

            i = 1;

            Console.WriteLine("Sl \t Name \t\t Roll No \t Address \t Age \t Department");
            foreach (var stu in _studentManager.GetAll())
            {
                Console.WriteLine(i + "\t" + stu.Name + "\t\t" + stu.RollNo + "\t\t" + stu.Address + "\t\t" + stu.Age + "\t\t" + stu.DepartmentId);
                i++;
            }

            //Student student  = new Student()
            //{
            //    RollNo = "002",
            //    Name =  "Yusuf",
            //    Address = "Mirpur",
            //    Age = 20
            //};

            ////Add
            //if (_studentManager.Add(student))
            //{
            //    Console.WriteLine("Saved");
            //}
            //else
            //{
            //    Console.WriteLine("Not Saved");
            //}

            //Delete
            //if (_studentManager.Delete(1))
            //{
            //    Console.WriteLine("Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Not Deleted");
            //}

            //Update
            //student.Id = 2;
            //student.Name = "Md Yusuf";
            ////student.RollNo = "003";
            //student.Address = "Mohakhali";
            //student.Age = 30;
                    

            //if (_studentManager.Update(student))
            //{
            //    Console.WriteLine("Updated");
            //}
            //else
            //{
            //    Console.WriteLine("Not Updated");
            //}
            
            //var  students = _studentManager.GetAll();
            //var astudent = _studentManager.GetById(4);

            Console.ReadKey();
        }
    }
}
