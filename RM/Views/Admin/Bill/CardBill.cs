using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views.Admin.Bill
{
    public partial class CardBill : UserControl
    {
        private string id;
        private string fullname;
        private string date;
        private string time;
        private string phone;
        private string status;
        private string tttt;
        public CardBill()
        {
            InitializeComponent();
        }

        [Category("CardBill")]
        public string Id 
        { 
            get => id;
            set { id = value; lb_stt.Text = id; }
        }

        [Category("CardBill")]
        public string Fullname 
        { 
            get => fullname;
            set { fullname = value; lb_name.Text = fullname; }
        }

        [Category("CardBill")]
        public string Date 
        { 
            get => date;
            set { date = value; lb_date.Text = date; }
        }

        [Category("CardBill")]
        public string Time 
        { 
            get => time;
            set { time = value; lb_time.Text = time; }
        }

        [Category("CardBill")]
        public string Status 
        { 
            get => status;
            set { status = value; lb_status.Text = status; }
        }

        [Category("CardBill")]
        public string Phone 
        { 
            get => phone;
            set { phone = value; lb_phone.Text = phone; }
        }

        [Category("CardBill")]
        public string Tttt 
        { 
            get => tttt;
            set { tttt = value; lb_tttt.Text = value; }
        }

        public CardBill(DataRow row)
        {
            InitializeComponent();
            string idd = row["PDT_Ma"].ToString();
            string fullnamee = row["KH_Ho"].ToString() + " " + row["KH_Ten"].ToString();
            string sdtt = row["KH_SDT"].ToString();
            string datee = DateTime.Parse(row["PDT_ThoiGian"].ToString()).ToString("dd-MM-yyyy");
            string timee = DateTime.Parse(row["PDT_ThoiGian"].ToString()).ToString("HH:mm");
            string statuss = "";
            string ttttoan = "";
            switch (row["PDT_TrangThai"].ToString())
            {
                case "0":
                    {
                        statuss = "Đã hủy";
                        this.BackColor = Color.FromArgb(229, 57, 53);
                    }
                    break;
                case "1":
                    {
                        statuss = "Chưa diễn ra";
                        this.BackColor = Color.Gray;
                    }
                    break;

                case "2":
                    {
                        statuss = "Đang diễn ra";
                        this.BackColor = Color.FromArgb(254, 168, 55);
                    }
                    break;
                case "3":
                    {
                        statuss = "Đã diễn ra";
                        this.BackColor = Color.FromArgb(102, 187, 106);
                    }
                    break;

            }

            if (row["PDT_TrangThaiThanhToan"].ToString() == "1")
                ttttoan = "Đã cọc";
            else
                ttttoan = "Đã thanh toán";

            //property
            this.Id = idd;
            this.Fullname = fullnamee;
            this.Phone = sdtt;
            this.Date = datee;
            this.Time = timee;
            this.Status = statuss;
            this.Tttt = ttttoan;
            this.Tag = idd;

        }

    }
}
