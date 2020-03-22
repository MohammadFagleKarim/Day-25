using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Model.Model;
using WebApp.BLL.BLL;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        StudentManager _StudentManager = new StudentManager();
 
        //public string Add(string rollNo, string name, string address, int? age, int? departmentId)

        [HttpGet]
        public ActionResult Add()
        {
            Student student = new Student();

            return View(student);
        }
        
        [HttpPost]
        public ActionResult Add(Student student)
        {
            string message = "<h5> Student Information </ h5><br / >";

            //message += "<br / > Roll No: " + student.RollNo;
            //message += "<br / > Name: " + student.Name;
            //message += "<br / > Address: " + student.Address;
            //message += "<br / > Age: " + student.Age;
            //message += "<br / > Department " + student.DepartmentId;

            if(_StudentManager.Add(student))
            {
                message = "Saved";
            }
            else
            {
                message = "Not Saved";
            }

            ViewBag.Message = message;

            return View(student);
        }
    }
}