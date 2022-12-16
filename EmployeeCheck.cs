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
            int per_Hour = 20;

            int emp_Hour = 0;
            int emp_Wage = 0;


            Random randomno = new Random();
            int ECheck = randomno.Next(2);
            Console.WriteLine("Today Employee Attendence Status is: " + ECheck);
            if (ECheck == full_time)
            {
                Console.WriteLine("Employee is Present.");
                emp_Hour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absend.");
                emp_Hour = 0;
            }
            emp_Wage = emp_Hour * per_Hour;
            Console.WriteLine("Today wage of Employee: " + emp_Wage + " Rs.");
        }
    }
}