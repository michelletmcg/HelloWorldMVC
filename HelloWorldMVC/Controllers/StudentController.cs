using HelloWorldMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class StudentController : Controller
        
        
        //a GET request to the URL 
    {   //when navigates to a URL and user first sees the webpage form
        //when student/index is found in the route
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //This will get called after a user submits an HTML form
        //After the user posts data to the server
        [HttpPost]
        public ActionResult Index(FormCollection studentData)  //formCollection has all the data from the form so we pass it as a parameter
        {
            //1. Validate all form data

            //2. Encapsulate form data in object | we added a Using so we don't have to code Models.Student. We used the lightbulb to refactor
            //Using HelloWorldMVC.Models
            Student stu = new Student
            {
                StudentId = studentData["sid"],
                FirstName = studentData["firstName"],
                LastName = studentData["lastName"],
                DateOfBirth = Convert.ToDateTime(studentData["dob"])
            };

            //3. If everything is valid, add to database
            if (StudentDB.AddStudent(stu))

            {   //ViewBag data only works for the current request
                ViewBag.StudentAdded = true;
            }

                //4. let the user know it was successful OR display error messages
                return View();
        }
    }
}