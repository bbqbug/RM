using RM.Views.Admin.Staff;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DAL
{
    public class StaffPresenter
    {
        private static StaffPresenter instance;

        public static StaffPresenter Instance 
        {
            get
            {
                if(instance == null)
                    instance = new StaffPresenter();
                return instance;
            }
            private set => instance = value; 
        }

        private StaffPresenter() { }
        public List<CardStaff> GetListStaff(string keysearch = null) 
        {
            List<CardStaff> listcard = new List<CardStaff>();
            if(keysearch != null)
            {
                string sql = "select * from NhanVien, BoPhan, ChucVu where NhanVien.NV_MaBP = BoPhan.BP_Ma  and NhanVien.NV_MaCV = ChucVu.CV_Ma  and CONCAT(NhanVien.NV_Ho,' ', NhanVien.NV_Ten) like N'%"+keysearch+"%'";

                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);


                foreach (DataRow row in data.Rows)
                {
                    CardStaff staff = new CardStaff();

                    staff.Manv = row["NV_Ma"].ToString();
                    staff.Fullname = row["NV_Ho"].ToString() + " "+ row["NV_Ten"].ToString();
                    staff.Bophan = row["BP_Ten"].ToString();
                    staff.Chucvu = row["CV_Ten"].ToString();

                    listcard.Add(staff);
                }

            }
            else
            {
                string sql = "Execute GetListStaff";

                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);


                foreach(DataRow row in data.Rows)
                {
                    CardStaff staff = new CardStaff();

                    staff.Manv = row["NV_Ma"].ToString();
                    staff.Fullname = row["NV_Ho"].ToString() + " " + row["NV_Ten"].ToString();
                    staff.Bophan = row["BP_Ten"].ToString();
                    staff.Chucvu = row["CV_Ten"].ToString();

                    listcard.Add(staff);
                }
            }


            return listcard;
        }
    }
}
