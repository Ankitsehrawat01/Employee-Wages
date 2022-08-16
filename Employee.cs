using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    public class Employee
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        public static int ComputeWage(string company, int empRatePerHour, int WorkingDays, int maxHrsInMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs < maxHrsInMonth && totalWorkingDays <= WorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int result = random.Next(0, 3);
                switch (result)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days: " + totalWorkingDays + "Emp Hrs " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
