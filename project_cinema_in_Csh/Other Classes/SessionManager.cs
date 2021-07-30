using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cinema_in_Csh
{
    public class SessionManager: IAction

    {
        public int DayInWeek {get;} = 7;
        public int SessionsInHallSimple { get; set; } = 5;
        public int SessionsInHall3D { get; set; } = 5;
        public int SessionsInHallVip { get; set; } = 4;
        public int SessionsInHall3DVip { get; set; } = 4;
        public int CountArrHall { get; set; } = 0;

        private int Сount = 0;

        public Poster[,] postersHallSimple { get; set; }
        public Poster[,] postersHall3DSimple { get; set; }
        public Poster[,] postersHallVip { get; set; }
        public Poster[,] postersHall3DVip { get; set; }
        public string VarAction { get; set; }

        public SessionManager(List<Poster> postersList)
        {
            postersHallSimple = new Poster[DayInWeek, SessionsInHallSimple];
            postersHall3DSimple = new Poster[DayInWeek, SessionsInHall3D];
            postersHallVip = new Poster[DayInWeek, SessionsInHallVip];
            postersHall3DVip = new Poster[DayInWeek, SessionsInHall3DVip];

            InitializePosterArrays(DayInWeek, SessionsInHallSimple, postersList, postersHallSimple);
            InitializePosterArrays(DayInWeek, SessionsInHall3D, postersList, postersHall3DSimple);
            InitializePosterArrays(DayInWeek, SessionsInHallVip, postersList, postersHallVip);
            InitializePosterArrays(DayInWeek, SessionsInHall3DVip, postersList, postersHall3DVip);
        }

        private void InitializePosterArrays(int DayInWeek, int SessionsInHall, List<Poster> postersList, Poster[,] postersHall)
        {
            var rand = new Random();
       
            for (int i = 0; i < DayInWeek; i++)
            {
                for (int j = 0; j < SessionsInHall; j++)
                {
                    postersHall[i, j] = postersList[/*rand.Next(0, postersList.Count - 1)*/ChoiceIndex(postersList)];
                }
            }
            CountArrHall++;
        }

        private int ChoiceIndex(List<Poster> posters) 
        {
            if (Сount >= posters.Count)
                Сount = 0;
            return Сount++;
        }

        public string Action()
        {
            string time = "";
            VarAction = DateTime.Today.DayOfWeek.ToString();
            string now = DateTime.Now.ToString();
            int i = 11;
            while (now[i]!=':')
            {
                time += now[i];
                i++;
            }

            return time;
        }

       
    }
}
