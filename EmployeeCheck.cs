using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeCheck
    {
        public const int full_time = 1;
        public const int part_time = 2;
        public static void CheckAttendence()
        {

            int per_Hour = 20;

            int emp_Hour = 0;
            int emp_Wage = 0;



            Random randomno = new Random();
            int ECheck = randomno.Next(3);
            // Console.WriteLine("Today Employee Attendence Status is: "+ECheck);
            switch (ECheck)
            {
                case full_time:
                    emp_Hour = 8;
                    break;

                case part_time:
                    emp_Hour = 4;
                    break;

                default:
                    emp_Hour = 0;
                    break;
            }
            emp_Wage = emp_Hour * per_Hour;
            Console.WriteLine("Today wage of Employee: " + emp_Wage + " Rs.");
        }
    }
}




