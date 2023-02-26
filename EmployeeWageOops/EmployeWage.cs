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
        public static void EmployeeAttende()
        {
            Console.WriteLine("Welcome to Employee Wage Program\n ");

            Random random = new Random();
            int check = random.Next(0,2);
            if (check == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
