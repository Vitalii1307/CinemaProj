using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh.Comparers
{
    class BudgetComparer: IComparer<Poster>
    {
        public int Compare(Poster obj1, Poster obj2)
        {
            if (obj1.Budget > obj2.Budget) return 1;
            else if (obj1.Budget < obj2.Budget) return -1;
            else return 0;
        }
    }
}
