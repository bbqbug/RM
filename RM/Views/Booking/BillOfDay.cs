using RM.DAL;
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
    public partial class BillOfDay : UserControl
    {
        private string id;
        private string fullname;
        private string date;
        private string time;
        private string status;
        private string tttt;
        private string phone;

        [Category("BillOdDay")]
        public string Fullname 
        { 
            get => fullname;
            set { fullname = value; lb_fullname.Text = value; }
        }

        [Category("BillOdDay")]
        public string Id 
        { 
            get => id; 
            set { id = value; lb_id.Text = value; }
        }

        [Category("BillOdDay")]
        public string Date 
        { 
            get => date;
            set { date = value; lb_date.Text = value; } 
        }

        [Category("BillOdDay")]
        public string Time 
        { 
            get => time;
            set { time = value; lb_time.Text = value; } 
        }

        [Category("BillOdDay")]
        public string Status 
        { 
            get => status;
            set 
            {
                status = value;
                lb_status.Text = value;
                switch (value)
                {
                    case "Chưa diễn ra":
                        {
                            this.BackColor = Color.Gray;
                        }
                        break;

                    case "Đã diễn ra":
                        {
                            this.BackColor = Color.FromArgb(102, 187, 106);
                                
                        }
                        break;

                    case "Đang diễn ra":
                        {

                            this.BackColor = Color.FromArgb(254, 168, 55);
                        }
                        break;

                    case "Đã hủy":
                        { 
                            this.BackColor = Color.FromArgb(229, 57, 53);

                        }
                        break;
                }
            } 
        }


        [Category("BillOdDay")]
        public string Tttt
        {
            get => tttt;
            set { tttt = value; lb_tttt.Text = value; }
        }

        [Category("BillOdDay")]
        public string Phone
        {
            get => phone;
            set { phone = value; lb_phone.Text = value; }
        }

        public BillOfDay()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
