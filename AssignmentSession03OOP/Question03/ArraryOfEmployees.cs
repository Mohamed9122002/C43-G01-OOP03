using AssignmentSession03OOP.Questiion01;
using AssignmentSession03OOP.Question02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession03OOP.Question03
{
     class ArraryOfEmployees
    {
        #region Attributes
        private int id;
        private string? name;
        private double salary;
        private Gender gender;
        private SecurityLevel securityLevel;
        private HiringDate? hiringDate;
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public  SecurityLevel SecurityLevel { get => securityLevel; set => securityLevel = value; }

        public HiringDate HiringDate { get { return hiringDate; } set => hiringDate = value; }
        #endregion

        #region Fuctions
        // Create Array
        public static ArraryOfEmployees[] GetEmployee(int size)
        {
            ArraryOfEmployees[] employees = new ArraryOfEmployees[size];
            for (int i = 0; i < employees.Length; i++)
                employees[i] = new ArraryOfEmployees();

            return employees;
        }

        // Insert Data in Arary 
        public static void InsertData(ArraryOfEmployees[] employees )

        {
            bool flag;
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter Data Employee {i+1}");
                Console.WriteLine("***************************");
                do
                {
                    Console.WriteLine("Please Enter Id");
                    
                flag = int.TryParse(Console.ReadLine(), out employees[i].id);
                }
                while (!flag);
                do
                {
                    Console.WriteLine("Please Enter Name");
                    employees[i].name = Console.ReadLine();
                } while (string.IsNullOrEmpty(employees[i].name));
                do
                {
                    Console.WriteLine("Please Enter Salary");
                    flag = double.TryParse(Console.ReadLine(), out employees[i].salary);
                } while (!flag);
                int gender;
                do
                {
                    Console.WriteLine("Please Enter Gender M Or F");
                    flag = int.TryParse(Console.ReadLine(), out gender);
                } while (!flag);
                employees[i].gender  = (Gender)gender;
                int securityLevel;
                do
                {
                    Console.WriteLine("Please Enter SecurityLevel ");
                    flag = int.TryParse(Console.ReadLine(), out securityLevel);
                } while (!flag && securityLevel >0 && securityLevel <= 15);
                employees[i].securityLevel = (SecurityLevel)securityLevel;
                Console.WriteLine("Enter Hiring Date");
                Console.WriteLine("Enter Day Number");
                int day;
                do
                {
                   flag = int.TryParse(Console.ReadLine(), out day);
                } while (!flag);
                Console.WriteLine("Enter Month Number");
                int month;
                do
                {
                    flag = int.TryParse(Console.ReadLine(), out month);
                } while (!flag);
                Console.WriteLine("Enter Year Number");
                int year;
                do
                {
                    flag = int.TryParse(Console.ReadLine(), out year);
                } while (!flag);
                employees[i].hiringDate = new HiringDate(day, month, year);

            } 
        }

        // Display Employees
        public static void DisplayEmployees(ArraryOfEmployees[] employees)
        {
            for (int i = 1; i <= employees.Length; i++)
            {
                Console.WriteLine($"Data Of Employee {i}");
                Console.WriteLine("***************************");
                Console.WriteLine(employees[i - 1].ToString());
            }
        }
        #endregion

        #region override methods

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Gender: {gender}, Security Level: {securityLevel}, Salary: {String.Format("{0:C}", salary)}, Hire Date: {hiringDate}";
        }
        #endregion
    }
}
