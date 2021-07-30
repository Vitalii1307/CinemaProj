using project_cinema_in_Csh.Aphish;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace project_cinema_in_Csh
{
    public partial class FormStart : Form
    {
        BinaryFormatter binaryFormatter;
        List<int> listIDs = new List<int>();
        CenterOffice centerOffice;
        public FormStart()
        {
            InitializeComponent();
            binaryFormatter = new BinaryFormatter();
        }
       
        public void button1_Click(object sender, EventArgs e)
        {
            
            Cinema cinema = new Cinema("Multiplex Kyiv", "вулиця Січових Стрільців, 93",
               new Administration("Пилип Пилипченко", "Головний адміністратор", "Давати вказівки", 1975, CreateID(listIDs)));

            try
            {
                var avatar = new Movie("Lightstorm Entertainment", "Мауро Фіоре", "Аватар 2", "Avatar", "наукова фантастика", "Джеймс Кэмерон", "США", 237, 8.5);
                var advePagn = new Movie("Heyday Films", "Эрик Уилсон", "The Adventures of Paddington 2 ", "The Adventures of Paddington ", "сімейний фільм", "Пол Кинг", "Великобританія", 55, 9.7);

                cinema.AddMovie(avatar);
                cinema.AddMovie(advePagn);

                var toyStory = new Cartoon("3D", "Джон Лассетер", "Історія іграшок", "комп'ютерна анімация", "Джон Лассетер", "США", 30, 3.4);
                var songSea = new Cartoon("Детский фильм", "Томм Мур", "Песнь моря", "фэнтезийный фильм", "Томм Мур", "Ирландия", 7.5, 5.1);

                cinema.AddCartoon(toyStory);
                cinema.AddCartoon(songSea);

                var wayHome = new ShortFilm("Дорога додому", "драма", "Дмитро Авдєєв", "Україна", 1.5, 7.6) { Duration = 18, Type = "драматична" };
                var countryToy = new ShortFilm("Країна іграшок", "драма", "Йохан А. Буннерс", "Німеччина", 30, 6.4) { Duration = 14, Type = "драматична" };

                cinema.AddshortFilm(wayHome);
                cinema.AddshortFilm(countryToy);

              

            }
            catch (MaxLengthException ex)
            {
                MessageBox.Show($"\"{ex.MaximumString}\" имеет превышеное стандартное количество символов");
                return;
            }


            using (StreamReader sr = new StreamReader("hall.txt", System.Text.Encoding.Default))
            {

                while (sr.Peek() != -1) 
                {
                    cinema.Halls.Add(new Hall(int.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()), sr.ReadLine(), sr.ReadLine(), sr.ReadLine()));
                }
               
            }


            try
            {
                var emp1 = new WorkingClass("Васілій", "охорона", 1972, CreateID(listIDs))
                {
                    VarAction = "Забеспечення безпеки на об'єкті (у даному випадку в кінотеатрі)"
                };
                var emp2 = new WorkingClass("Cаша", "білетний контролер", 2001, CreateID(listIDs)) { VarAction = "Обслуговування гостей та продаж білетів" };
                var emp3 = new WorkingClass("Настя", "білетний контролер", 2000, CreateID(listIDs))
                {
                    VarAction = "Обслуговування гостей, продаж білетів та подавати приклад стажувальникам"
                };
                var emp4 = new WorkingClass("Льоня", "бармен-касир", 1991, CreateID(listIDs)) { VarAction = "Радість в обличчі гостей" };
                var emp5 = new WorkingClass("Світлана", "билетный кассир", 1995, CreateID(listIDs)) { VarAction = "Продаж білетів" };
                cinema.AddWorking(emp1);
                cinema.AddWorking(emp2);
                cinema.AddWorking(emp3);
                cinema.AddWorking(emp4);
                cinema.AddWorking(emp5);
            }
            catch (MaxLengthException ex)
            {
                MessageBox.Show($"\"{ex.MaximumString}\" имеет превышеное стандартное количество символов");
                return;
            }

            using (FileStream fs = new FileStream("File.txt", FileMode.OpenOrCreate))
            {
                if (fs.Length == 0)
                {
                    binaryFormatter.Serialize(fs, cinema.Workings);
                }
                else
                    cinema.Workings = (Dictionary<int, WorkingClass>)binaryFormatter.Deserialize(fs);
            }

            var formCin = new FormCinema(cinema);
            Hide();
            formCin.ShowDialog();
            Show();

        }
        private int CreateID(List<int> listIDs)
        {
            while (true)
            {
                Random random = new Random();

                int num = random.Next();
                if (listIDs.Count == 0)
                {
                    listIDs.Add(num);
                    return num;
                }

                if (listIDs.Contains(num)!=true)
                {
                    listIDs.Add(num);
                    return num;
                }
            }
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fInfoCenter = new FormInfoCenterOffice(centerOffice);
            fInfoCenter.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var genDirector = new Administration(" Роберт Снімалов", "Керування мережею", "Генеральний директор", 50, CreateID(listIDs));
                centerOffice = new CenterOffice(genDirector, "London, Wall Street");
            }
            catch (MaxLengthException ex)
            {
                MessageBox.Show($"\"{ex.MaximumString}\" имеет превышеное стандартное количество символов.");
                return;
            }
        }
    }
}