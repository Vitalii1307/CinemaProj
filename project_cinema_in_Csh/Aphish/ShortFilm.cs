using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh.Aphish
{
    public class ShortFilm: Poster
    {
        public int Duration { get; set; }
        public string Type { get; set; }

        public ShortFilm(string name, string ganre, string director, string country, double budget, double rating) 
            : base(name, ganre, director, country, budget, rating)
        {}
        public override string ToString()
        {
            return  $"Назва: {Name},\nЖанр: {Ganre},\nРежисер: {Director},\nКраїна: {Country},\nБ'юджет: {Budget}млн.,\nТривалість: {Duration},\nТип:{Type}\nРейтинг: {Rating}";
        }
    }
}
