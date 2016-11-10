using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections;

namespace FinalProject
{
    public class User
    {
        string name;
        string selfIntroduction;
        DateTime birthday;
        string program;
        string phoneNum;
        CourseList courseList;

        public User(string name, string selfIntroduction, DateTime birthday, string program, string phoneNum)
        {
            Console.WriteLine("Creating User with parameters");
        }
        public User()
        {
            Console.WriteLine("Creating User without parameters");
        }
    }
}