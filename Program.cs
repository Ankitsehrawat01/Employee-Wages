// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
int isFullTime = 1;
int isPartTime = 2;
int wagePerHr = 20;
int empHrs = 0;
int empDailyWage = 0;
Random random = new Random();
int result = random.Next(0,3);
if(result == isFullTime)
    {
        Console.WriteLine("Employee is Full Time");
        empHrs = 8;
        
    }
else if(result == isPartTime)
    {
    Console.WriteLine("Employee is Part time");
    empHrs = 4; 
}
else
    {
        Console.WriteLine("Employee is Absent");
        empHrs = 0;
    }
empDailyWage = empHrs * wagePerHr;
Console.WriteLine("empDailyWage = " + empDailyWage);