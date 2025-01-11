using AssignmentSession03OOP.Questiion01;
using AssignmentSession03OOP.Question02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession03OOP.Question04
{
     class SortEmployee :IComparable<SortEmployee>
    {

        private int id;
        private string name;
        private Gender gender;
        private SecurityLevel securityLevel;
        private int salary;
        private HiringDate hiringDate;
        public SortEmployee(int id, string name, Gender gender, SecurityLevel securityLevel, int salary, HiringDate hiringDate)
        {

            this.id = id;
            this.name = name;
            this.gender = gender;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hiringDate = hiringDate;

        }
        #region Propertys
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate? HireDate { get; set; }
        #endregion
        #region Method 

        public int CompareTo(SortEmployee? obj )
        {
            return  new DateTime(hiringDate.Year,hiringDate.Month,hiringDate.Day).CompareTo(new DateTime(obj.hiringDate.Year,obj.hiringDate.Month,obj.hiringDate.Day));

        }

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Gender: {gender}, Security Level: {securityLevel}, Salary: {String.Format("{0:C}", salary)}, Hire Date: {hiringDate}";
        }
        #endregion
    }
}

