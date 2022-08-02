// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
int isPresent = 1;
Random random = new Random();
int result = random.Next(0,2);
if(result == isPresent)
    {
        Console.WriteLine("Employee is Present");
    }
else
    {
        Console.WriteLine("Employee is Absent");
    }
