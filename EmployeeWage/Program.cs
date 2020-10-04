using System;

namespace EmployeeWage
{
    class Program
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int MaxWorkingHours = 100;
        public const int MaxWorkingDays = 20;
        public static int computeEmpWage()
        {
            int empHours, empWage = 0;
            int workingDays = 0;
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
            return empWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}
