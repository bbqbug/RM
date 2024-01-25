using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views.Admin.Staff
{
    public partial class CardStaff : UserControl
    {
        private string manv;
        private string fullname;
        private string bophan;
        private string chucvu;
        public CardStaff()
        {
            InitializeComponent();
        }

        [Category("CardStaff")]
        public string Manv 
        { 
            get => manv;
            set { manv = value; lb_manv.Text = value; }
        }

        [Category("CardStaff")]
        public string Fullname 
        { 
            get => fullname; 
            set { fullname = value; lb_hoten.Text = value; }
        }

        [Category("CardStaff")]
        public string Bophan 
        { 
            get => bophan; 
            set { bophan = value; lb_bophan.Text = value; }
        }

        [Category("CardStaff")]
        public string Chucvu 
        { 
            get => chucvu; 
            set { chucvu = value; lb_chucvu.Text = value; }
        }

        public static implicit operator CardStaff(List<CardStaff> v)
        {
            throw new NotImplementedException();
        }
    }
}
