using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EmployeeWageOops
{
    public class EmployeWage
    {
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_TIME = 8;

        public static int EmployeeAttende()
        {
            Random random = new Random();
            int check = random.Next(0,2);
            return check;
        }

        public static void EmployeeDailyWage() 
        {
            int check = EmployeeAttende();
            int empHrs = 0 ;
            int empWage = 0 ;
            if (check == 0)
            {
                empHrs = 8 ;
            }
            else
            {
                empHrs = 0 ;
            }
            empWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("The employee wage is "+empWage);
        }
    }
}
