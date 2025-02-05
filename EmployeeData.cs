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


        //UC4: Using Swicth case to calculate daily wage
        public void DailyEmployeeWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            int empHours = 0;
            string workStatus = "";


            switch (empCheck)
            {
                case 0:
                    workStatus = "Employee is Absent";
                    empHours = 0;
                    break;

                case 1:
                    workStatus = "Full time Employee is Present";
                    empHours = FULL_DAY_HOUR;
                    break;

                case 2:
                    workStatus = "Part time Employee is Present";
                    empHours = PART_TIME_HOUR;
                    break;

                  
            }

            int dailyWage = empHours * WAGE_PER_HOUR;
            Console.WriteLine(workStatus);
            Console.WriteLine("Employee Wage for the day is: " + dailyWage);


        }


    }


}
