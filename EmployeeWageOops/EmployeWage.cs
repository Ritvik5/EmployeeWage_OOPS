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

        public static int EmployeeAttende()
        {
            Random random = new Random();
            int check = random.Next(0,3);
            return check;
        }

        public static void EmployeeDailyWage() 
        {
            int check = EmployeeAttende();
            int empHrs = 0 ;
            int empWage = 0 ;
            switch (check)
            {
                case 0:
                empHrs = 8 ;
                break;
                case 1:
                empHrs = 4 ;
                break;
                default: 
                empHrs = 0 ;
                break;

            }
            empWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("The Employee Wage is "+empWage);
        }
    }
}
