using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{
   public class Cartoon: Poster
    {
        public string TypeCartoon { get; }
        public string ProductionDesigner { get; }
        public Cartoon(string typeCartoon, string productionDesiger,string name, string ganre, string director, string country, double budget, double rating) 
            : base(name, ganre, director, country, budget, rating)
        {
            TypeCartoon = typeCartoon;
            ProductionDesigner = productionDesiger;
        }
        public override string ToString()
        {
            return $"Назва: {Name},\nЖанр: {Ganre},\nРежисер: {Director},\nКраїна: {Country},\nБ'юджет: {Budget}млн.,\nТип мультфільму: {TypeCartoon},\nХудожник: {ProductionDesigner}\nРейтинг: {Rating}";
        }
    }
}