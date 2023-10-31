using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employees
    {
        public Employees(int employeeId, string? employeeName, double performanceRating)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            PerformanceRating = performanceRating;
        }

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public double PerformanceRating { get; set; }

        public static double BonusCalculation(Employee employee)
        {


            double performance = employee.PerformanceRating;

            return performance * 10000;
        }
        public static double EmployeeCreate(Employee employee)
        {
            double performance = employee.PerformanceRating;
            return performance * 20000;
        }
    }
}
