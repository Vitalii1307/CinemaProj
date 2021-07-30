using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{
    public class ChangeEmpEventArgs
    {
        public string Message { get; set; }
        public ChangeEmpEventArgs(string message) 
        {
            Message = message;
        }


    }
}
