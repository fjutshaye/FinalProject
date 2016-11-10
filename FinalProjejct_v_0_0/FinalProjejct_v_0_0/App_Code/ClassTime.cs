using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace FinalProject
{
    public class ClassTime
    {
        string dayOfWeek;
        int startHour;
        int startMin;
        int endHour;
        int endMin;

        public ClassTime(string dayOfWeek, int startHour, int endHour, int endMin)
        {
            Console.WriteLine("Creating ClassTime");
        }
    }
}