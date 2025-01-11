using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession03OOP.Question05
{
    class Book
    {
        #region Property
        public string? Title { get; set; }
        public string? AuISBNthor { get; set; }
        public string? ISBN { get; set; }
        #endregion
        #region Constructor 
        public Book( string title , string author ,string isbn)
        {
            Title = title;
            AuISBNthor = author;
            ISBN = isbn;

        }
        #endregion
        #region override Method
        public override string ToString()
        {
            return $"Title: {Title}, Author: {AuISBNthor}, ISBN: {ISBN}";
        }
        #endregion

    }
}
