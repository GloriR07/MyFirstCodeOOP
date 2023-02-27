using MyFirstCodeOOP.Helpers;
using System;
using System.Collections.Generic;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Date dateObject = new Date(2023, 2, 3);
                Console.WriteLine("************");
                Console.WriteLine("OOP CONCEPTS");
                Console.WriteLine("************");
                Console.WriteLine("");

                Console.WriteLine("Please put your birth date year:");
                var year = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your birth date month:");
                var month = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your birth date day:");
                var day = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)));

                Console.WriteLine("");
                Console.WriteLine("**********Testing intest Implementation**********");
                Console.WriteLine("");

                Console.WriteLine("*******************");
                Console.WriteLine("**SALARY EMPLOYEE**");
                Console.WriteLine("*******************");

                Console.WriteLine("Please put your ID:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please put your First Name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Please put your Last Name: ");
                string LastName = Console.ReadLine();

                Console.WriteLine("Are you is Active?");
                bool isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter You Salary");
                decimal Salary = Convert.ToDecimal(Console.ReadLine());


                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = LastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = isActive,
                    Salary = Salary,


                    //Id = Convert.ToInt32(Console.ReadLine()),
                    //FirstName = Console.ReadLine(),
                    //LastName = Console.ReadLine(),
                    //BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    //HiringDate = new Date(2022, 12, 31),
                    //IsActive = Convert.ToBoolean(Console.ReadLine()),
                    //Salary = Convert.ToDecimal(Console.ReadLine()),   
                };

                //Console.WriteLine(salaryEmployee);

                Console.WriteLine("");

                Console.WriteLine("************************");
                Console.WriteLine("***COMISSION EMPLOYEE***");
                Console.WriteLine("************************");

                Console.WriteLine("Please put your ID:");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please put your First Name: ");
                firstName = Console.ReadLine();

                Console.WriteLine("Please put your Last Name: ");
                LastName = Console.ReadLine();

                Console.WriteLine("Are you is Active");
                bool IsActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter You Comisson Percentage:");
                float comissionPercentage = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter You Sales:");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Employee comissionEmployee = new ComissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = LastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive= isActive,
                    ComissionPercentage = comissionPercentage,
                    Sales = sales,
                };

               // Console.WriteLine(comissionEmployee);
                
                Console.WriteLine("");


                Console.WriteLine("");

                Console.WriteLine("*************************");
                Console.WriteLine("***CONTRACTOR EMPLOYEE***");
                Console.WriteLine("*************************");

                Console.WriteLine("Please put your ID:");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please put your First Name:");
                firstName = Console.ReadLine();

                Console.WriteLine("Please put your Last Name: ");
                LastName = Console.ReadLine();

                Console.WriteLine("Are you is Active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter You number of Hours:");
                float hours = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter You value per hour:");
                decimal hourValue = Convert.ToDecimal(Console.ReadLine());

                Employee contractorEmployee = new ContractorEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = LastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = isActive,
                    Hours = hours,
                    HourValue = hourValue,
                };

                //Console.WriteLine(contractorEmployee);

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("*******************************");
                Console.WriteLine("***BASE & COMISSION EMPLOYEE***");
                Console.WriteLine("*******************************");

                Console.WriteLine("Please put your ID:");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please put your First Name");
                firstName = Console.ReadLine();

                Console.WriteLine("Please put your Last Name");
                LastName = Console.ReadLine();

                Console.WriteLine("Are your is Active");
                IsActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter Your Comisson Percentage:");
                comissionPercentage = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter Your Sales:");
                sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter Your salary base:");
                decimal salaryBase = Convert.ToDecimal(Console.ReadLine());

                Employee baseComissionEmployee = new BaseComissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = LastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = isActive,
                    ComissionPercentage = comissionPercentage,
                    Sales = sales,
                    Base = salaryBase
                };

                //Console.WriteLine(baseComissionEmployee);

                EmployeeHelper employeeHelper = new EmployeeHelper(salaryEmployee, comissionEmployee, contractorEmployee, baseComissionEmployee); 
                
                Console.WriteLine($"Total Payroll:........{employeeHelper.GetPayrollFrontActiveEmployee():C2}");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("*************");
                Console.WriteLine("***INVOICE***");
                Console.WriteLine("*************");
                Console.WriteLine("");

               Invoice invoice = new Invoice()
                {
                    Id = 2023232525,
                    Description = "Iphone 13",
                    Price = 4500000,
                    Quantity = 2,
                };

                Console.WriteLine(invoice);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
