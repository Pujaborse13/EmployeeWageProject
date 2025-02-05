using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{

     class EmployeeData
     {
        const int WAGE_PER_HOUR = 20;
        const int FULL_DAY_HOUR = 8;
        const int PART_TIME_HOUR = 4;


        //UC3: Daily Employee Wage
        public void DailyEmployeeWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch(empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    Console.WriteLine("Daily Wage: 0");
                    break;

                case 1:
                    Console.WriteLine("Full time Employee is Present");
                    int dailyWageFullTime = WAGE_PER_HOUR * FULL_DAY_HOUR;
               
                    Console.WriteLine("Daily Wage for Full time employee: " + dailyWageFullTime);
                    break;

                case 2:
                    Console.WriteLine("Part time Employee is Present");
                    int dailyWagePartTime = WAGE_PER_HOUR * PART_TIME_HOUR;
                    Console.WriteLine("Daily Wage for part time employee: " + dailyWagePartTime);
                    break;

            }

        }


     }


}
