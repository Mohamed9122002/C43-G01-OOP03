using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession03OOP.Questiion01
{
    [Flags]
     enum SecurityLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }
}
