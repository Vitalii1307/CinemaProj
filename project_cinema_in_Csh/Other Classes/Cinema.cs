using project_cinema_in_Csh.Aphish;
using System;
using System.Collections;
using System.Collections.Generic;


namespace project_cinema_in_Csh
{
   
    public class Cinema
    {
        public List<Movie> movies { get; }
        
        public List<Cartoon> cartoons { get; }
        
        public List<ShortFilm> shortFilms { get;}
       
        public string Name { get; private set; }
        public string Adsress { get; private set; }

        public Administration Admin { get; private set; }

        public Dictionary<int , WorkingClass> Workings { get; set; }
        public List<Hall> Halls { get; }
       
       
        public Cinema(string name, string address, Administration admin) 
        {
            Name = name;
            Adsress = address;
            Admin = admin;
            Workings = new Dictionary<int, WorkingClass>();
            Halls = new List<Hall>();
            movies = new List<Movie>();
            cartoons = new List<Cartoon>();
            shortFilms = new List<ShortFilm>();
        }
        public void AddWorking(WorkingClass working)
        {
            Workings.Add(working.ID, working);
        }
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
        public void AddCartoon(Cartoon cartoon)
        {
            cartoons.Add(cartoon);
        }
        public void AddshortFilm(ShortFilm shortFilm)
        {
            shortFilms.Add(shortFilm);
        }

        static public IEnumerable<Poster> GetPosters(Poster[] films) 
        {
            foreach (var fm in films)
            {
                yield return fm;
            }
        }

       static public List<T> GlueList<T>(params T[][] arrays)
        {
            int countAllElem = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                foreach (var item in arrays[i])
                {
                    countAllElem++;
                }
            }

            List<T> outList = new List<T>(countAllElem);

            for (int i = 0; i < arrays.Length; i++)
            {
                foreach (var item in arrays[i])
                {
                    outList.Add(item);
                }
            }
            return outList;

        }
    }
}