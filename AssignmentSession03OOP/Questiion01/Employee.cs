using AssignmentSession03OOP.Question02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession03OOP.Questiion01
{
     class Employee
    {
        #region Propertys
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate? HireDate { get; set; }
        #endregion
        #region override methods

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Security Level: {SecurityLevel}, Salary: {String.Format("{0:C}", Salary)}, Hire Date: {HireDate}";
        }
        #endregion
       
    }
}
