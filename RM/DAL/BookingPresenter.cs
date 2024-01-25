using RM.Views.Booking;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RM.DAL
{
    public class BookingPresenter
    {
        private static BookingPresenter instance;

        public static BookingPresenter Instance 
        {
            get 
            {
                if(instance == null)
                    instance = new BookingPresenter();
                return instance;
            } 
            private set => instance = value;
        }

        private BookingPresenter() { }



        public List<Area> GetAreaOfDay( string id, string datetime)
        {
            
            List<Area> listarea = new List<Area>();

            string sql = "select * from KhuVuc , KhuVucTiec, PhieuDatTiec where KhuVuc.KV_Ma = KhuVucTiec.KVT_MaKV and KhuVucTiec.KVT_MaPDT = PhieuDatTiec.PDT_Ma and PhieuDatTiec.PDT_ThoiGian > '" + datetime + "' and PhieuDatTiec.PDT_ThoiGian < '" + datetime + " 23:59:00' and KhuVuc.KV_Ma = '" + id + "'";

            DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

            if(data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    Area area = new Area();
                    //MessageBox.Show(row["PDT_ThoiGian"].ToString());
                    area.Time = DateTime.Parse(row["PDT_ThoiGian"].ToString()).ToString("HH:mm");

                    if (row["PDT_TrangThai"].ToString() == "0")
                        area.ForeColor = Color.FromArgb(229, 57, 53);
                    listarea.Add(area);
                }
            }

            //MessageBox.Show(listarea.Count.ToString());

            return listarea;
        }

        public List<BillOfDay> GetBillOfDay(string time)
        {

            List<BillOfDay> list = new List<BillOfDay>();

            string sql = "Select * from KhachHang, PhieuDatTiec where KhachHang.KH_SDT = PhieuDatTiec.PDT_SDTKH and PhieuDatTiec.PDT_ThoiGian > '"+time+ "' and PhieuDatTiec.PDT_ThoiGian < '"+time+" 23:59:59'";

            DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

            foreach(DataRow row in data.Rows)
            {
                BillOfDay day = new BillOfDay();
                day.Id = row["PDT_Ma"].ToString();
                day.Fullname = row["KH_Ho"].ToString() + " " + row["KH_Ten"].ToString();
                day.Phone = row["KH_SDT"].ToString();
                day.Date = DateTime.Parse(row["PDT_ThoiGian"].ToString()).ToString("dd-MM-yyyy");
                day.Time = DateTime.Parse(row["PDT_ThoiGian"].ToString()).ToString("HH:mm");
                string status = "";
                switch(row["PDT_TrangThai"].ToString())
                {
                    case "0":
                        {
                            status = "Đã hủy";
                        }
                        break;
                    case "1":
                        {
                            status = "Chưa diễn ra";
                        }
                        break;
                    case "2":
                        {
                            status = "Đang diễn ra";
                        }
                        break;
                    case "3":
                        {
                            status = "Đã diễn ra";
                        }
                        break;
                }

                day.Status = status;

                string tttt = "";
                switch (row["PDT_TrangThaiThanhToan"].ToString())
                {
                    case "1":
                        {
                            tttt = "Đã cọc";
                        }
                        break;
                    case "2":
                        {
                            tttt = "Đã thanh toán";
                        }
                        break;
                }

                day.Tttt = tttt;
                //day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                list.Add(day);
            }

            return list;

        }
    }
}
