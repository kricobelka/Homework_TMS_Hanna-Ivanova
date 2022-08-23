using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    [Flags]
    internal enum DietStatus
    {
        NotAnalyzed = 1,
        NotFormulated = 2,
        Analyzed = 4,
        Feasible = 8,
        Nonfeasible = 16,
        Unsafe = 32,
    }
}
