using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession03OOP.Question05
{
    class EBook :Book
    {
        #region Property 
        public double FileSize { get; set; } 
        #endregion
        #region Constructor 
        public EBook(string title , string author , string ison  ,double fileSize) :base(title, author, ison)
        {
            FileSize = fileSize;
        }

        #endregion
        #region override Method
        public override string ToString()
        {
            return base.ToString() + $"File Size :{FileSize}MB";
        }
        #endregion

    }
}
