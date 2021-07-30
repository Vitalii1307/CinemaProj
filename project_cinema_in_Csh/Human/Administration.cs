using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{
   public class Administration:Person
    {
        public string Position { get;}
        public string Inst_subor { get;}
       
        public Administration(string name, string position, string inst_subor, int age, int ID) : base(name, age, ID)
        {  
            Position = position;
            Inst_subor = inst_subor;
        }
            
        public override string ToString()
        {
            return $"Ім'я: {Name},\nВік: {Age}, Посада: {Position}, Обовязки: {Inst_subor}";
        }
    }
}
