using RM.DAL;
using RM.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views.Admin.Staff
{
    public partial class fStaff : Form
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + "\\Image\\";

        private CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public fStaff()
        {
            InitializeComponent();
            load();
        }

        void load(string keysearch = null)
        {
            //
            lb_srcimg.Tag = null;

            if (keysearch != null)
            {
                flowLayoutPanel1.Controls.Clear();
                Thread.Sleep(50);
                
                List<CardStaff> list = StaffPresenter.Instance.GetListStaff(keysearch);
                foreach (CardStaff staff in list)
                {

                    //Method
                    staff.Click += (object sender, EventArgs e) =>
                    {
                        CardStaff target = sender as CardStaff;

                        grb_salary.Visible = true;
                        btn_save.Visible = false;
                        btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;


                        DataTable thisstaff = DataProvider.Instance.ExcuteQuerry("Execute GetStaffByID @id", new object[] { staff.Manv });
                        txt_manv.Text = thisstaff.Rows[0]["NV_Ma"].ToString();
                        datestart.Value = DateTime.Parse(thisstaff.Rows[0]["NV_NgayLamViec"].ToString());
                        txt_password.Text = thisstaff.Rows[0]["NV_MatKhau"].ToString();
                        cbb_bophan.Text = thisstaff.Rows[0]["BP_Ten"].ToString();
                        cbb_chucvu.Text = thisstaff.Rows[0]["CV_Ten"].ToString();

                        txt_ho.Text = thisstaff.Rows[0]["NV_Ho"].ToString();
                        txt_ten.Text = thisstaff.Rows[0]["NV_Ten"].ToString();
                        cbb_gioitinh.Text = thisstaff.Rows[0]["NV_Gioitinh"].ToString();
                        birthday.Value = DateTime.Parse(thisstaff.Rows[0]["NV_Ngaysinh"].ToString());
                        txt_cccd.Text = thisstaff.Rows[0]["NV_CCCD"].ToString();
                        txt_sdt.Text = thisstaff.Rows[0]["NV_SDT"].ToString();
                        txt_cccd.Text = thisstaff.Rows[0]["NV_CCCD"].ToString();
                        lb_luong.Text = thisstaff.Rows[0]["BP_Luong"].ToString();
                        lb_heso.Text = thisstaff.Rows[0]["CV_Heso"].ToString();

                        img_avt.Image = thisstaff.Rows[0]["NV_HinhAnh"].ToString() == "" ? new Bitmap(Path.Combine(path, "user_default.png")) : new Bitmap(Path.Combine(path, thisstaff.Rows[0]["NV_HinhAnh"].ToString()));

                        lb_srcimg.Tag = null;

                        int year = dateTimePicker2.Value.Year;
                        int month = dateTimePicker2.Value.Month;

                        DateTime timestart = new DateTime(year, month, 1);
                        DateTime timeend = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                        //MessageBox.Show(timestart.ToString("yyyy-MM-dd"), timeend.ToString("yyyy-MM-dd"));
                        DataTable sumday = DataProvider.Instance.ExcuteQuerry("Execute GetSumDay @id , @timestart , @timeend ", new object[] { target.Manv, timestart.ToString("yyyy-MM-dd"), timeend.ToString("yyyy-MM-dd") });

                        lb_sotiec.Text = sumday.Rows.Count.ToString();
                        lb_tongluong.Text = (Convert.ToDouble(lb_luong.Text) * Convert.ToDouble(lb_heso.Text) * sumday.Rows.Count).ToString();

                    };
                    //style
                    //staff.AutoSize = true;
                    staff.BackColor = Color.FromArgb(152, 190, 198);
                    staff.ForeColor = Color.FromArgb(74, 38, 171);

                    flowLayoutPanel1.Controls.Add(staff);
                }

            }
            else
            {

                List<CardStaff> list = StaffPresenter.Instance.GetListStaff();

                foreach (CardStaff staff in list)
                {

                    //set major
                    DataTable listmajor = DataProvider.Instance.ExcuteQuerry("Select BP_Ma, BP_Ten from BoPhan");
                    cbb_bophan.DataSource = listmajor;
                    cbb_bophan.DisplayMember = "BP_Ten";
                    cbb_bophan.ValueMember = "BP_Ma";
                    //set role
                    DataTable listrole = DataProvider.Instance.ExcuteQuerry("Select CV_Ma, CV_Ten from ChucVu");
                    cbb_chucvu.DataSource = listrole;
                    cbb_chucvu.DisplayMember = "CV_Ten";
                    cbb_chucvu.ValueMember = "CV_Ma";


                    //Method
                    staff.Click += (object sender, EventArgs e) =>
                    {
                        CardStaff target = sender as CardStaff;

                        grb_salary.Visible = true;
                        btn_save.Visible = false;
                        btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;

                        DataTable thisstaff = DataProvider.Instance.ExcuteQuerry("Execute GetStaffByID @id", new object[] { staff.Manv });
                        txt_manv.Text = thisstaff.Rows[0]["NV_Ma"].ToString();
                        datestart.Value = DateTime.Parse(thisstaff.Rows[0]["NV_NgayLamViec"].ToString());
                        txt_password.Text = thisstaff.Rows[0]["NV_MatKhau"].ToString();
                        cbb_bophan.Text = thisstaff.Rows[0]["BP_Ten"].ToString();
                        cbb_chucvu.Text = thisstaff.Rows[0]["CV_Ten"].ToString();

                        txt_ho.Text = thisstaff.Rows[0]["NV_Ho"].ToString();
                        txt_ten.Text = thisstaff.Rows[0]["NV_Ten"].ToString();
                        cbb_gioitinh.Text = thisstaff.Rows[0]["NV_Gioitinh"].ToString();
                        birthday.Value = DateTime.Parse(thisstaff.Rows[0]["NV_Ngaysinh"].ToString());
                        txt_cccd.Text = thisstaff.Rows[0]["NV_CCCD"].ToString();
                        txt_sdt.Text = thisstaff.Rows[0]["NV_SDT"].ToString();
                        txt_cccd.Text = thisstaff.Rows[0]["NV_CCCD"].ToString();
                        lb_luong.Text = Convert.ToInt32(thisstaff.Rows[0]["BP_Luong"]).ToString("#,###", cul.NumberFormat);
                        lb_heso.Text = thisstaff.Rows[0]["CV_Heso"].ToString();

                        img_avt.Image = thisstaff.Rows[0]["NV_HinhAnh"].ToString() == "" ? new Bitmap(Path.Combine(path, "user_default.png")) : new Bitmap(Path.Combine(path, thisstaff.Rows[0]["NV_HinhAnh"].ToString()));

                        lb_srcimg.Tag = null;



                        int year = dateTimePicker2.Value.Year;
                        int month = dateTimePicker2.Value.Month;
                        DateTime timestart = new DateTime(year, month, 1);
                        DateTime timeend = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                        //MessageBox.Show(timestart.ToString("yyyy-MM-dd"), timeend.ToString("yyyy-MM-dd"));
                        DataTable sumday = DataProvider.Instance.ExcuteQuerry("Execute GetSumDay @id , @timestart , @timeend ", new object[] { target.Manv, timestart.ToString("yyyy-MM-dd"), timeend.ToString("yyyy-MM-dd") });

                        lb_sotiec.Text = sumday.Rows.Count.ToString();
                        lb_tongluong.Text = (Convert.ToDouble(lb_luong.Text) * Convert.ToDouble(lb_heso.Text) * sumday.Rows.Count).ToString("#,###", cul.NumberFormat);

                    };
                    //style
                    //staff.AutoSize = true;
                    staff.BackColor = Color.FromArgb(152, 190, 198);
                    staff.ForeColor = Color.FromArgb(74, 38, 171);

                    flowLayoutPanel1.Controls.Add(staff);
                }
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (btn_save.Visible == true)
            {
                clearinfor();
                btn_save.Visible = false;
                btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;

                btn_loadimg.Enabled = false;

            }
            else
            {
                img_avt.Image = new Bitmap(path + "user_default.png");
                btn_save.Visible = true;
                btn_add.IconChar = FontAwesome.Sharp.IconChar.Xmark;
                grb_salary.Visible = false;
                btn_loadimg.Enabled = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;

                clearinfor();
                txt_manv.Text = (Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("Select Max(NV_Ma) as MaxNV from NhanVien").Rows[0]["MaxNV"]) + 1).ToString();

            }
        }


        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            load(txt_search.Text);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int year = dateTimePicker2.Value.Year;
            int month = dateTimePicker2.Value.Month;
            DateTime timestart = new DateTime(year, month, 1);
            DateTime timeend = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            //MessageBox.Show(timestart.ToString("yyyy-MM-dd"), timeend.ToString("yyyy-MM-dd"));

            DataTable sumday = DataProvider.Instance.ExcuteQuerry("Execute GetSumDay @id , @timestart , @timeend ", new object[] { txt_manv.Text, timestart, timeend });

            lb_sotiec.Text = sumday.Rows.Count.ToString();
            lb_tongluong.Text = (Convert.ToDouble(lb_luong.Text) * Convert.ToDouble(lb_heso.Text) * sumday.Rows.Count).ToString();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ho = txt_ho.Text;
            string ten = txt_ten.Text;
            int bophan = Convert.ToInt32(cbb_bophan.SelectedValue);
            int chucvu = Convert.ToInt32(cbb_chucvu.SelectedValue);
            string matkhau = txt_password.Text == "" ? "" : txt_password.Text;
            string birthdayadd = birthday.Value.ToString("yyyy-MM-dd");
            string sdt = txt_sdt.Text;
            string gioitinh = cbb_gioitinh.Text;
            string cccd = txt_cccd.Text;
            int add = 0;

            string img = lb_srcimg.Tag == null ? "" : lb_srcimg.Tag.ToString();
            //MessageBox.Show((matkhau == null).ToString());
            string sql = "Execute AddStaff @ho , @ten , @ngaysinh , @gioitinh , @cccd , @nlv , @matkhau , @sdt , @bp , @cv , @anh";
            //if (matkhau == null)
            add = DataProvider.Instance.ExcuteNonQuerry(sql, new object[] { ho, ten, birthdayadd, gioitinh, cccd, DateTime.Now.ToString("yyyy-MM-dd"), matkhau, sdt, bophan, chucvu, img });
            //else 
            //add = DataProvider.Instance.ExcuteNonQuerry(sql, new object[] { ho, ten, birthdayadd, gioitinh, cccd, DateTime.Now.ToString("yyyy-MM-dd"), matkhau , sdt, bophan, chucvu });
            if (add > 0)
            {
                File.Copy(lb_srcimg.Text, Path.Combine(path, lb_srcimg.Tag.ToString()));

                MessageBox.Show("Thêm Thành Công");
                flowLayoutPanel1.Controls.Clear();
                load();
                clearinfor();
            }

        }

        private void clearinfor()
        {
            txt_manv.Text = "";
            txt_ho.Text = "";
            txt_ten.Text = "";
            txt_password.Text = "";
            txt_sdt.Text = "";
            txt_cccd.Text = "";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        { 
            int manv = Convert.ToInt32(txt_manv.Text);
            string ho = txt_ho.Text;
            string ten = txt_ten.Text;
            int bophan = Convert.ToInt32(cbb_bophan.SelectedValue);
            int chucvu = Convert.ToInt32(cbb_chucvu.SelectedValue);
            string matkhau = txt_password.Text == "" ? "" : txt_password.Text;
            string birthdayupdate = birthday.Value.ToString("yyyy-MM-dd");
            string sdt = txt_sdt.Text;
            string gioitinh = cbb_gioitinh.Text;
            string cccd = txt_cccd.Text;
            string img = lb_srcimg.Tag == null ? "" : lb_srcimg.Tag.ToString();
            int update = 0;

            if(img == "")
            {
                string sql = "UPDATE NhanVien Set NV_Ho = @ho , NV_Ten = @ten , NV_MaBP = @bp , NV_MaCV = @cv , NV_MatKhau = @matkhau , NV_NgaySinh = @ngaysinh , NV_SDT = @sdt , NV_Gioitinh = @gioitinh , NV_CCCD = @cccd   where NV_Ma = @manv";

                update = DataProvider.Instance.ExcuteNonQuerry(sql, new object[] { ho, ten, bophan, chucvu, matkhau, birthdayupdate, sdt, gioitinh, cccd, manv });
            }
            else
            {

                string sql = "UPDATE NhanVien Set NV_Ho = @ho , NV_Ten = @ten , NV_MaBP = @bp , NV_MaCV = @cv , NV_MatKhau = @matkhau , NV_NgaySinh = @ngaysinh , NV_SDT = @sdt , NV_Gioitinh = @gioitinh , NV_CCCD = @cccd , NV_HinhAnh = @anh where NV_Ma = @manv";

                update = DataProvider.Instance.ExcuteNonQuerry(sql, new object[] { ho, ten, bophan, chucvu, matkhau, birthdayupdate, sdt, gioitinh, cccd, img, manv });
                File.Copy(lb_srcimg.Text, Path.Combine(path, lb_srcimg.Tag.ToString()));


            }

            if (update > 0)
            {
                
                MessageBox.Show("Sửa Thành Công");
                flowLayoutPanel1.Controls.Clear();
                load();
                clearinfor();
            }

        }

    private void button3_Click(object sender, EventArgs e)
    {
            int manv = Convert.ToInt32(txt_manv.Text);

            string sqlptt = "Delete from PhuTrachTiec where PTT_MaNV = " + manv;
            DataProvider.Instance.ExcuteNonQuerry(sqlptt);

            string sql = "Delete From NhanVien Where NV_Ma = " + manv;
            int dlt = 0;
            dlt = DataProvider.Instance.ExcuteNonQuerry(sql);
            if(dlt > 0)
            {
                MessageBox.Show("Xóa Thành Công");
                flowLayoutPanel1.Controls.Clear();
                load();
                clearinfor();
            }
    }

        private void btn_loadimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                img_avt.Image = new Bitmap(open.FileName);

                lb_srcimg.Text = open.FileName;
                lb_srcimg.Tag = Path.GetFileName(open.FileName);

                lb_srcimg.Visible = true;

            }
        }

        private void btn_printllv_Click(object sender, EventArgs e)
        {
            DateTime daystartt = daystart.Value;
            DateTime dayendd = dayend.Value;

            if(daystartt < dayendd)
            {
                ExportExcelFile.Instance.ScheduleWork(daystartt, dayendd);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu lớn hơn ngày kết thúc");
            }

            
        }

        private void fStaff_Load(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DateTime daystartt = daystart.Value;
            DateTime dayendd = dayend.Value;

            if (daystartt < dayendd)
            {
                ExportExcelFile.Instance.MakeSalary(daystartt, dayendd);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu lớn hơn ngày kết thúc");
            }
        }

        private void ktraso(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
