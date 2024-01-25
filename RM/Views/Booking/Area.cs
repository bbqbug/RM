using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views.Booking
{
    public partial class Area : UserControl
    {
        private string time;
        public Area()
        {
            InitializeComponent();
        }

        public string Time 
        {
            get => time; 
            set { time = value; lb_timeofarea.Text = value; }
        }
    }
}
