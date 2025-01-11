using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession03OOP.Question05
{
    class PrintedBook : Book
    {
        #region Property 
        public int PageCount { get; set; } 
        #endregion
        #region Constructor 
        public PrintedBook(string title, string author, string isbn, int pageCount) : base(title, author, isbn)
        {
            PageCount = pageCount;
        }
        #endregion
        #region override Method 

        public override string ToString()
        {
            return base.ToString() + $"Page Count :{PageCount}";
        }
        #endregion

    }
}
