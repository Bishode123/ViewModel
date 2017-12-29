using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel29thDecember.Models;
namespace ViewModel29thDecember.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> stud = new List<Student>
      {
        new Student
        {
            RollNo = 1, Name = "Ankur", marks = 34
        },
        new Student
        {
            RollNo = 2, Name = "Dhrumit", marks = 79
        },
        new Student
        {
            RollNo = 3, Name = "Mannan", marks = 67
        }
    };
            return View(stud);
        }

        public ActionResult getStud()
        {
            List<Student> studs = new List<Student>
      {
        new Student
        {
            RollNo = 1, Name = "Ankur", marks = 34
        },
        new Student
        {
            RollNo = 2, Name = "Dhrumit", marks = 79
        },
        new Student
        {
            RollNo = 3, Name = "Mannan", marks = 67
        }
    };
            List<vmStudMarks> vmSt = new List<vmStudMarks>();
            foreach (Student stud in studs)
            {
                vmStudMarks vm = new vmStudMarks();
                vm.Name = stud.Name;
                vm.Marks = stud.marks.ToString("C");
                if (stud.marks > 35)
                {
                    vm.colorname = "green";
                }
                else
                {
                    vm.colorname = "red";
                }
                vmSt.Add(vm);
            }
            return View("getStud", vmSt);
        }
    }
}