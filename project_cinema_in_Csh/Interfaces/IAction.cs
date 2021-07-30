using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{

    public interface IAction
    {
        string VarAction { set; }
        string Action();
    }
}
