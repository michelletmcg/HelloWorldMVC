using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldMVC.Models
{
    public static class StudentDB 
        //created a public static class because we don't need to instantiate a new object Student that has different properties
        //static classes don't change properties they behave the same way

    {
        //create a placeholder method for now
        public static bool AddStudent(Student s)
        {
            //takes a student object s
            //TODO: Add database code here

            //pretend an insert was successful
            return true;
        }
    }
}