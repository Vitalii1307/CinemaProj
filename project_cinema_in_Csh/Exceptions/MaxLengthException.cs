using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{
    class MaxLengthException: Exception 
    {
       public string MaximumString { get; }

        public MaxLengthException() { }
        public MaxLengthException(string maximumString) 
        {
            MaximumString = maximumString;
        }
    }
}
