using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_WAGE_PER_HOUR = 20;
            int workingDays = 0;
            int MaxWorkingHours = 100;
            int MaxWorkingDays = 20;
            int empHours = 0, empWage = 0;
            int workingHours = 0;
            Random random = new Random();
            while (workingDays < MaxWorkingDays && workingHours < MaxWorkingHours)
            {
                workingDays++;
                int check = random.Next(0, 3);
                switch (check)
                {
                    case 2:
                        empHours = 8;
                        break;
                    case 1:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                workingHours += empHours;
                empWage += empHours * EMP_WAGE_PER_HOUR;
            }
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}
