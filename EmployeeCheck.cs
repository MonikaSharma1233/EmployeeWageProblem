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
 
                Random randomno = new Random();
                int ECheck = randomno.Next(2);
                Console.WriteLine(ECheck);
                if (ECheck == full_time)
                {
                    Console.WriteLine("Employee is Present.");
                }
                else
                {
                    Console.WriteLine("Employee is Absend.");
                }
              
          }
     }
}
