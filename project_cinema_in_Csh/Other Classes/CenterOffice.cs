using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cinema_in_Csh
{
   public class CenterOffice
    {
        private List<Cinema> cinemas = new List<Cinema>();

        public Administration NameGeneralDirector { get; }
        public string AddressOffice { get; }

        public CenterOffice(Administration nameGeneralDirector, string addressOffice) 
        {
            NameGeneralDirector = nameGeneralDirector;
            AddressOffice = addressOffice;
        }
        public void AddCinema(Cinema cinema)
        {
            cinemas.Add(cinema);
        }

    }
}