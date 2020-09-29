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
            int empHours, empWage;
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == IS_FULL_TIME)
            {
                empHours = 8;
            }
            else if (check == IS_PART_TIME)
            {
                empHours = 4;
            }
            else
                empHours = 0;
            empWage = empHours * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Employee Wages: " + empWage);
        }
    }
}
