using System.Collections.Generic;
using System.Windows.Forms;

namespace project_cinema_in_Csh
{
    partial class SessionForm
    {
        private int coordY = 30;

      
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionForm));
            this.labOneDay = new System.Windows.Forms.Label();
            this.labSecondDay = new System.Windows.Forms.Label();
            this.labThirdDay = new System.Windows.Forms.Label();
            this.labFourth = new System.Windows.Forms.Label();
            this.labFifth = new System.Windows.Forms.Label();
            this.labSixth = new System.Windows.Forms.Label();
            this.labSeventh = new System.Windows.Forms.Label();
            this.butSaveInForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labOneDay
            // 
            this.labOneDay.AutoSize = true;
            this.labOneDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labOneDay.Location = new System.Drawing.Point(12, 30);
            this.labOneDay.Name = "labOneDay";
            this.labOneDay.Size = new System.Drawing.Size(82, 18);
            this.labOneDay.TabIndex = 0;
            this.labOneDay.Text = "Понеділок";
            // 
            // labSecondDay
            // 
            this.labSecondDay.AutoSize = true;
            this.labSecondDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSecondDay.Location = new System.Drawing.Point(12, 80);
            this.labSecondDay.Name = "labSecondDay";
            this.labSecondDay.Size = new System.Drawing.Size(70, 18);
            this.labSecondDay.TabIndex = 1;
            this.labSecondDay.Text = "Вівторок";
            // 
            // labThirdDay
            // 
            this.labThirdDay.AutoSize = true;
            this.labThirdDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labThirdDay.Location = new System.Drawing.Point(12, 130);
            this.labThirdDay.Name = "labThirdDay";
            this.labThirdDay.Size = new System.Drawing.Size(60, 18);
            this.labThirdDay.TabIndex = 2;
            this.labThirdDay.Text = "Середа";
            // 
            // labFourth
            // 
            this.labFourth.AutoSize = true;
            this.labFourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labFourth.Location = new System.Drawing.Point(12, 180);
            this.labFourth.Name = "labFourth";
            this.labFourth.Size = new System.Drawing.Size(57, 18);
            this.labFourth.TabIndex = 3;
            this.labFourth.Text = "Четвер";
            // 
            // labFifth
            // 
            this.labFifth.AutoSize = true;
            this.labFifth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labFifth.Location = new System.Drawing.Point(12, 230);
            this.labFifth.Name = "labFifth";
            this.labFifth.Size = new System.Drawing.Size(69, 18);
            this.labFifth.TabIndex = 4;
            this.labFifth.Text = "П\'ятниця";
            // 
            // labSixth
            // 
            this.labSixth.AutoSize = true;
            this.labSixth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSixth.Location = new System.Drawing.Point(12, 280);
            this.labSixth.Name = "labSixth";
            this.labSixth.Size = new System.Drawing.Size(59, 18);
            this.labSixth.TabIndex = 5;
            this.labSixth.Text = "Субота";
            // 
            // labSeventh
            // 
            this.labSeventh.AutoSize = true;
            this.labSeventh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSeventh.Location = new System.Drawing.Point(12, 330);
            this.labSeventh.Name = "labSeventh";
            this.labSeventh.Size = new System.Drawing.Size(56, 18);
            this.labSeventh.TabIndex = 6;
            this.labSeventh.Text = "Неділя";
            // 
            // butSaveInForm
            // 
            this.butSaveInForm.Location = new System.Drawing.Point(639, 340);
            this.butSaveInForm.Name = "butSaveInForm";
            this.butSaveInForm.Size = new System.Drawing.Size(85, 38);
            this.butSaveInForm.TabIndex = 7;
            this.butSaveInForm.Text = "Завантахити у файл";
            this.butSaveInForm.UseVisualStyleBackColor = true;
            this.butSaveInForm.Click += new System.EventHandler(this.butSaveInForm_Click);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 390);
            this.Controls.Add(this.butSaveInForm);
            this.Controls.Add(this.labSeventh);
            this.Controls.Add(this.labSixth);
            this.Controls.Add(this.labFifth);
            this.Controls.Add(this.labFourth);
            this.Controls.Add(this.labThirdDay);
            this.Controls.Add(this.labSecondDay);
            this.Controls.Add(this.labOneDay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SessionForm";
            this.Load += new System.EventHandler(this.SessionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label labOneDay;
        private System.Windows.Forms.Label labSecondDay;
        private System.Windows.Forms.Label labThirdDay;
        private System.Windows.Forms.Label labFourth;
        private System.Windows.Forms.Label labFifth;
        private System.Windows.Forms.Label labSixth;
        private System.Windows.Forms.Label labSeventh;
        private Button butSaveInForm;
    }
}