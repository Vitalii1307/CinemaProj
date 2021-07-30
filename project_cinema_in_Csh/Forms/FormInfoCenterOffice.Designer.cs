namespace project_cinema_in_Csh
{
    partial class FormInfoCenterOffice
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoCenterOffice));
            this.btInOffiCen = new System.Windows.Forms.Button();
            this.laNameGenDirector = new System.Windows.Forms.Label();
            this.laAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btInOffiCen
            // 
            this.btInOffiCen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btInOffiCen.Location = new System.Drawing.Point(134, 149);
            this.btInOffiCen.Name = "btInOffiCen";
            this.btInOffiCen.Size = new System.Drawing.Size(123, 47);
            this.btInOffiCen.TabIndex = 0;
            this.btInOffiCen.Text = "Зрозуміло";
            this.btInOffiCen.UseVisualStyleBackColor = true;
            // 
            // laNameGenDirector
            // 
            this.laNameGenDirector.AutoSize = true;
            this.laNameGenDirector.Location = new System.Drawing.Point(12, 59);
            this.laNameGenDirector.Name = "laNameGenDirector";
            this.laNameGenDirector.Size = new System.Drawing.Size(158, 13);
            this.laNameGenDirector.TabIndex = 1;
            this.laNameGenDirector.Text = "Ім\'я генерального директора:";
            // 
            // laAddress
            // 
            this.laAddress.AutoSize = true;
            this.laAddress.Location = new System.Drawing.Point(12, 106);
            this.laAddress.Name = "laAddress";
            this.laAddress.Size = new System.Drawing.Size(132, 13);
            this.laAddress.TabIndex = 2;
            this.laAddress.Text = "Адреса головного офісу:";
            // 
            // FormInfoCenterOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 208);
            this.Controls.Add(this.laAddress);
            this.Controls.Add(this.laNameGenDirector);
            this.Controls.Add(this.btInOffiCen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfoCenterOffice";
            this.Text = "FormInfoCenterOffice";
            this.Load += new System.EventHandler(this.FormInfoCenterOffice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInOffiCen;
        private System.Windows.Forms.Label laNameGenDirector;
        private System.Windows.Forms.Label laAddress;
    }
}