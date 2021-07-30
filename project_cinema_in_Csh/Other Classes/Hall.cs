using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{
    public class Hall
    {
		private int Number { get; }
		private int CountPlaces { get; }
		private string Projector { get; }
		private string SoundSystem { get; }
		private string Status { get; }

		public Hall(int number, int countPlaces, string projector, string soundSystem, string status) 
		{
			Number = number;
			CountPlaces = countPlaces;
			Projector = projector;
			SoundSystem = soundSystem;
			Status = status;
		}

		public override string ToString()
		{
			return $"Номер: {Number}\nКількість місць: {CountPlaces}\nПроєктор: {Projector}\nАудіосистема: {SoundSystem}\nСтатус залу: {Status}";
		}


	}
}
