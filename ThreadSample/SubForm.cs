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
    public partial class SubForm : Form
    {
        string _strPlayerName = string.Empty;

        public SubForm()
        {
            InitializeComponent();
        }

        public SubForm(string strPlayerName)
        {
            InitializeComponent();

            lblPlayerName.Text = _strPlayerName = strPlayerName;
        }
    }
}
