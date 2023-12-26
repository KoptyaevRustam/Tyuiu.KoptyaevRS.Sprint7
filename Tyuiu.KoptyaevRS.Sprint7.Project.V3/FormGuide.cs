using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KoptyaevRS.Sprint7.Project.V3
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }

        private void buttonOkey_KRS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
