using RM.Views.Admin.Bill;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace RM.DAL
{
    public class BillPresenter
    {
        private static BillPresenter instance;

        public static BillPresenter Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillPresenter();
                return instance;
            }
            private set => instance = value;
        }

        private BillPresenter() { }


        public List<CardBill> GetListCardBill(int status)
        {
            List<CardBill> list = new List<CardBill>();
            Thread.Sleep(50);

            DataTable data = DataProvider.Instance.ExcuteQuerry("Select * from PhieuDatTiec, KhachHang where PhieuDatTiec.PDT_TrangThai = "+status);

            foreach (DataRow row in data.Rows)
            {
                CardBill item = new CardBill(row);
                list.Add(item);
            }

            return list;
        }


        public List<CardBill> GetListCardBill(string _timestart, string _timeend, string keysearch = null)
        {
            List<CardBill> list = new List<CardBill>();
            Thread.Sleep(50);
            if (keysearch != null )
            {
                string sql = "Select * from PhieuDatTiec, KhachHang where PhieuDatTiec.PDT_SDTKH = KhachHang.KH_SDT and PhieuDatTiec.PDT_ThoiGian > '" + _timestart + "' and PhieuDatTiec.PDT_ThoiGian < '" + _timeend+"' and KhachHang.KH_SDT like '%"+keysearch+"%'";
                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

                foreach (DataRow row in data.Rows)
                {
                    CardBill item = new CardBill(row);
                    list.Add(item);
                }

            }
            else
            {
                string sql = "Select * from PhieuDatTiec, KhachHang where PhieuDatTiec.PDT_SDTKH = KhachHang.KH_SDT and PhieuDatTiec.PDT_ThoiGian > '" + _timestart + "' and PhieuDatTiec.PDT_ThoiGian < '" + _timeend+"'";
                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

                foreach (DataRow row in data.Rows)
                {
                    CardBill item = new CardBill(row);
                    list.Add(item);
                }

            }


            return list;
        }

        public List<CardBill> GetListCardBill(string keysearch = null)
        {
            List<CardBill> list = new List<CardBill>();
            Thread.Sleep(50);

            if (keysearch != null)
            {
                string sql = "Select * from PhieuDatTiec, KhachHang where PhieuDatTiec.PDT_SDTKH = KhachHang.KH_SDT and KhachHang.KH_SDT like '%" + keysearch + "%'";

                //MessageBox.Show(sql);
                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

                foreach (DataRow row in data.Rows)
                {
                    CardBill item = new CardBill(row);
                    list.Add(item);
                }

            }
            else
            {

                string sql = "Execute GetListBill";
                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

                //MessageBox.Show(data.Rows.Count.ToString());

                foreach (DataRow row in data.Rows)
                {

                    CardBill item = new CardBill(row);
                    list.Add(item);

                }

            }

            return list;

        }      
    }
}
