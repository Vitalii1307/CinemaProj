using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cinema_in_Csh
{
    public partial class FormInfoCenterOffice : Form
    {
        public FormInfoCenterOffice(CenterOffice centerOffice)
        {
            InitializeComponent();
            laNameGenDirector.Text += centerOffice.NameGeneralDirector.Name;
            laAddress.Text += centerOffice.AddressOffice;
        }

        private void FormInfoCenterOffice_Load(object sender, EventArgs e)
        {

        }
    }
}
