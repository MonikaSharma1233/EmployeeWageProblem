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
        public const int per_Hour = 20;
        public const int totalHrs_in_month = 100;
        public const int total_Working_days = 20;

        public static void CheckAttendence()
        {

            

            int emp_Hour = 0;
            int emp_Wage = 0;
            int totalwage = 0;
            int totalworking_days = 0;
            int totalworking_hrs = 0;

            while(totalworking_hrs<totalHrs_in_month && totalworking_days<total_Working_days)
            {

                Random randomno = new Random();
                int ECheck = randomno.Next(3);
                // Console.WriteLine("Today Employee Attendence Status is: "+ECheck);
                totalworking_days++;
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
                totalworking_hrs = totalworking_hrs + emp_Hour;
                

                
            }
            Console.WriteLine("Total working hours: " + totalworking_hrs + " Working Days: " + totalworking_days);
            totalwage = totalworking_hrs * per_Hour;
            Console.WriteLine("wage of Employee of 20 Working Days: " + totalwage + " Rs.");
        }
    }
}




