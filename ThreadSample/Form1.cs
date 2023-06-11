using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSample
{
    public partial class Form1 : Form
    {
        int _locX = 0;
        int _locY = 0;

        public Form1()
        {
            InitializeComponent();

            _locX = this.Location.X;
            _locY = this.Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locX = this.Location.X + this.Size.Width;
            _locY = this.Location.Y;

            for (int i=0; i<numPlayerCount.Value; i++)
            {
                SubForm sf = new SubForm();
                sf.Location = new Point(_locX, _locY + (sf.Height * i));

                sf.Show();
            }
        }
    }
}
