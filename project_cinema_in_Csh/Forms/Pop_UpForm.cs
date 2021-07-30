using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cinema_in_Csh.Forms
{
    public partial class Pop_UpForm : Form
    {

        public Pop_UpForm(string titleStr, string changeStr)
        {
            InitializeComponent();
            labTitle.Text = titleStr;
            labChange.Text = changeStr;
        }
    }
}
