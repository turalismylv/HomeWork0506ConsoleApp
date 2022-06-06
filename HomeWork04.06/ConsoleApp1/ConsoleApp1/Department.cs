﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Helpers;
namespace ConsoleApp1
{
    class Department
    {

        // - Name
        // - EmployeeLimit // departmentin umumi ala bileceyi isci sayi
        // - Budget // departmentin umumi budcesi
        // - Employees
        // - RequiredExperience(int) // departmentin iscilerinin en az nece il tecrubesi olmali oldugunu gosterir
        // - IsBachelorDegreeRequired(bool) // departmentin iscileri ucun ali tehsilin vacib olub olmamasini gosterir
        // - AddEmployee()// 
        //AddEmployee metodu employees array-e employee obyekti əlavə etmək üçündür.
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int Budget { get; set; }
        public int RequiredExperience { get; set; }
        public bool IsBachelorDegreeRequired { get; set; }

        Employee[] employees = new Employee[0];
        public Department()
        {
        }
        public Department(string name, int employeelimit, int budget, int requiredexperience, bool isbachelordegreerequired) : this()
        {

            Name = name;
            EmployeeLimit = employeelimit;
            Budget = budget;
            RequiredExperience = requiredexperience;
            IsBachelorDegreeRequired = isbachelordegreerequired;

        }
        public bool AddEmployee(Employee employee)
        {

            int sum = 0;
            if (employee.Experience >= RequiredExperience && employee.HasBachelorDegree == IsBachelorDegreeRequired && employee.Salary < Budget && sum < Budget)

            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;

                sum += employee.Salary;
                return true;

            }
            return false;
        }
        public bool Test()
        {
            if (EmployeeLimit >= employees.Length + 1)
            {
                return true;
            }
            else
            {
                Helper.Print("Isci limiti dolmuwdur", ConsoleColor.Red);
            }
            return false;

        }
        public void Ortalama()
        {
            int cem = 0;

            foreach (var item in employees)
            {
                cem += item.Salary;
            }

            int count = employees.Length;
            if (count == 0)
            {
                Helper.Print("Isci yoxdur", ConsoleColor.Red);
            }
            else
            {
                Helper.Print($"Umumi maas ortalamasi :{cem / count}", ConsoleColor.Blue);

            }

        }
    }
}



