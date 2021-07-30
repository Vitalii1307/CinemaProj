using project_cinema_in_Csh.Comparers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cinema_in_Csh
{

    public partial class SessionForm : Form
    {
        public List<Label> labelsMon;
        public List<Label> labelsTue;
        public List<Label> labelsWed;
        public List<Label> labelsTho;
        public List<Label> labelsFri;
        public List<Label> labelsSat;
        public List<Label> labelsSun;

        string NameFilm { get; set; }

        SessionManager SessionManager { get; set; }

        TicketPrice<Poster> TicketPrice { get; set; }

        public SessionForm(string label, SessionManager sessionManager, TicketPrice<Poster> ticketPrice)
        {
            InitializeComponent();

            NameFilm = label;
            SessionManager = sessionManager;
            TicketPrice = ticketPrice;
            labelsMon = new List<Label>();
            labelsTue = new List<Label>();
            labelsWed = new List<Label>();
            labelsTho = new List<Label>();
            labelsFri = new List<Label>();
            labelsSat = new List<Label>();
            labelsSun = new List<Label>();
        }

        private void SessionForm_Load(object sender, EventArgs e)
        {


            CreateLabels(SessionManager);

            Label[] arraysMon = labelsMon.ToArray();
            Label[] arraysTue = labelsTue.ToArray();
            Label[] arraysWed = labelsWed.ToArray();
            Label[] arraysTho = labelsTho.ToArray();
            Label[] arraysFri = labelsFri.ToArray();
            Label[] arraysSat = labelsSat.ToArray();
            Label[] arraysSun = labelsSun.ToArray();

            

            Array.Sort(arraysMon, new TimeComparer());
            Array.Sort(arraysTue, new TimeComparer());
            Array.Sort(arraysWed, new TimeComparer());
            Array.Sort(arraysTho, new TimeComparer());
            Array.Sort(arraysFri, new TimeComparer());
            Array.Sort(arraysSat, new TimeComparer());
            Array.Sort(arraysSun, new TimeComparer());

            labelsMon = arraysMon.ToList();
            labelsTue = arraysTue.ToList();
            labelsWed = arraysWed.ToList();
            labelsTho = arraysTho.ToList();
            labelsFri = arraysFri.ToList();
            labelsSat = arraysSat.ToList();
            labelsSun = arraysSun.ToList();

            IlluminationCurrentLabels(SessionManager.VarAction);

            PrintAllLabels(labelsMon);
            PrintAllLabels(labelsTue);
            PrintAllLabels(labelsWed);
            PrintAllLabels(labelsTho);
            PrintAllLabels(labelsFri);
            PrintAllLabels(labelsSat);
            PrintAllLabels(labelsSun);

            ToolTip toolAphish = new ToolTip();
            List<Label> allLabel = Cinema.GlueList(labelsMon.ToArray(), labelsTue.ToArray(), labelsWed.ToArray(), labelsTho.ToArray(),
                labelsFri.ToArray(), labelsSat.ToArray(), labelsSun.ToArray());
            foreach (var label in allLabel)
            {
                label.MouseEnter += (s, a) => { Label_MouseEnter(s, toolAphish); };
                label.MouseLeave += (s, a) => { toolAphish.Hide(label); };
            }



        }

        private void Label_MouseEnter(object sender, ToolTip toolAphish)
        {
            Label label = (Label)sender;

            toolAphish.SetToolTip(label, $"Середня ціна за квиток: {TicketPrice.DefinePrice(label.Text)} грн.");
        }



        private void IlluminationCurrentLabels(string DayWeek)
        {

            switch (DayWeek)
            {
                case "Monday":
                    {
                        CheckArr(labelsMon);
                    }
                    break;
                case "Tuesday":
                    {
                        CheckArr(labelsTue);
                    }
                    break;
                case "Wednesday":
                    {
                        CheckArr(labelsWed);
                    }
                    break;
                case "Thursday":
                    {
                        CheckArr(labelsTho);
                    }
                    break;
                case "Friday":
                    {
                        CheckArr(labelsFri);
                    }
                    break;
                case "Saturday":
                    {
                        CheckArr(labelsSat);
                    }
                    break;
                case "Sunday":
                    {
                        CheckArr(labelsSun);
                    }
                    break;
                default:
                    break;
            }
        }

        private void CheckArr(List<Label> ListDay)
        {
            int currentTime = int.Parse(SessionManager.Action());
            //int currentTime = 19;

            string timeFilmToday = "";
            foreach (var item in ListDay)
            {
                int k = 0;

                while (item.Text[k] != ':')
                {
                    timeFilmToday += item.Text[k];
                    k++;
                }
                int timeFilmTodayNum = int.Parse(timeFilmToday);
                if (currentTime == timeFilmTodayNum || currentTime == timeFilmTodayNum + 1 || currentTime == timeFilmTodayNum + 2)
                {
                    item.BackColor = Color.Red;
                }
                timeFilmToday = "";
            }
        }

        private void CreateLabels(SessionManager sessionManager)
        {

            InitListDays(SessionManager.postersHallSimple, SessionManager.DayInWeek, SessionManager.SessionsInHallSimple - 1, 1);
            InitListDays(SessionManager.postersHall3DVip, SessionManager.DayInWeek, SessionManager.SessionsInHall3D - 1, 2);
            InitListDays(SessionManager.postersHallVip, SessionManager.DayInWeek, SessionManager.SessionsInHallVip - 1, 3);
            InitListDays(SessionManager.postersHall3DVip, SessionManager.DayInWeek, SessionManager.SessionsInHall3DVip - 1, 4);
        }

        private void InitListDays(Poster[,] posters, int x, int y, int numHall)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (posters[i, j].Name == NameFilm && i == 0)
                    {
                        labelsMon.Add(new Label() { Text = TimeToText(j, numHall) });
                    }

                    else if (posters[i, j].Name == NameFilm && i == 1)
                    {
                        labelsTue.Add(new Label() { Text = TimeToText(j, numHall) });
                    }

                    else if (posters[i, j].Name == NameFilm && i == 2)
                    {
                        labelsWed.Add(new Label() { Text = TimeToText(j, numHall) });
                    }

                    else if (posters[i, j].Name == NameFilm && i == 3)
                    {
                        labelsTho.Add(new Label() { Text = TimeToText(j, numHall) });
                    }

                    else if (posters[i, j].Name == NameFilm && i == 4)
                    {
                        labelsFri.Add(new Label() { Text = TimeToText(j, numHall) });
                    }

                    else if (posters[i, j].Name == NameFilm && i == 5)
                    {
                        labelsSat.Add(new Label() { Text = TimeToText(j, numHall) });
                    }

                    else if (posters[i, j].Name == NameFilm && i == 6)
                    {
                        labelsSun.Add(new Label() { Text = TimeToText(j, numHall) });
                    }

                }
            }

        }

        private string TimeToText(int index, int NumHall)
        {
            string[] TimeSimpeHall = { "9:00\nЗвичайний зал", "12:00\nЗвичайний зал", "15:00\nЗвичайний зал", "18:00\nЗвичайний зал", "21:00\nЗвичайний зал" };
            string[] Time3DSimpeHall = { "11:00\nЗвичайний зал 3D", "14:00\nЗвичайний зал 3D", "17:00\nЗвичайний зал 3D", "20:00\nЗвичайний зал 3D", "23:00\nЗвичайний зал 3D" };
            string[] TimeVipHall = { "3:00\nVIP зал", "12:00\nVIP зал", "16:00\nVIP зал", "21:00\nVIP зал" };
            string[] Time3DVipHall = { "3:00\n3D VIP зал", "14:00\n3D VIP зал", "17:00\n3D VIP зал", "21:00\n3D VIP зал" };

            return NumHall switch
            {
                1 => TimeSimpeHall[index],
                2 => Time3DSimpeHall[index],
                3 => TimeVipHall[index],
                4 => Time3DVipHall[index],
                _ => throw new Exception("NotFoundHall")
            };

        }
       


        private void PrintAllLabels(List<Label> labelsInDay)
        {
            int coordX = 110;
            for (int i = 0; i < labelsInDay.Count; i++)
            {
                labelsInDay[i].Size = new System.Drawing.Size(110, 30);
                labelsInDay[i].Location = new Point(coordX, coordY);
                labelsInDay[i].Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Bold);
                Controls.Add(labelsInDay[i]);
                coordX += 120;
            }
            coordY += 50;

        }

        private async Task SaveToFile(StreamWriter fs, List<Label> labels, int indexDay)
        {
            string[] days = { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" };

            try
            {
                await fs.WriteLineAsync("\t\t" + NameFilm);
                await fs.WriteLineAsync("\t" + days[indexDay]);
                for (int i = 0, j = 0; i < labels.Count; i++, j++)
                {
                    await fs.WriteLineAsync(labels[i].Text);
                    await fs.WriteLineAsync();
                }
                await fs.WriteLineAsync("---------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butSaveInForm_Click(object sender, EventArgs e)
        {
            using (StreamWriter fs = new StreamWriter("FileWithInfo.txt", false, System.Text.Encoding.Default))
            {
                SaveToFile(fs, labelsMon, 0);
                SaveToFile(fs, labelsTue, 1);
                SaveToFile(fs, labelsWed, 2);
                SaveToFile(fs, labelsTho, 3);
                SaveToFile(fs, labelsFri, 4);
                SaveToFile(fs, labelsSat, 5);
                SaveToFile(fs, labelsSun, 6);
            }
        }
    }
}