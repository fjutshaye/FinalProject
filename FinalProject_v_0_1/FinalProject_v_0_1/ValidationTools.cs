using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_v_0_1
{
    public static class ValidationTools
    {
        public static bool chequeDestination(string str)
        {
            //check Destination
            string destination = str;
            bool cheque =
                destination.Equals("") ||
                destination.Contains("%") ||
                destination.Contains("?") ||
                destination.Contains("$") ||
                destination.Contains("<") ||
                destination.Contains(">") ||
                destination.Contains("{") ||
                destination.Contains("}") ||
                destination.Contains("^") ||
                destination.Contains("!") ||
                destination.Contains("#");
            if (cheque)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool chequeTime(string hours, string min)
        {
            int tempHour, tempMin;
            if (int.TryParse(hours, out tempHour))
            {
                if (int.TryParse(min, out tempMin))
                {
                    if (tempMin >= 0 && tempMin <= 59 && tempHour >= 0 && tempHour <=12)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool chequeDescription(string description)
        {
            string destination = description;
            bool cheque =
                destination.Contains("<") ||
                destination.Contains(">") ||
                destination.Contains("{") ||
                destination.Contains("}") ||
                destination.Contains("!") ||
                destination.Contains("#");
            if (cheque)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}