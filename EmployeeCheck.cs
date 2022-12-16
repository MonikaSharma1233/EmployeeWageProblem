using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeCheck
    {
        public static void CheckAttendence()
        {
            int full_time = 1;
            int part_time = 2;
            int per_Hour = 20;

            int emp_Hour = 0;
            int emp_Wage = 0;



            Random randomno = new Random();
            int ECheck = randomno.Next(3);
            // Console.WriteLine("Today Employee Attendence Status is: "+ECheck);
            if (ECheck == full_time)
            {
                //Console.WriteLine("Employee is Present.");
                emp_Hour = 8;
            }
            else if (ECheck == part_time)
            {
                //Console.WriteLine("Employee is Present Part time.");
                emp_Hour = 4;
            }
            else
            {
                //Console.WriteLine("Employee is Absent.");
                emp_Hour = 0;
            }
            emp_Wage = emp_Hour * per_Hour;
            Console.WriteLine("Today wage of Employee: " + emp_Wage + " Rs.");
        }
    }
}