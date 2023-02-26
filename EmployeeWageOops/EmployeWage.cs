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
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static int EmployeeAttende()
        {
            Random random = new Random();
            int check = random.Next(0,3);
            return check;
        }

        public static int EmployeeDailyWage() 
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
            return empWage;
        }

        public static int EmployeeMonthlyWage()
        {
            int totalEmpWage = 0 ;
            for(int i = 1; i<= NUM_OF_WORKING_DAYS; i++)
            {
                totalEmpWage += EmployeeDailyWage();
            }
            return totalEmpWage;
            
        }

        public static void EmpWageCondition()
        {
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalDays = 0;

            while( totalEmpHrs <= MAX_HRS_IN_MONTH && totalDays < NUM_OF_WORKING_DAYS)
            {
                totalDays++;
                int empWage = EmployeeDailyWage();
                if(empWage == 160)
                {
                    totalEmpHrs += 8;
                }
                else if(empWage == 80)
                {
                    totalEmpHrs += 4;
                }
                totalEmpWage += empWage;
            }
            totalEmpWage = totalEmpHrs * WAGE_PER_HOUR;
            Console.WriteLine(totalEmpWage);
        }
    }
}
