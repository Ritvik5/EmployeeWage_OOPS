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

        private string company;
        private int wagePerHrs;
        private int numOfWorkingDays;
        private int maxHrsPerMonth;
        private int totalEmpWage;

        public EmployeWage(string company ,int wagePerHrs ,int numOfWorkingDays ,int maxHrsPerMonth) 
        {
            this.company = company;
            this.wagePerHrs = wagePerHrs;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        public void ComputeEmpWage()
        {
            int empHrs =0;
            int totalEmpHrs =0;
            int totalWorkingDays =0;
            while( totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays < this.numOfWorkingDays ) 
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
            totalEmpWage = totalEmpHrs * this.wagePerHrs;
        }
        public string GetCompany() 
        {
            return "Total Emp Wage for Company : " + this.company + " is :" + this.totalEmpWage; 
        }
    }
}
