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
        const int WORKING_DAYS_PER_MONTH = 20;



        //UC5: Calculate Wages for a Month
        public void MonthlyEmployeeWage()
        {
            int totalWage = 0;
            for (int day = 1; day <= WORKING_DAYS_PER_MONTH; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                int empHours = 0;

                switch (empCheck)
                {
                    case 0:
                        Console.WriteLine($"Day {day}: Employee is Absent");
                        empHours = 0;
                        break;
                    case 1:
                        Console.WriteLine($"Day {day}: Employee is Present (Full-time)");
                        empHours = FULL_DAY_HOUR;
                        break;
                    case 2:
                        Console.WriteLine($"Day {day}: Employee is Present (Part-time)");
                        empHours = PART_TIME_HOUR;
                        break;


                }

                int dailyWage = empHours * WAGE_PER_HOUR;
                totalWage += dailyWage;

                Console.WriteLine($"Day {day} Wage: {dailyWage}");

            }
            Console.WriteLine("\nTotal Wage for the Month: " + totalWage);




        }


    }
}