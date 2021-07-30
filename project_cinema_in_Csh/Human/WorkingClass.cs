using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{
    
    [Serializable]
    public class WorkingClass: Person, IAction 
    {
        public delegate void EmployeeHandler(object sender, ChangeEmpEventArgs e);
        public event EmployeeHandler Change;
        public string Position { get; private set; }
     
        public string VarAction { get; set; }
        public int Salary { get; set; }


        public WorkingClass(string name, string position, int age, int ID) : base(name, age, ID)
        {
            Position = position;
        }

        public override string ToString()
        {
            return $"Ім'я: {Name},\nВік: {Age}, Посада: {Position}, Зарплата: {Salary}";
        }

        public void Change_Position_VarAction_Salary(string newSalaryTypeString, string newPosition, string newDuties)
        {
            string message = "";
            if (newSalaryTypeString != "") 
            {
                message += $"Зміна зарплати на: {int.Parse(newSalaryTypeString)}\n";
                Salary = int.Parse(newSalaryTypeString);
            }
            if (newPosition != "")
            {
                message += $"Зміна посади на: {newPosition}\n";
                Position = newPosition;
            }
            if (newDuties != "") 
            {
                message += $"Зміна обов'язків на: {newDuties}\n";
                VarAction = newDuties;
            }
            if (message=="")
            {
                message = "Змін не відбулося\n";
            }

            Change?.Invoke(this, new ChangeEmpEventArgs(message));
        }
                  
        public void Build(IAction action)
        {
            VarAction = action.Action();
        }

        string IAction.Action()
        {
          return VarAction;
        }
    }
}
