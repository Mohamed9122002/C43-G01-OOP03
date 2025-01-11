using System.Reflection.Emit;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using AssignmentSession03OOP.Questiion01;
using AssignmentSession03OOP.Question02;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading;
using AssignmentSession03OOP.Question03;
using System.Diagnostics;
using System.Timers;
using System;
using AssignmentSession03OOP.Question04;
using AssignmentSession03OOP.Question05;

namespace AssignmentSession03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Design and implement a Class for the employees in a company
            //Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //We need to restrict the Gender field to be only M or F[Male or Female]
            //Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
            //We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [Use String.Format() Function].


            //Employee employee = new Employee() { Id = 1,Name = "Mohamed",Gender = Gender.M ,SecurityLevel = SecurityLevel.Developer};
            //Console.WriteLine(employee.ToString());
            #endregion
            #region Q2
            ////2.Develop a Class to represent the Hiring Date Data:
            ////    Consisting of fields to hold the day, month and Years.
            //HiringDate hiringDate = new HiringDate(1, 1, 2025);
            //Console.WriteLine(hiringDate.ToString());
            #endregion
            #region Q3
            //3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)
            //    Notes 
            //        Implement All the Necessary Member Functions on the Class(Getters, Setters)
            //        Define all the Necessary Constructors for the Class
            //        Allow NO RUNTIME errors if the user inputs any data
            //        Write down all the necessary Properties(Instead of setters and getters)
            //ArraryOfEmployees[] arraryOfEmployees = ArraryOfEmployees.GetEmployee(3);
            //ArraryOfEmployees.InsertData(arraryOfEmployees);
            //Console.Clear();
            //ArraryOfEmployees.DisplayEmployees(arraryOfEmployees);

            #endregion
            #region Q4
            //.Sort the employees based on their hire date then Print the sorted array.
            //    While sorting(how many times Boxing and Unboxing process has occurred)
            //SortEmployee[] EmpArr = new SortEmployee[3];
            //EmpArr[0] = new SortEmployee(1, "Doaa", Gender.F, SecurityLevel.DBA, 80000, new HiringDate(1, 1, 2025));
            //EmpArr[1] = new SortEmployee(2, "Ali", Gender.M, SecurityLevel.Guest, 50000, new HiringDate(1, 2, 2020));
            //EmpArr[2] = new SortEmployee(3, "Amin", Gender.M, SecurityLevel.Developer, 90000, new HiringDate(1, 3, 2022));
            //Array.Sort(EmpArr,( x,y) =>
            //{
            //    return  x.CompareTo(y);
            //});

            //Console.WriteLine("Sorted Employees by Hire Date:");
            //foreach (var employee in EmpArr)
            //{
            //    Console.WriteLine(employee.ToString());
            //}


            #endregion
            #region Q5
            //5 - Design a program for a library management system where:
            //    Book is a base class with properties like Title, Author, and ISBN.
            //    EBook and PrintedBook are derived classes with additional properties like FileSize for EBook and PageCount for PrintedBook.
            //    Demonstrate how inheritance simplifies the design.
            //EBook eBook = new EBook("C# Programming", "Mohamed", "123456", 10);
            //PrintedBook printedBook = new PrintedBook("C# Programming", "Mohamed", "123456", 100);
            //Console.WriteLine("EBook Details");
            //Console.WriteLine(eBook.ToString());
            //Console.WriteLine("************************");
            //Console.WriteLine("PrintBook Details ");
            //Console.WriteLine(printedBook.ToString());

            #endregion
        }
    }
}
