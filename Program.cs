// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
const int isFullTime = 1;
const int isPartTime = 2;
const int wagePerHr = 20;
const int WorkingDays = 20;
const int maxHrsInMonth = 100;
int empHrs = 0;
int empDailyWage = 0;
int totalEarnings = 0;
int totalEmpHrs = 0;
int totalWorkingDays = 0;
Random random = new Random();
int result = random.Next(0,3);
while (totalEmpHrs < maxHrsInMonth && totalWorkingDays <= WorkingDays)
{
    totalWorkingDays++;
    switch (result)
    {
        case isFullTime:
            Console.WriteLine("Employee is Full Time");
            empHrs = 8;
            break;
        case isPartTime:
            Console.WriteLine("Employee is Part time");
            empHrs = 4;
            break;
        default:
            Console.WriteLine("Employee is Absent");
            empHrs = 0;
            break;
    }
    totalEmpHrs += empHrs;
    Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs = " + empHrs);
    empDailyWage = empHrs * wagePerHr;
    Console.WriteLine("empDailyWage = " + empDailyWage);
    totalEarnings += empDailyWage;
}
Console.WriteLine("Total Earnings = "+totalEarnings);