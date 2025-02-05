using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{

    internal class EmployeeWage1
    {
        //UC1: Employee Attendance

        public void EmployeeAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == 1)
            {

                Console.WriteLine("Employee is present");

            }

            else
            {
                Console.WriteLine("Employee is absent");

            }
        }


    }
}
