using project_cinema_in_Csh.Comparers;
using project_cinema_in_Csh.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace project_cinema_in_Csh
{
    public delegate void ShowPrice(object obj, ToolTip tip);
    public partial class FormCinema : Form
    {
        Pop_UpForm formPop;
        public FormCinema(Cinema cinema)
        {
            InitializeComponent();

            ToolTip toolAphish = new ToolTip();
            halls = cinema.Halls;


            for (int i = 0; i < cinema.movies.Count + cinema.cartoons.Count + cinema.shortFilms.Count; i++)
            {
                labelsPoster.Add(new Label());
                labelsPoster[i].Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular);
            }
            allPosters = Cinema.GlueList<Poster>(cinema.cartoons.ToArray(), cinema.movies.ToArray(), cinema.shortFilms.ToArray());

            foreach (Label label in labelsPoster)
            {
                label.Click += (s, a) => { startSessionForm(label); };
                label.MouseEnter += (s, a) => { event_label_colorRed(s); event_label_cinema(s, toolAphish); };
                label.MouseLeave += (s, a) => { event_label_colorBlack(s); toolAphish.Hide(label); };
            }

            FirstCinema = cinema;
        }

        private void startSessionForm(Label label)
        {
            Poster posterInst = new Poster();
            IAction sessionMen = new SessionManager(allPosters);
            sessionMen.Action();
            foreach (var pos in allPosters)
            {
                if (pos.Name == label.Text)
                    posterInst = pos;
            }

            TicketPrice<Poster> ticketPrice = new TicketPrice<Poster>(posterInst);
            ticketPrice.LoadPrice();
            var sessionForm = new SessionForm(ticketPrice.Film.Name, (SessionManager)sessionMen, ticketPrice);

            sessionForm.Text = ticketPrice.Film.Name;
            Hide();
            sessionForm.ShowDialog();
            Show();
        }

        private void FormCinema_Load(object sender, EventArgs e)
        {
            textBoxSalary.ReadOnly = true;
            textBoxDuties.ReadOnly = true;
            textBoxPosition.ReadOnly = true;
            comboBoxWorkWithEmp.Items.AddRange(FirstCinema.Workings.Values.ToArray());

            PrintHalls(FirstCinema.Halls);
        }



        private void linkLabMuvie_MouseClick(object sender, MouseEventArgs e)
        {
            linkLabMuvie.LinkColor = Color.Red;
            linkLabCartoon.LinkColor = Color.Black;
            linkLabShFim.LinkColor = Color.Black;
            linkButAll.LinkColor = Color.Black;
            PrintLabels(FirstCinema.movies.ToArray());
        }

        private void linkLabCartoon_MouseClick(object sender, MouseEventArgs e)
        {
            linkLabCartoon.LinkColor = Color.Red;
            linkLabMuvie.LinkColor = Color.Black;
            linkLabShFim.LinkColor = Color.Black;
            linkButAll.LinkColor = Color.Black;
            PrintLabels(FirstCinema.cartoons.ToArray());
        }

        private void linkLabShFim_MouseClick(object sender, MouseEventArgs e)
        {
            linkLabShFim.LinkColor = Color.Red;
            linkLabMuvie.LinkColor = Color.Black;
            linkLabCartoon.LinkColor = Color.Black;
            linkButAll.LinkColor = Color.Black;
            PrintLabels(FirstCinema.shortFilms.ToArray());
        }

        private void linkButAll_Click(object sender, EventArgs e)
        {
            linkLabMuvie.LinkColor = Color.Black;
            linkLabCartoon.LinkColor = Color.Black;
            linkLabShFim.LinkColor = Color.Black;
            linkButAll.LinkColor = Color.Red;
            PrintLabels(allPosters.ToArray());
        }


        private void event_label_cinema(object sender, ToolTip toolAphish)
        {
            Label label = (Label)sender;
            foreach (var film in allPosters)
            {
                if (label.Text == film.Name)
                {
                    toolAphish.SetToolTip(label, film.ToString());
                    break;
                }
            }
        }

        private void event_label_colorRed(object sender)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Red;
        }
        private void event_label_colorBlack(object sender)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Black;
        }
        

        private void PrintLabels(Poster[] posters)
        {

            for (int i = 0; i < labelsPoster.Count; i++)
            {
                labelsPoster[i].Text = "";
            }

            int j = 0;
            foreach (var item in Cinema.GetPosters(posters))
            {
                labelsPoster[j].Location = new Point(locationX, locationY);
                labelsPoster[j].Size = new System.Drawing.Size(200, 30);
                labelsPoster[j].Text = item.Name;
                tabPageFirst.Controls.Add(labelsPoster[j]);
                locationY += 40;

                j++;
            }
            locationX = 280;
            locationY = 80;
        }

        private void PrintHalls(List<Hall> halls)
        {
            int locationX = 30;

            List<Label> labels = new List<Label>();

            for (int i = 0; i < halls.Count; i++)
            {
                labels.Add(new Label());
                labels[i].Size = new System.Drawing.Size(110, 200);
                labels[i].Location = new Point(locationX, 80);
                labels[i].Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                labels[i].Text = halls[i].ToString();
                tabTech.Controls.Add(labels[i]);
                locationX += 170;
            }
        }
        private void linkEmploye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked();
        }
        private void LinkClicked() 
        {
            ToolTip toolEmploye = new ToolTip();
            linkEmploye.LinkColor = Color.Red;
            linkAdmin.LinkColor = Color.Black;
            int locationY = 90;
            int i = 0;
            foreach (var item in FirstCinema.Workings.Values)
            {
                labelAdmin.Text = "";
                labelAdmin.Size = new System.Drawing.Size(0, 0);
                labelsEmploe.Add(new Label());
                labelsEmploe[i].Location = new Point(100, locationY);
                labelsEmploe[i].Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Regular);
                labelsEmploe[i].Size = new System.Drawing.Size(400, 30);
                labelsEmploe[i].Text = item.ToString();
                tabInformEmploye.Controls.Add(labelsEmploe[i]);
                locationY += 45;
                i++;
            }
            i = 0;
            foreach (var label in labelsEmploe)
            {
                label.MouseEnter += (s, a) => { event_label_employe(s, a, toolEmploye); };
                label.MouseLeave += (s, a) => { toolEmploye.Hide(label); };
            }
        }

        private void event_label_employe(object s, EventArgs a, ToolTip toolEmploye)
        {
            Label label = (Label)s;
            foreach (var employee in FirstCinema.Workings)
            {
                if (label.Text == employee.Value.ToString())
                {
                    toolEmploye.SetToolTip(label, ((IAction)employee.Value).Action());
                }
            }
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkEmploye.LinkColor = Color.Black;
            linkAdmin.LinkColor = Color.Red;

            for (int i = 0; i < labelsEmploe.Count; i++)
            {
                labelsEmploe[i].Text = "";
                labelsEmploe[i].Size = new System.Drawing.Size(0, 0);
            }

            labelAdmin.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Regular);
            labelAdmin.Size = new System.Drawing.Size(1000, 40);
            labelAdmin.Location = new Point(70, 100);
            labelAdmin.Text = FirstCinema.Admin.ToString();
            tabInformEmploye.Controls.Add(labelAdmin);
        }
        private void comboBoxSort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poster[] arrPost = allPosters.ToArray();
            linkButAll_Click(sender, e);

            switch (comboBoxSort.SelectedIndex)
            {
                case 0:
                    {
                        Array.Sort(arrPost, new RatingComparer());
                    }
                    break;
                case 1:
                    {
                        Array.Sort(arrPost);
                    }
                    break;
                case 2:
                    {
                        Array.Sort(arrPost, new BudgetComparer());
                    }
                    break;
                default:
                    {
                        throw new Exception("Unknown error");
                    }
            }
            allPosters = arrPost.ToList();
            linkButAll_Click(sender, e);
        }

        private void butCuncelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butCuncelForm2_Click(object sender, EventArgs e)
        {
            butCuncelForm_Click(sender, e);
        }

        private void butCuncelForm3_Click(object sender, EventArgs e)
        {
            butCuncelForm_Click(sender, e);
        }

        private void comboBoxWorkWithEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void comboBoxWorkWithEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSalary.ReadOnly = false;
            textBoxDuties.ReadOnly = false;
            textBoxPosition.ReadOnly = false;
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            if (comboBoxWorkWithEmp.SelectedIndex == -1)
                return;

            var emp = (WorkingClass)comboBoxWorkWithEmp.SelectedItem;
            emp.Change += Emp_Change;
            emp.Change_Position_VarAction_Salary(textBoxSalary.Text, textBoxPosition.Text, textBoxDuties.Text);

            LinkClicked();
            emp.Change -= Emp_Change;
            textBoxSalary.Text = "";
            textBoxPosition.Text = "";
            textBoxDuties.Text = "";

            comboBoxWorkWithEmp.Items.Clear();
            comboBoxWorkWithEmp.Items.AddRange(FirstCinema.Workings.Values.ToArray());
            comboBoxWorkWithEmp.Text = "Оберіть робітника";

            using (FileStream fs = new FileStream("File.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, FirstCinema.Workings);
            }
        }

        private void Emp_Change(object sender, ChangeEmpEventArgs e)
        {
            butChange.Enabled = false;
            formPop = new Pop_UpForm(((WorkingClass)sender).Name, e.Message);
            formPop.Show();
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            formPop.Close();
            butChange.Enabled = true;
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace
                e.Handled = true;
        }
    }
}
