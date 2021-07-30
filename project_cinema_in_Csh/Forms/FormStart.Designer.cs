namespace project_cinema_in_Csh
{
    partial class FormStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.btFirstCinema = new System.Windows.Forms.Button();
            this.labTitul = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btFirstCinema
            // 
            this.btFirstCinema.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFirstCinema.Location = new System.Drawing.Point(112, 114);
            this.btFirstCinema.Name = "btFirstCinema";
            this.btFirstCinema.Size = new System.Drawing.Size(152, 106);
            this.btFirstCinema.TabIndex = 0;
            this.btFirstCinema.Text = "MultiplexKyiv";
            this.btFirstCinema.UseVisualStyleBackColor = true;
            this.btFirstCinema.Click += new System.EventHandler(this.button1_Click);
            // 
            // labTitul
            // 
            this.labTitul.AutoSize = true;
            this.labTitul.Enabled = false;
            this.labTitul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTitul.Location = new System.Drawing.Point(41, 50);
            this.labTitul.Name = "labTitul";
            this.labTitul.Size = new System.Drawing.Size(309, 20);
            this.labTitul.TabIndex = 1;
            this.labTitul.Text = "Вас вітає мережа кінотеатрів \"Multiplex\"";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 281);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Інформація про головний офіс";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(393, 316);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labTitul);
            this.Controls.Add(this.btFirstCinema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFirstCinema;
        private System.Windows.Forms.Label labTitul;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

