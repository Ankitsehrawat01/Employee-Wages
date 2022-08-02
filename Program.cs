// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
const int isFullTime = 1;
const int isPartTime = 2;
const int wagePerHr = 20;
int empHrs = 0;
int empDailyWage = 0;
Random random = new Random();
int result = random.Next(0,3);
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
empDailyWage = empHrs * wagePerHr;
Console.WriteLine("empDailyWage = " + empDailyWage);