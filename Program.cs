// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
int isPresent = 1;
int wagePerHr = 20;
int empHrs = 0;
int empDailyWage = 0;
Random random = new Random();
int result = random.Next(0,2);
if(result == isPresent)
    {
        Console.WriteLine("Employee is Present");
        empHrs = 8;
        
    }
else
    {
        Console.WriteLine("Employee is Absent");
        empHrs = 0;
    }
empDailyWage = empHrs * wagePerHr;
Console.WriteLine("empDailyWage = " + empDailyWage);