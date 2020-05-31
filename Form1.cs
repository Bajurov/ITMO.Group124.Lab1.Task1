using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Group124.Bajurov.Lab1.Task1
{
    public partial class formTreyResearch : Form
    {
        public formTreyResearch()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void buttonBorderStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }
    }
}
