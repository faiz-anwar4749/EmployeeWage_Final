using System;

namespace EmployeeWage
{
    class Program
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public static int ComputeEmpWage(string company, int empWagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            int empHours, empWage = 0;
            int workingDays = 0;
            int workingHours = 0;
            Random random = new Random();
            while (workingDays < maxWorkingDays && workingHours < maxWorkingHours)
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
            }
            empWage += workingHours * empWagePerHour;
            Console.WriteLine("Total Employee Wage for the company " + company + " is: " + empWage);
            return empWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("DMart", 20, 20, 100);
            ComputeEmpWage("RJio", 20, 17, 97);
        }
    }
}
