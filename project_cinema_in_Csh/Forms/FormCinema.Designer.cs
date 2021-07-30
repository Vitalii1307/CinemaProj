using project_cinema_in_Csh.Aphish;
using System.Collections.Generic;
using System.Windows.Forms;
namespace project_cinema_in_Csh
{
    partial class FormCinema
    {

        private int locationX = 280;
        private int locationY = 80;
        List<Poster> allPosters;
        public Cinema FirstCinema { get; private set; }
        List<Label> labelsPoster = new List<Label>();
        List<Label> labelsEmploe = new List<Label>();
        List<Hall> halls = new List<Hall>();
        Label labelAdmin = new Label();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCinema));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFirst = new System.Windows.Forms.TabPage();
            this.butCuncelForm = new System.Windows.Forms.Button();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkButAll = new System.Windows.Forms.LinkLabel();
            this.linkLabMuvie = new System.Windows.Forms.LinkLabel();
            this.linkLabCartoon = new System.Windows.Forms.LinkLabel();
            this.linkLabShFim = new System.Windows.Forms.LinkLabel();
            this.tabInformEmploye = new System.Windows.Forms.TabPage();
            this.butCuncelForm2 = new System.Windows.Forms.Button();
            this.linkAdmin = new System.Windows.Forms.LinkLabel();
            this.linkEmploye = new System.Windows.Forms.LinkLabel();
            this.tabTech = new System.Windows.Forms.TabPage();
            this.butCuncelForm3 = new System.Windows.Forms.Button();
            this.labHall = new System.Windows.Forms.Label();
            this.ChangePosWorkers = new System.Windows.Forms.TabPage();
            this.butChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDuties = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labWorkWithEmp = new System.Windows.Forms.Label();
            this.comboBoxWorkWithEmp = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageFirst.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabInformEmploye.SuspendLayout();
            this.tabTech.SuspendLayout();
            this.ChangePosWorkers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFirst);
            this.tabControl1.Controls.Add(this.tabInformEmploye);
            this.tabControl1.Controls.Add(this.tabTech);
            this.tabControl1.Controls.Add(this.ChangePosWorkers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 381);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageFirst
            // 
            this.tabPageFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageFirst.Controls.Add(this.butCuncelForm);
            this.tabPageFirst.Controls.Add(this.comboBoxSort);
            this.tabPageFirst.Controls.Add(this.panel1);
            this.tabPageFirst.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPageFirst.Location = new System.Drawing.Point(4, 22);
            this.tabPageFirst.Name = "tabPageFirst";
            this.tabPageFirst.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFirst.Size = new System.Drawing.Size(661, 355);
            this.tabPageFirst.TabIndex = 0;
            this.tabPageFirst.Text = "Кіноафіша";
            this.tabPageFirst.UseVisualStyleBackColor = true;
            // 
            // butCuncelForm
            // 
            this.butCuncelForm.Location = new System.Drawing.Point(571, 317);
            this.butCuncelForm.Name = "butCuncelForm";
            this.butCuncelForm.Size = new System.Drawing.Size(82, 30);
            this.butCuncelForm.TabIndex = 6;
            this.butCuncelForm.Text = "Назад";
            this.butCuncelForm.UseVisualStyleBackColor = true;
            this.butCuncelForm.Click += new System.EventHandler(this.butCuncelForm_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "За рейтингом",
            "За назвою",
            "За бюджетом"});
            this.comboBoxSort.Location = new System.Drawing.Point(532, 6);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSort.TabIndex = 5;
            this.comboBoxSort.Text = "Сортувати ";
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            this.comboBoxSort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSort_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.linkButAll);
            this.panel1.Controls.Add(this.linkLabMuvie);
            this.panel1.Controls.Add(this.linkLabCartoon);
            this.panel1.Controls.Add(this.linkLabShFim);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 341);
            this.panel1.TabIndex = 4;
            // 
            // linkButAll
            // 
            this.linkButAll.AutoSize = true;
            this.linkButAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkButAll.LinkColor = System.Drawing.Color.Black;
            this.linkButAll.Location = new System.Drawing.Point(3, 278);
            this.linkButAll.Name = "linkButAll";
            this.linkButAll.Size = new System.Drawing.Size(106, 24);
            this.linkButAll.TabIndex = 3;
            this.linkButAll.TabStop = true;
            this.linkButAll.Text = "Всі стрічки\r\n";
            this.linkButAll.Click += new System.EventHandler(this.linkButAll_Click);
            // 
            // linkLabMuvie
            // 
            this.linkLabMuvie.AutoSize = true;
            this.linkLabMuvie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabMuvie.LinkColor = System.Drawing.Color.Black;
            this.linkLabMuvie.Location = new System.Drawing.Point(3, 45);
            this.linkLabMuvie.Name = "linkLabMuvie";
            this.linkLabMuvie.Size = new System.Drawing.Size(75, 24);
            this.linkLabMuvie.TabIndex = 0;
            this.linkLabMuvie.TabStop = true;
            this.linkLabMuvie.Text = "Фільми";
            this.linkLabMuvie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabMuvie_MouseClick);
            // 
            // linkLabCartoon
            // 
            this.linkLabCartoon.AutoSize = true;
            this.linkLabCartoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabCartoon.LinkColor = System.Drawing.Color.Black;
            this.linkLabCartoon.Location = new System.Drawing.Point(3, 119);
            this.linkLabCartoon.Name = "linkLabCartoon";
            this.linkLabCartoon.Size = new System.Drawing.Size(129, 24);
            this.linkLabCartoon.TabIndex = 1;
            this.linkLabCartoon.TabStop = true;
            this.linkLabCartoon.Text = "Мультфільми";
            this.linkLabCartoon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabCartoon_MouseClick);
            // 
            // linkLabShFim
            // 
            this.linkLabShFim.AutoSize = true;
            this.linkLabShFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabShFim.LinkColor = System.Drawing.Color.Black;
            this.linkLabShFim.Location = new System.Drawing.Point(3, 204);
            this.linkLabShFim.Name = "linkLabShFim";
            this.linkLabShFim.Size = new System.Drawing.Size(146, 24);
            this.linkLabShFim.TabIndex = 2;
            this.linkLabShFim.TabStop = true;
            this.linkLabShFim.Text = "Короткі фільми";
            this.linkLabShFim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabShFim_MouseClick);
            // 
            // tabInformEmploye
            // 
            this.tabInformEmploye.Controls.Add(this.butCuncelForm2);
            this.tabInformEmploye.Controls.Add(this.linkAdmin);
            this.tabInformEmploye.Controls.Add(this.linkEmploye);
            this.tabInformEmploye.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabInformEmploye.Location = new System.Drawing.Point(4, 22);
            this.tabInformEmploye.Name = "tabInformEmploye";
            this.tabInformEmploye.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformEmploye.Size = new System.Drawing.Size(661, 355);
            this.tabInformEmploye.TabIndex = 1;
            this.tabInformEmploye.Text = "Інформація про працівників";
            this.tabInformEmploye.UseVisualStyleBackColor = true;
            // 
            // butCuncelForm2
            // 
            this.butCuncelForm2.Location = new System.Drawing.Point(571, 317);
            this.butCuncelForm2.Name = "butCuncelForm2";
            this.butCuncelForm2.Size = new System.Drawing.Size(82, 30);
            this.butCuncelForm2.TabIndex = 7;
            this.butCuncelForm2.Text = "Назад";
            this.butCuncelForm2.UseVisualStyleBackColor = true;
            this.butCuncelForm2.Click += new System.EventHandler(this.butCuncelForm2_Click);
            // 
            // linkAdmin
            // 
            this.linkAdmin.AutoSize = true;
            this.linkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkAdmin.LinkColor = System.Drawing.Color.Black;
            this.linkAdmin.Location = new System.Drawing.Point(364, 29);
            this.linkAdmin.Name = "linkAdmin";
            this.linkAdmin.Size = new System.Drawing.Size(133, 24);
            this.linkAdmin.TabIndex = 2;
            this.linkAdmin.TabStop = true;
            this.linkAdmin.Text = "Адміністрація";
            this.linkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdmin_LinkClicked);
            // 
            // linkEmploye
            // 
            this.linkEmploye.AutoSize = true;
            this.linkEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkEmploye.LinkColor = System.Drawing.Color.Black;
            this.linkEmploye.Location = new System.Drawing.Point(54, 29);
            this.linkEmploye.Name = "linkEmploye";
            this.linkEmploye.Size = new System.Drawing.Size(112, 24);
            this.linkEmploye.TabIndex = 1;
            this.linkEmploye.TabStop = true;
            this.linkEmploye.Text = "Працівники";
            this.linkEmploye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmploye_LinkClicked);
            // 
            // tabTech
            // 
            this.tabTech.Controls.Add(this.butCuncelForm3);
            this.tabTech.Controls.Add(this.labHall);
            this.tabTech.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabTech.Location = new System.Drawing.Point(4, 22);
            this.tabTech.Name = "tabTech";
            this.tabTech.Size = new System.Drawing.Size(661, 355);
            this.tabTech.TabIndex = 2;
            this.tabTech.Text = "Технічна частина";
            this.tabTech.UseVisualStyleBackColor = true;
            // 
            // butCuncelForm3
            // 
            this.butCuncelForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCuncelForm3.Location = new System.Drawing.Point(571, 317);
            this.butCuncelForm3.Name = "butCuncelForm3";
            this.butCuncelForm3.Size = new System.Drawing.Size(82, 30);
            this.butCuncelForm3.TabIndex = 8;
            this.butCuncelForm3.Text = "Назад";
            this.butCuncelForm3.UseVisualStyleBackColor = true;
            this.butCuncelForm3.Click += new System.EventHandler(this.butCuncelForm3_Click);
            // 
            // labHall
            // 
            this.labHall.AutoSize = true;
            this.labHall.Location = new System.Drawing.Point(249, 39);
            this.labHall.Name = "labHall";
            this.labHall.Size = new System.Drawing.Size(61, 25);
            this.labHall.TabIndex = 0;
            this.labHall.Text = "Зали";
            // 
            // ChangePosWorkers
            // 
            this.ChangePosWorkers.Controls.Add(this.butChange);
            this.ChangePosWorkers.Controls.Add(this.label4);
            this.ChangePosWorkers.Controls.Add(this.label3);
            this.ChangePosWorkers.Controls.Add(this.textBoxDuties);
            this.ChangePosWorkers.Controls.Add(this.textBoxPosition);
            this.ChangePosWorkers.Controls.Add(this.label2);
            this.ChangePosWorkers.Controls.Add(this.label1);
            this.ChangePosWorkers.Controls.Add(this.textBoxSalary);
            this.ChangePosWorkers.Controls.Add(this.labWorkWithEmp);
            this.ChangePosWorkers.Controls.Add(this.comboBoxWorkWithEmp);
            this.ChangePosWorkers.Location = new System.Drawing.Point(4, 22);
            this.ChangePosWorkers.Name = "ChangePosWorkers";
            this.ChangePosWorkers.Size = new System.Drawing.Size(661, 355);
            this.ChangePosWorkers.TabIndex = 3;
            this.ChangePosWorkers.Text = "Робота з кадрами";
            this.ChangePosWorkers.UseVisualStyleBackColor = true;
            // 
            // butChange
            // 
            this.butChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butChange.Location = new System.Drawing.Point(48, 226);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(197, 79);
            this.butChange.TabIndex = 9;
            this.butChange.Text = "Знінити";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Обов\'язки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Посада";
            // 
            // textBoxDuties
            // 
            this.textBoxDuties.Location = new System.Drawing.Point(377, 256);
            this.textBoxDuties.MaxLength = 100;
            this.textBoxDuties.Name = "textBoxDuties";
            this.textBoxDuties.Size = new System.Drawing.Size(188, 20);
            this.textBoxDuties.TabIndex = 6;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(377, 182);
            this.textBoxPosition.MaxLength = 100;
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(188, 20);
            this.textBoxPosition.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(187, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Зміна параметрів робітника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Зарплата";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(468, 130);
            this.textBoxSalary.MaxLength = 6;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(97, 20);
            this.textBoxSalary.TabIndex = 2;
            this.textBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalary_KeyPress);
            // 
            // labWorkWithEmp
            // 
            this.labWorkWithEmp.AutoSize = true;
            this.labWorkWithEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labWorkWithEmp.Location = new System.Drawing.Point(63, 103);
            this.labWorkWithEmp.Name = "labWorkWithEmp";
            this.labWorkWithEmp.Size = new System.Drawing.Size(157, 24);
            this.labWorkWithEmp.TabIndex = 1;
            this.labWorkWithEmp.Text = "Вибір робітників";
            // 
            // comboBoxWorkWithEmp
            // 
            this.comboBoxWorkWithEmp.FormattingEnabled = true;
            this.comboBoxWorkWithEmp.Location = new System.Drawing.Point(3, 130);
            this.comboBoxWorkWithEmp.Name = "comboBoxWorkWithEmp";
            this.comboBoxWorkWithEmp.Size = new System.Drawing.Size(292, 21);
            this.comboBoxWorkWithEmp.TabIndex = 0;
            this.comboBoxWorkWithEmp.Text = "Оберіть робітника";
            this.comboBoxWorkWithEmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkWithEmp_SelectedIndexChanged);
            this.comboBoxWorkWithEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxWorkWithEmp_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 381);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiplexKyiv";
            this.Load += new System.EventHandler(this.FormCinema_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFirst.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabInformEmploye.ResumeLayout(false);
            this.tabInformEmploye.PerformLayout();
            this.tabTech.ResumeLayout(false);
            this.tabTech.PerformLayout();
            this.ChangePosWorkers.ResumeLayout(false);
            this.ChangePosWorkers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabInformEmploye;
        private System.Windows.Forms.TabPage tabTech;
        private System.Windows.Forms.LinkLabel linkLabShFim;
        private System.Windows.Forms.LinkLabel linkLabCartoon;
        private System.Windows.Forms.LinkLabel linkLabMuvie;
        private System.Windows.Forms.LinkLabel linkAdmin;
        private System.Windows.Forms.LinkLabel linkEmploye;
        private System.Windows.Forms.Label labHall;
        private Panel panel1;
        private LinkLabel linkButAll;
        private ComboBox comboBoxSort;
        private Button butCuncelForm;
        private Button butCuncelForm2;
        private Button butCuncelForm3;
        protected internal TabControl tabControl1;
        protected internal TabPage tabPageFirst;
        private TabPage ChangePosWorkers;
        private Label labWorkWithEmp;
        private ComboBox comboBoxWorkWithEmp;
        private Button butChange;
        private Label label4;
        private Label label3;
        private TextBox textBoxDuties;
        private TextBox textBoxPosition;
        private Label label2;
        private Label label1;
        private TextBox textBoxSalary;
        private Timer timer1;
    }
}