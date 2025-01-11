using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession03OOP.Question02
{
     class HiringDate
    {
        #region Attributes
        private int day;
        private int month;
        private int year;
        #endregion
        public int Day
        { 
        get { return day; } set { day  =  value > 0 && value <=31 ? value : 1; }
        }
        public int Month 
        { 
        get
            {
                return month;
            }
            set
            {
                month = value > 0 && value <= 12 ? value : 1;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value > 0 ? value : 1;
            }
        }
    

        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            return $"Day = {day}  ,  Month= {month} , Year = {year}";
        }
    }
}
