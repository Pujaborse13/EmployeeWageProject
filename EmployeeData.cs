using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{

    internal class EmployeeData
    {
        const int WAGE_PER_HOUR = 20;
        const int FULL_DAY_HOUR = 8;
        
        //UC1: Employee Attendance
        public bool EmployeeAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            return empCheck == 1;

        }



        //UC2: Daily Employee Wage
        public void DailyEmployeeWage()
        {
            if (EmployeeAttendance())
            {
                Console.WriteLine("Employee is Present");
                int dailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine("Daily Wage: " + dailyWage);
            }

            else {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Daily Wage: 0");
            }

        }


    }



 
}
