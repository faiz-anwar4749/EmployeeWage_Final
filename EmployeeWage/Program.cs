using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 2;
            Random random = new Random();


            int EmployeeCheck = random.Next(1, 3);
            if (EmployeeCheck == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
