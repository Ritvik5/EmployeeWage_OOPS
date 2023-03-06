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
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int ComputeEmpWage(string company, int wagePerHrs, int numOfWorkingDays, int maxHrsPerMonth)
        {
            int empHrs =0;
            int totalEmpHrs =0;
            int totalWorkingDays =0;
            while( totalEmpHrs < maxHrsPerMonth && totalWorkingDays < numOfWorkingDays ) 
            {
                totalWorkingDays++;
                Random random = new Random();
                int check = random.Next( 0, 3);
                switch( check )
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " +totalWorkingDays + " EmpHrs : " +empHrs);
            }
            int totalEmpWage = totalEmpHrs * wagePerHrs;
            Console.WriteLine("Total Emp Wage for Company : " + company + " is : " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
