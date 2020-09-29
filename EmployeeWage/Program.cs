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
            int WorkingDays = 20;
            int empHours, empWage = 0;
            Random random = new Random();
            for (int i = 0; i < WorkingDays; i++)
            {
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
                empWage += empHours * EMP_WAGE_PER_HOUR;
            }
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}
