using FontAwesome.Sharp;
using RM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views.Admin.Bill
{
    public partial class fBill : Form
    {
        private int countAddArea = 0;
        private int countAddMenu = 0;

        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public fBill()
        {
            InitializeComponent();
            Load();
        }

        void Load(int status)
        {
            flowLayoutPanel1.Controls.Clear();
            List<CardBill> list = BillPresenter.Instance.GetListCardBill(status);
            foreach (CardBill bill in list)
            {
                bill.Click += (object sender, EventArgs e) =>
                {

                    CardBill cardBill = sender as CardBill;
                    clickBill(cardBill);

                };

                flowLayoutPanel1.Controls.Add(bill);
            }

        }


        void Load(string keysearch = null)
        {
            flowLayoutPanel1.Controls.Clear();
            


            if (keysearch != null)
            {
                List<CardBill> list = BillPresenter.Instance.GetListCardBill(keysearch);
                foreach (CardBill bill in list)
                {
                    bill.Click += (object sender, EventArgs e) =>
                    {

                        CardBill cardBill = sender as CardBill;
                        clickBill(cardBill);

                    };

                    flowLayoutPanel1.Controls.Add(bill);
                }

            }
            else
            {

                timestart.Value = DateTime.Parse(DataProvider.Instance.ExcuteQuerry("Select MIN(PDT_ThoiGian) from PhieuDatTiec").Rows[0][0].ToString());
                timeend.Value = DateTime.Parse(DataProvider.Instance.ExcuteQuerry("Select MAX(PDT_ThoiGian) from PhieuDatTiec").Rows[0][0].ToString());

                loaddoanhthu(timestart.Value.ToString("yyyy-MM-dd"), timeend.Value.ToString("yyyy-MM-dd"));
                lb_total.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec").Rows[0][0].ToString();
                lb_done.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec where PDT_TrangThai = 3").Rows[0][0].ToString();
                lb_cancle.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec where PDT_TrangThai = 0").Rows[0][0].ToString();
                lb_no_done.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec where PDT_TrangThai = 1").Rows[0][0].ToString();
                lb_dangdr.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec where PDT_TrangThai = 2").Rows[0][0].ToString();
                //dataGridView1.DataSource = DataProvider.Instance.ExcuteQuerry("Select * from PhieuDatTiec, KhachHang where PhieuDatTiec.PDT_SDTKH = KhachHang.KH_SDT");

                List<CardBill> list = BillPresenter.Instance.GetListCardBill();

                foreach (CardBill bill in list)
                {
                    bill.Click += (object sender, EventArgs e) =>
                    {

                        CardBill cardBill = sender as CardBill;
                        clickBill(cardBill);

                    };

                    flowLayoutPanel1.Controls.Add(bill);
                }
            }




        }

        void Load(string _timestart, string _timeend , string keysearch = null)
        {
            flowLayoutPanel1.Controls.Clear();
            loaddoanhthu(_timestart, _timeend);


            if (keysearch != null)
            {
                List<CardBill> list = BillPresenter.Instance.GetListCardBill(_timestart, _timeend, keysearch);

                foreach (CardBill bill in list)
                {
                    bill.Click += (object sender, EventArgs e) =>
                    {

                        CardBill cardBill = sender as CardBill;
                        clickBill(cardBill);

                    };

                    flowLayoutPanel1.Controls.Add(bill);
                }

            }
            else
            {

                //timestart.Value = DateTime.Parse(DataProvider.Instance.ExcuteQuerry("Select MIN(PDT_ThoiGian) from PhieuDatTiec").Rows[0][0].ToString());
                //timeend.Value = DateTime.Now;
                lb_total.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec where PDT_ThoiGian >  '"+ _timestart +"'  and PhieuDatTiec.PDT_ThoiGian <  '"+ _timeend+"'").Rows[0][0].ToString();
                lb_done.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec where PDT_TrangThai = 3 and PDT_ThoiGian >  '" + _timestart + "'  and PhieuDatTiec.PDT_ThoiGian <  '" + _timeend + "'").Rows[0][0].ToString();
                lb_cancle.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec where PDT_TrangThai = 0 and PDT_ThoiGian >  '" + _timestart + "'  and PhieuDatTiec.PDT_ThoiGian <  '" + _timeend + "'").Rows[0][0].ToString();
                lb_no_done.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec where PDT_TrangThai = 1 and PDT_ThoiGian >  '" + _timestart + "'  and PhieuDatTiec.PDT_ThoiGian <  '" + _timeend + "'").Rows[0][0].ToString();
                lb_dangdr.Text = DataProvider.Instance.ExcuteQuerry("Select Count(PDT_Ma) from PhieuDatTiec where PDT_TrangThai = 2 and PDT_ThoiGian >  '" + _timestart + "'  and PhieuDatTiec.PDT_ThoiGian <  '" + _timeend + "'").Rows[0][0].ToString();

                List<CardBill> list = BillPresenter.Instance.GetListCardBill(_timestart, _timeend);

                foreach (CardBill bill in list)
                {
                    bill.Click += (object sender, EventArgs e) =>
                    {

                        CardBill cardBill = sender as CardBill;
                        clickBill(cardBill);
                        
                    };

                    flowLayoutPanel1.Controls.Add(bill);
                }
            }



        }

        public bool checkinfor(FlowLayoutPanel menus, FlowLayoutPanel areas)
        {
            int humanofmenu = 0;
            int humanofarea = 0;
            foreach(AddMenu menu in menus.Controls.OfType<AddMenu>().ToList())
            {
                humanofmenu = humanofmenu +  (menu.Quantity*10);
            }

            foreach(AddArea area in areas.Controls.OfType<AddArea>().ToList())
            {
                humanofarea = humanofarea + area.Quantity;
            }
            //MessageBox.Show("" + humanofarea + humanofmenu);

            if (humanofarea < humanofmenu)
                return false;


            return true;
        }

        void clickBill(CardBill cardBill)
        {
            flowdetail.Controls.Clear();
            flow_area.Controls.Clear();
            IconButton btn_addmenu = new IconButton();
            btn_addmenu.Dock = System.Windows.Forms.DockStyle.Top;
            btn_addmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_addmenu.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_addmenu.IconColor = System.Drawing.Color.Black;
            btn_addmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addmenu.IconSize = 36;
            btn_addmenu.Location = new System.Drawing.Point(3, 3);
            btn_addmenu.Size = new System.Drawing.Size(130, 43);
            btn_addmenu.TabIndex = 0;
            btn_addmenu.UseVisualStyleBackColor = true;
            btn_addmenu.FlatAppearance.BorderSize = 0;
            btn_addmenu.Text = "Thực Đơn:";
            btn_addmenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_addmenu.Click += (object sender, EventArgs e) =>
            {
                addMenu();
            };

            IconButton btn_addarea = new IconButton();
            btn_addarea.Dock = System.Windows.Forms.DockStyle.Top;
            btn_addarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_addarea.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_addarea.IconColor = System.Drawing.Color.Black;
            btn_addarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addarea.IconSize = 36;
            btn_addarea.Location = new System.Drawing.Point(3, 3);
            btn_addarea.Size = new System.Drawing.Size(130, 43);
            btn_addarea.TabIndex = 0;
            btn_addarea.UseVisualStyleBackColor = true;
            btn_addarea.FlatAppearance.BorderSize = 0;
            btn_addarea.Text = "Khu Vực:";
            btn_addarea.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_addarea.Click += (object sender, EventArgs e) =>
            {
                addArea();
            };


            flowdetail.Controls.Add(btn_addmenu);
            flow_area.Controls.Add(btn_addarea);


            DataTable data = DataProvider.Instance.ExcuteQuerry("Select * from PhieuDatTiec, KhachHang where PhieuDatTiec.PDT_SDTKH = KhachHang.KH_SDT and PhieuDatTiec.PDT_Ma = " + cardBill.Tag.ToString());

            DataTable area = DataProvider.Instance.ExcuteQuerry("Select * from KhuVucTiec, KhuVuc where KhuVucTiec.KVT_MaKV = KhuVuc.KV_Ma and KhuVucTiec.KVT_MaPDT =" + cardBill.Tag.ToString());

            DataTable menudetail = DataProvider.Instance.ExcuteQuerry("Select * from ChiTietPhieuDatTiec where CTPDT_MaPDT = " + cardBill.Tag.ToString());


            lb_fullname.Text = data.Rows[0]["KH_Ho"].ToString() + " " + data.Rows[0]["KH_Ten"].ToString();
            lb_phone.Text = data.Rows[0]["KH_SDT"].ToString();
            lb_date.Text = DateTime.Parse(data.Rows[0]["PDT_ThoiGian"].ToString()).ToString("dd-MM-yyyy");
            lb_time.Text = DateTime.Parse(data.Rows[0]["PDT_ThoiGian"].ToString()).ToString("HH:mm");
            lb_tongtien.Text = Convert.ToInt32(data.Rows[0]["PDT_TongTien"]).ToString("#,###", cul.NumberFormat);
           
            panel1.Tag = data.Rows[0]["PDT_Ma"].ToString();

            if(area.Rows.Count > 0)
            {
                foreach (DataRow row in area.Rows)
                {
                    AddArea addarea = new AddArea();
                    addarea.Id = row["KV_Ma"].ToString();
                    addarea.Quantity = Convert.ToInt32(row["KV_SoLuongKhach"].ToString());
                    addarea.Dock = DockStyle.Top;
                    addarea.Tag = countAddArea;

                    IconButton btndelete = addarea.Controls.OfType<IconButton>().ToList()[0];
                    btndelete.Tag = countAddArea;

                    btndelete.Click += (object sd, EventArgs e) =>
                    {
                        deleteAddAreaClick(sd);
                    };
                    flow_area.Controls.Add(addarea);
                    countAddArea++;
                }
            }
            

            foreach (DataRow row in menudetail.Rows)
            {
                AddMenu addmenu = new AddMenu();

                if(cardBill.Status == "Đã diễn ra" || cardBill.Status == "Đang diễn ra" || cardBill.Status == "Đang hủy")
                {
                    ComboBox cbb = addmenu.Controls.OfType<ComboBox>().FirstOrDefault();
                    cbb.DataSource = DataProvider.Instance.ExcuteQuerry("Select TD_Ma , TD_Ten from ThucDon");
                    cbb.DisplayMember = "TD_Ten";
                    cbb.ValueMember = "TD_Ma";
                }
               

                addmenu.Menu = Convert.ToInt32(row["CTPDT_MaTD"].ToString());
                addmenu.Quantity = Convert.ToInt32(row["CTPDT_SoLuong"].ToString());
                addmenu.Dock = DockStyle.Top;
                addmenu.Tag = countAddMenu;
                IconButton btndelete = addmenu.Controls.OfType<IconButton>().ToList()[0];
                btndelete.Tag = countAddMenu;

                btndelete.Click += (object sd, EventArgs e) =>
                {
                    deleteMenuClick(sd);
                };


                flowdetail.Controls.Add(addmenu);

                countAddMenu++;
            }



            panel1.Visible = true;

            //foreach(AddMenu add in flowdetail.Controls.OfType<AddMenu>().ToList())
            //{
            //   MessageBox.Show(add.Menu.ToString() + add.Quantity.ToString());
            //}



            //MessageBox.Show(cardBill.Tag.ToString());

            btn_payment.Enabled = true;
            btn_cancel.Enabled = true;
            btn_update.Enabled = true;


            if (data.Rows[0]["PDT_TrangThai"].ToString() == "2" || data.Rows[0]["PDT_TrangThai"].ToString() == "3")
            {
                btn_cancel.Enabled = false;
                btn_payment.Enabled = true;
                btn_update.Enabled = false;
            } 

            if(data.Rows[0]["PDT_TrangThai"].ToString() == "0")
            {
                btn_payment.Enabled = false;
                btn_cancel.Enabled = false;
                btn_update.Enabled = false;
            }


            if(data.Rows[0]["PDT_TrangThaiThanhToan"].ToString() == "2")
                btn_payment.Enabled = false;




        }

       

        void addArea()
        {
            AddArea add = new AddArea();
            add.Tag = countAddArea;
            IconButton btn_delete = add.Controls.OfType<IconButton>().ToList()[0];

            btn_delete.Tag = countAddArea;

            btn_delete.Click += (object sd, EventArgs e) =>
            {
                deleteAddAreaClick(sd);

            };

            countAddArea++;

            flow_area.Controls.Add(add);

        }

        void deleteAddAreaClick(object sd)
        {
            IconButton btn = sd as IconButton;

            //MessageBox.Show(btn.Tag.ToString());

            foreach (AddArea areaa in flow_area.Controls.OfType<AddArea>().ToList())
            {
                if (btn.Tag.ToString() == areaa.Tag.ToString())
                {
                    flow_area.Controls.Remove(areaa);

                }
            }
        }

        void addMenu()
        {
            AddMenu add = new AddMenu();
            add.Tag = countAddMenu;

            IconButton btn = add.Controls.OfType<IconButton>().ToList()[0];

            btn.Tag = countAddMenu;

            btn.Click += (object sd, EventArgs e) =>
            {
                deleteMenuClick(sd);
            };
            
            flowdetail.Controls.Add(add);
            countAddMenu++;
        }

        void deleteMenuClick(object sd)
        {
            IconButton btn = sd as IconButton;

            foreach(AddMenu add in flowdetail.Controls.OfType<AddMenu>().ToList())
            {
                if(btn.Tag.ToString() == add.Tag.ToString())
                {
                    flowdetail.Controls.Remove(add);
                }
            }
        }

       

        private void pn_total_Click(object sender, EventArgs e)
        {
            Load();
            txt_search.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show((btn_search.Text == "Xem").ToString());
            if(btn_search.Text == "Xem") 
                Load(txt_search.Text);
            else
                Load(timestart.Value.ToString("yyyy-MM-dd"),timeend.Value.ToString("yyyy-MM-dd"),txt_search.Text);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            btn_search.Text = btn_search.Text == "Xem" ? "Hủy" : "Xem";

            

            Load(timestart.Value.ToString("yyyy-MM-dd"), timeend.Value.ToString("yyyy-MM-dd"));

        }

        private void pn_done_Click(object sender, EventArgs e)
        {
            Load(3);
            txt_search.Visible = false;
        }

        private void pn_cancel_Click(object sender, EventArgs e)
        {
            Load(0);
            txt_search.Visible = false;

        }

        private void pn_no_done_Click(object sender, EventArgs e)
        {
            Load(1);
            txt_search.Visible = false;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (checkinfor(flowdetail, flow_area))
            {
                int mapdt = Convert.ToInt32(panel1.Tag);
                string sqlDeleteKVT = "Delete from KhuVucTiec where KVT_MaPDT = " + mapdt;
                string sqlDeleteCTPDT = "Delete from ChiTietPhieuDatTiec where CTPDT_MaPDT = " + mapdt;
                string sqlDeletePTT = "Delete from PhuTrachTiec where PTT_MaPDT = @pdt and PTT_MaNV = @nv";

                DataProvider.Instance.ExcuteNonQuerry(sqlDeleteKVT);
                DataProvider.Instance.ExcuteNonQuerry(sqlDeleteCTPDT);


                string sqlGetListNVOfBill = "select nhanvien.NV_Ma from NhanVien, PhuTrachTiec, PhieuDatTiec where NhanVien.NV_Ma = phutrachtiec.PTT_MaNV and phutrachtiec.PTT_MaPDT = PhieuDatTiec.PDT_Ma and( nhanvien.NV_MaBP = 2 or NhanVien.NV_MaBP = 3) and PhieuDatTiec.PDT_Ma = " + mapdt;

                DataTable listNVOfBill = DataProvider.Instance.ExcuteQuerry(sqlGetListNVOfBill);

                foreach(DataRow row in listNVOfBill.Rows)
                {
                    DataProvider.Instance.ExcuteNonQuerry(sqlDeletePTT , new object[] {mapdt, Convert.ToInt32(row["NV_Ma"].ToString())});
                }
                //DataProvider.Instance.ExcuteNonQuerry(sqlphutrachtiec);


                int priceofmenu = 0;
                int totalprice = 0;

                double guysOfMenu = 0;

               

                foreach (AddMenu menu in flowdetail.Controls.OfType<AddMenu>().ToList())
                {
                    string sqlCTPDT = "insert into ChiTietPhieuDatTiec(CTPDT_MaPDT, CTPDT_MaTD, CTPDT_SoLuong) values( @pdt , @td , @soluong )";
                    DataProvider.Instance.ExcuteNonQuerry(sqlCTPDT, new object[] { mapdt , menu.Menu, menu.Quantity});

                    DataTable data1 = DataProvider.Instance.ExcuteQuerry("Select * from ThucDon, MonAn, ChiTietThucDon where ThucDon.TD_Ma = ChiTietThucDon.CTTD_MaTD and ChiTietThucDon.CTTD_MaMA = MonAn.MA_Ma and ThucDon.TD_Ma = " + menu.Menu);
                    
                    foreach(DataRow row in data1.Rows)
                    {
                        priceofmenu += Convert.ToInt32(row["MA_Gia"].ToString());
                    }

                    priceofmenu = priceofmenu * menu.Quantity;

                    guysOfMenu += (menu.Quantity * 10);

                    totalprice += priceofmenu;
                    priceofmenu = 0;
                }

                int x = (totalprice / 100) * 30;
                

                totalprice = totalprice + x;

                MessageBox.Show(Convert.ToInt32(Math.Round(guysOfMenu/30)).ToString() +  guysOfMenu );

                //MessageBox.Show(x + " " + totalprice);

                DataProvider.Instance.ExcuteNonQuerry("Update PhieuDatTiec Set PDT_TongTien = @tien where PDT_Ma = @id", new object[] {totalprice, mapdt});


                foreach (AddArea area in flow_area.Controls.OfType<AddArea>().ToList())
                {
                    string sqlKVT = "insert into KhuVucTiec(KVT_MaPDT, KVT_MaKV) values ( @pdt , @kv )";
                    DataProvider.Instance.ExcuteNonQuerry(sqlKVT, new object[] {mapdt, area.Id });
                }


                //them nhan vien bep phu trach tiec

                string sqlptt = "insert into PhuTrachTiec(PTT_MaNV, PTT_MaPDT) values ( @nv , @pdt )";
                string datetime = DateTime.Parse(DataProvider.Instance.ExcuteQuerry("Select PDT_ThoiGian from PhieuDatTiec where PDT_Ma = " + mapdt).Rows[0][0].ToString()).ToString("yyyy-MM-dd HH:mm");
                MessageBox.Show(datetime);
                //1ql
                DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { 9, mapdt });
                //1/100 to truong bep
                DataTable listttbep = DataProvider.Instance.ExcuteQuerry("Execute getNV @datetimes , @bp , @cv", new object[] { datetime, 2, 2 });
                //MessageBox.Show("To Truong Bep " +listtt.Rows.Count.ToString());
                List<int> randomttbep = Random(Convert.ToInt32(Math.Round(guysOfMenu / 100)), listttbep.Rows.Count);

                foreach (int i in randomttbep)
                {
                    //MessageBox.Show(listtt.Rows[i]["NV_Ma"].ToString());
                    DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { Convert.ToInt32(listttbep.Rows[i]["NV_Ma"].ToString()), mapdt });
                }


                //nhanvien 1/50
                DataTable listnvbep = DataProvider.Instance.ExcuteQuerry("Execute getNV @datetimes , @bp , @cv", new object[] { datetime, 2, 3 });
                //MessageBox.Show("Nhan Vien Bep "+listnv.Rows.Count.ToString());
                List<int> listrandomnvbep = Random(Convert.ToInt32(Math.Round(guysOfMenu / 50)), listnvbep.Rows.Count);



                foreach (int i in listrandomnvbep)
                {
                    //MessageBox.Show(listnv.Rows[i]["NV_Ma"].ToString());
                    DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { Convert.ToInt32(listnvbep.Rows[i]["NV_Ma"].ToString()), mapdt });
                }






                //them nhan vien phuc vu cho tiec
                //1ql
                DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { 37, mapdt });
                //1totruong/100
                DataTable listttpv = DataProvider.Instance.ExcuteQuerry("Execute getNV @datetimes , @bp , @cv", new object[] { datetime, 3, 2 });
                List<int> randomttpv = Random(Convert.ToInt32(Math.Round(guysOfMenu / 100)), listttpv.Rows.Count);
                foreach (int i in randomttpv)
                {
                    //MessageBox.Show(listttpv.Rows[i]["NV_Ma"].ToString());
                    DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { Convert.ToInt32(listttpv.Rows[i]["NV_Ma"].ToString()), mapdt });
                }
                //1nv/30khach
                DataTable listnvpv = DataProvider.Instance.ExcuteQuerry("Execute getNV @datetimes , @bp , @cv", new object[] { datetime, 3, 3 });
                List<int> listrandomnvpv = Random(Convert.ToInt32(Math.Round(guysOfMenu / 30)), listnvpv.Rows.Count);

                foreach (int i in listrandomnvpv)
                {
                    //MessageBox.Show(listnvpv.Rows[i]["NV_Ma"].ToString());
                    DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { Convert.ToInt32(listnvpv.Rows[i]["NV_Ma"].ToString()), mapdt });
                }





                MessageBox.Show("Sửa Thành Công!!");

                Load();
                

            }
            else
            {
                MessageBox.Show("Vui Lòng Thêm Chi Tiết");
            }
               
        }

        private List<int> Random(int qtt, int range)
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < qtt; i++)
            {
                int z = random.Next(0, range);
                //MessageBox.Show(z.ToString());

                if (list.Contains(z))
                    i--;
                else
                    list.Add(z);

            }
            return list;
        }

            //private void btn_delete_Click(object sender, EventArgs e)
            //{
            //    string sql = "Delete from KhuVucTiec where KVT_MaPDT = " + Convert.ToInt32(panel1.Tag);
            //    string sql1 = "Delete from ChiTietPhieuDatTiec where CTPDT_MaPDT = " + Convert.ToInt32(panel1.Tag);
            //    string sql2 = "Delete from PhieuDatTiec where PDT_Ma = " + Convert.ToInt32(panel1.Tag);

            //    int delete1 =DataProvider.Instance.ExcuteNonQuerry(sql);
            //    int delete2 = DataProvider.Instance.ExcuteNonQuerry(sql1);
            //    int delete3 = DataProvider.Instance.ExcuteNonQuerry(sql2);

            //    if(delete1 > 0 && delete2 > 0 && delete3 > 0)
            //    {
            //        MessageBox.Show("Xóa Thành Công!!!");
            //        Load();
            //        clear();
            //    }



            //}

            void clear()
        {
            lb_fullname.Text = string.Empty;
            lb_phone.Text = string.Empty;
            lb_date.Text = string.Empty;
            lb_time.Text = string.Empty;
            flowdetail.Controls.Clear();
            flow_area.Controls.Clear();
            panel1.Tag = null;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int mpdt = Convert.ToInt32(panel1.Tag.ToString());

            string sqlpdt = "Select * from PhieuDatTiec, KhachHang where PhieuDatTiec.PDT_SDTKH = KhachHang.KH_SDT and PhieuDatTiec.PDT_Ma = " + mpdt;
            string sqlctpdt = "Select * from PhieuDatTiec, ChiTietPhieuDatTiec, ThucDon where PhieuDatTiec.PDT_Ma = ChiTietPhieuDatTiec.CTPDT_MaPDT and ChiTietPhieuDatTiec.CTPDT_MaTD = ThucDon.TD_Ma and PhieuDatTiec.PDT_Ma = " + mpdt;
            string sqlkvt = "Select * from PhieuDatTiec, KhuVucTiec, KhuVuc where PhieuDatTiec.PDT_Ma = KhuVucTiec.KVT_MaPDT and KhuVuc.KV_Ma = KhuVucTiec.KVT_MaKV and PhieuDatTiec.PDT_Ma = " + mpdt;
            string sqlnhanvienlap = "Select * from PhieuDatTiec, PhuTrachTiec , NhanVien where PhieuDatTiec.PDT_Ma = PhuTrachTiec.PTT_MaPDT and PhuTrachTiec.PTT_MaNV = NhanVien.NV_Ma and (NhanVien.NV_MaBP = 1 or NhanVien.NV_MaBP = 4) and PhieuDatTiec.PDT_Ma = " + mpdt;

            



            int totalpriceofpdt = 0;

            DataTable pdt = DataProvider.Instance.ExcuteQuerry(sqlpdt);
            DataTable ctpdt = DataProvider.Instance.ExcuteQuerry(sqlctpdt);
            DataTable kvt = DataProvider.Instance.ExcuteQuerry(sqlkvt);
            DataTable nhanvienlap = DataProvider.Instance.ExcuteQuerry(sqlnhanvienlap);

            //MessageBox.Show(" " + pdt.Rows.Count + " " + ctpdt.Rows.Count + " " + kvt.Rows.Count + " " + nhanvienlap.Rows.Count);

            //MessageBox.Show(nhanvienlap.Rows[0]["NV_Ho"].ToString() + " " + nhanvienlap.Rows[0]["NV_Ten"].ToString());

            e.Graphics.DrawString("Restaurant Management System", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(175, 50));

            e.Graphics.DrawString("Phiếu Đặt Tiệc", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(295, 100));

            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(285, 140));

            e.Graphics.DrawString("Nhân Viên Lập: " + nhanvienlap.Rows[0]["NV_Ho"].ToString() + " " + nhanvienlap.Rows[0]["NV_Ten"].ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(240, 160));

            e.Graphics.DrawString("Họ & Tên Khách Hàng: " + pdt.Rows[0]["KH_Ho"].ToString() + " " + pdt.Rows[0]["KH_Ten"].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 220));
            e.Graphics.DrawString("Số Điện Thoại Khách Hàng: " +pdt.Rows[0]["KH_SDT"].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 265));
            e.Graphics.DrawString("Ngày: " + DateTime.Parse(pdt.Rows[0]["PDT_ThoiGian"].ToString()).ToString("dd/MM/yyyy"), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 310));
            e.Graphics.DrawString("Giờ: " + DateTime.Parse(pdt.Rows[0]["PDT_ThoiGian"].ToString()).ToString("HH:mm"), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 355));


            e.Graphics.DrawString("---------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 370));

            e.Graphics.DrawString("Chi Tiết Khu Vực:", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString("Mã Khu Vực", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 425));
            e.Graphics.DrawString("Tên Khu Vực", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(175, 425));
            e.Graphics.DrawString("Số Chỗ Ngồi", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 425));
            //e.Graphics.DrawString("---------------------------------------------------------------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(50, 435));

            int positionY = 400;

            // loop
            foreach(DataRow row in kvt.Rows)
            {
                positionY += 50;
                e.Graphics.DrawString(row["KV_Ma"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, positionY));
                e.Graphics.DrawString(row["KV_Ten"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(175, positionY));
                e.Graphics.DrawString(row["KV_SoLuongKhach"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, positionY));
            }

            positionY += 10;
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, positionY));

            positionY += 30;
            e.Graphics.DrawString("Chi Tiết Thực Đơn: ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, positionY));

            positionY += 25;
            e.Graphics.DrawString("Mã Thực Đơn", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, positionY));
            e.Graphics.DrawString("Tên Thực Đơn", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(175, positionY));
            e.Graphics.DrawString("Đơn Giá", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, positionY));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(425, positionY));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, positionY));

            string sqltotalpricemenu = "Select SUM(MonAn.MA_Gia) from MonAn, ThucDon , ChiTietThucDon where ThucDon.TD_Ma = ChiTietThucDon.CTTD_MaTD and ChiTietThucDon.CTTD_MaMA = MonAn.MA_Ma and ThucDon.TD_Ma = @matd";
            foreach(DataRow row in ctpdt.Rows)
            {
                positionY += 50;
                e.Graphics.DrawString(row["TD_Ma"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, positionY));
                e.Graphics.DrawString(row["TD_Ten"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(175, positionY));

                ////tinh tong tien thuc don
                int matd = Convert.ToInt32(row["TD_Ma"].ToString());
                int priveofmenu = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry(sqltotalpricemenu, new object[] { matd }).Rows[0][0].ToString());
                e.Graphics.DrawString(priveofmenu.ToString("#,###", cul.NumberFormat), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, positionY));

                e.Graphics.DrawString(row["CTPDT_SoLuong"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(425, positionY));

                int total = priveofmenu * Convert.ToInt32(row["CTPDT_SoLuong"].ToString());
                e.Graphics.DrawString(total.ToString("#,###", cul.NumberFormat), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(550, positionY));

                totalpriceofpdt += total;
            }


            positionY += 10;
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, positionY));
            positionY += 50;
            e.Graphics.DrawString("Tổng", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(550, positionY));
            positionY += 40;
            e.Graphics.DrawString(((totalpriceofpdt/100)*30 + totalpriceofpdt ).ToString("#,###", cul.NumberFormat) + " VND", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(550, positionY));


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btncancleClick(panel1.Tag.ToString());
        }

        void btnpaymentClick(string id)
        {
            string sql = "Update PhieuDatTiec Set PDT_TrangThaiThanhToan = 2 where PDT_Ma = " + id;
            DataProvider.Instance.ExcuteNonQuerry(sql);

        }

        void btncancleClick(string id)
        {
            string sql = "Update PhieuDatTiec Set PDT_TrangThai = 0 where PDT_Ma = " + id;
            DataProvider.Instance.ExcuteNonQuerry(sql);
            Load();

        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            btnpaymentClick(panel1.Tag.ToString());
            Load();

        }


        private void pn_now_Click(object sender, EventArgs e)
        {
            Load(2);
            txt_search.Visible = false;
        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            string start = timestart.Value.ToString("yyyy-MM-dd");
            string end = timeend.Value.ToString("yyyy-MM-dd");

            loaddoanhthu(start, end);

        }

        private void loaddoanhthu(string start, string end)
        {

            string sqldone = "Select SUM(PDT_TongTien) from PhieuDatTiec where PDT_ThoiGian >= '" + start + "' and PDT_ThoiGian <= '" + end + " 23:59:59' and PDT_TrangThaiThanhToan = 2";
            string sqlnodone = "Select SUM(PDT_TongTien) from PhieuDatTiec where PDT_ThoiGian >= '" + start + "' and PDT_ThoiGian <= '" + end + " 23:59:59' and PDT_TrangThaiThanhToan = 1";

            int done = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry(sqldone).Rows[0][0]);
            int nodone = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry(sqlnodone).Rows[0][0]);

            lb_doanhthu.Text =(done + ((nodone/100)*10)).ToString("#,###", cul.NumberFormat);
        }
    }
}
