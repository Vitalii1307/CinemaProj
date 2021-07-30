using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{
    public class Poster: IComparable
	{
		private const int maxLengthName = 30;
		private string name;
		private double rating;
		 
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
		public string Ganre { get;}
		public string Director { get;}
		public string Country { get; }
		public double Budget { get; }
		public double Rating
		{
			get
			{
				return rating;
			}
			set
			{
				if (value > 10)
					rating = 10;
				else if (value < 0)
					rating = 0;
				else
					rating = value;
			}
		}

		public Poster() 
		{}

		public Poster(string name, string ganre, string director, string country, double budget, double rating) 
		{
			Name = name;
			Ganre = ganre;
			Director = director;
			Country = country;
			Budget = budget;
			Rating = rating;
		}

        public int CompareTo(object obj)
        {
			Poster poster = obj as Poster;
			if (poster != null)
			{

				if (this.Name[0] > poster.Name[0]) return 1;
				else if (this.Name[0] < poster.Name[0]) return -1;
				else
					return 0;
			}
			else
			{
				throw new Exception("Parametr most be type \"Poster\" ");
			}
		}
	}
}