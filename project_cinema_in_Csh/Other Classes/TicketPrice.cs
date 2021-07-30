using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{
    public class TicketPrice<T>
         where T : Poster
    {
        public int PriceSimpleHall { get; private set; }
        public int Price3DHall { get; private set; }
        public int PriceVIPHall { get; private set; }
        public int Price3DVIPHall { get; private set; }

        public T Film { get; set; }
        public TicketPrice(T film)
        {
            Film = film;
        }

        public void LoadPrice()
        {
            double k = 1.000;
            k += Film.Budget / 1000;
            PriceSimpleHall = (int)(k * ((Film.Rating * 150) / 10));

            Price3DHall = PriceSimpleHall + ((PriceSimpleHall * 5) / 100); //піднімаєм ціну на 5 % від SimpleHall
            PriceVIPHall = PriceSimpleHall + ((PriceSimpleHall * 15) / 100);//піднімаєм ціну на 15 % від SimpleHall
            Price3DVIPHall = PriceSimpleHall + ((PriceSimpleHall * 20) / 100);//піднімаєм ціну на 20 % від SimpleHall
        }


        public string DefinePrice(string initHall) 
        {
            bool switcher = false;
            string resultHull = "";

            for (int i = 0; i < initHall.Length; i++)
            {
                if (switcher is true)
                    resultHull += initHall[i];
                if (initHall[i] == '\n')
                    switcher = true;
            }

            switch (resultHull)
            {
                case "Звичайний зал":
                    return PriceSimpleHall.ToString();
                case "Звичайний зал 3D":
                    return Price3DHall.ToString();
                case "VIP зал":
                    return PriceVIPHall.ToString();
                case "3D VIP зал":
                    return Price3DVIPHall.ToString();
                default:
                    throw new Exception("SearchHallError");
                    
            }
        }
    }
}