using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh.Aphish
{
    public class Movie: Poster
    {
        public string FilmCompany { get;}
        public string Operator { get;}
        public string NextMovie { get;}

        public Movie(string filmCompany, string _operator, string nextMovie,string name ,string ganre, string director, string country, double budget, double rating) 
            : base(name, ganre, director, country, budget, rating)
        {
            FilmCompany = filmCompany;
            Operator = _operator;
            NextMovie = nextMovie;
        }   

        public override string ToString()
        {
            return $"Назва: {Name},\nЖанр: {Ganre},\nРежисер: {Director},\nКраїна: {Country},\nБ'юджет: {Budget}млн.,\nТелекомпанія: {FilmCompany},\nОператор: {Operator},\nНаступний фільм: {NextMovie}\nРейтинг: {Rating}";
        }
    }
}
