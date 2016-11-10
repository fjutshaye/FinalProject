using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class Course
    {
        string name;
        string code;
        string classroom;
        ClassTime[] classTime;

        public Course(string name, string code, string classroom, ClassTime[] classTime)
        {
            Console.WriteLine("Creating Course" + name);
        }
    }

    public class Class1
    {
    }
}