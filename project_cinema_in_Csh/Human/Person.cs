using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cinema_in_Csh
{
    [Serializable]
    public class Person
    {
        private const int maxLengthName = 20;

        private string name;
      

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < maxLengthName)
                {
                    name = value;
                }
                else
                {
                    throw new MaxLengthException(value);
                }
            }
        }
        public int Age { get; private set ; }

        public int ID { get; set; }

        public Person(string name, int year, int ID) 
        {

            Name = name;
            Age = DateTime.Today.Year - year;

            this.ID = ID;            
        }

        public override string ToString()
        {
            return $"Name:{Name} Age:{Age} ID:{ID}";
        }

    }
}
