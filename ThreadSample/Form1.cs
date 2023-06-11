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
        private enum enumPlayer
        {
            아이린,
            슬기,
            웬디,
            조이,
            예리,
        }

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
                SubForm sf = new SubForm(((enumPlayer)i).ToString());
                sf.Location = new Point(_locX, _locY + (sf.Height * i));
                sf.eventDeleMessage += Sf_eventDeleMessage;
                sf.Show();

                sf.ThreadOn();
            }
        }

        private int Sf_eventDeleMessage(object sender, string strResult)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    SubForm subForm = sender as SubForm;

                    lboxResult.Items.Add(string.Format("Player : {0}, Text : {1}", subForm.StrPlayerName, strResult));
                }));
            }

            
            return 0;
        }
    }
}
