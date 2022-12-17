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
        public const int No_of_working_days = 20;
        public const int per_Hour = 20;
        public static void CheckAttendence()
        {

            

            int emp_Hour = 0;
            int emp_Wage = 0;
            int totalwage = 0;

            for (int day = 1; day <= No_of_working_days; day++)
            {

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
                totalwage=totalwage+emp_Wage;
                Console.WriteLine("Day: " + day + " Wage: " + emp_Wage);
            }
            
            Console.WriteLine("wage of Employee of 20 days: " + totalwage + " Rs.");
        }
    }
}




