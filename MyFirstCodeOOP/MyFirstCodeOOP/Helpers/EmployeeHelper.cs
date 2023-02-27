using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP.Helpers
{
    public class EmployeeHelper
    {
        #region Fields
        private Employee _salaryEmployee;
        private Employee _comissionEmployee;
        private Employee _contractorEmployee;
        private Employee _baseComissionEmployee;

        #endregion

        #region Methods
        public EmployeeHelper(Employee salaryEmployee, Employee comissionEmployee, Employee contractorEmployee, Employee baseComissionEmployee)
        {
            _salaryEmployee = salaryEmployee;
            _comissionEmployee = comissionEmployee;
            _contractorEmployee = contractorEmployee;
            _baseComissionEmployee = baseComissionEmployee;
        }

        public decimal GetPayrollFrontActiveEmployee()
        {
            ICollection<Employee> employees = new List<Employee>()
                {
                    _salaryEmployee,
                    _comissionEmployee,
                    _contractorEmployee,
                    _baseComissionEmployee
                };

            decimal payroll = 0;

            foreach (Employee employee in employees)
            {
                if (employee.IsActive == true)
                {
                    Console.WriteLine(""); 
                    Console.WriteLine(employee);
                    Console.WriteLine("");
                    payroll += employee.GetValueToPay();
                }
            }
            return payroll;
        }

        #endregion
    }
}
