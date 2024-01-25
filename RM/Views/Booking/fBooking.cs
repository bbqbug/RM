using FontAwesome.Sharp;
using RM.DAL;
using RM.Views.Admin.Bill;
using RM.Views.Booking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Forms;
using System.Drawing.Printing;
using Point = System.Drawing.Point;
using MessageBox = System.Windows.MessageBox;

namespace RM.Views
{
    public partial class fBooking : Form
    {
        private int countArea = 0;
        private int countMenu = 0;
        public fBooking()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            addBtnAdd();

            string time = "2023-12-12"; //DateTime.Now.ToString("yyyy-MM-dd"); // "2023-11-15";

            loadBillOfDay(time);
            loadAreaOfDay(time);

        }


        void addBtnAdd()
        {
            flow_menu.Controls.Clear();
            flow_area.Controls.Clear();
            IconButton btn_addmenu = new IconButton();
            btn_addmenu.Dock = System.Windows.Forms.DockStyle.Top;
            btn_addmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_addmenu.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_addmenu.IconColor = System.Drawing.Color.Black;
            btn_addmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addmenu.IconSize = 36;
            btn_addmenu.Location = new System.Drawing.Point(3, 3);
            btn_addmenu.Size = new System.Drawing.Size(45, 43);
            btn_addmenu.TabIndex = 0;
            btn_addmenu.UseVisualStyleBackColor = true;
            btn_addmenu.FlatAppearance.BorderSize = 0;
            btn_addmenu.Click += (object sender, EventArgs e) =>
            {
                addMenu();
                //AddMenu menu = new AddMenu();
                //menu.Tag = countMenu;
                //var btn_delete = menu.Controls.OfType<IconButton>().ToList();

                //btn_delete[0].Tag = countMenu;

                //btn_delete[0].Click += (object sd, EventArgs events) =>
                //{
                //    IconButton btn = sd as IconButton;
                //    //MessageBox.Show(btn.Tag.ToString());

                //    foreach (AddMenu addmenu in flow_menu.Controls.OfType<AddMenu>().ToList())
                //    {
                //        if (addmenu.Tag.ToString() == btn.Tag.ToString())
                //            flow_menu.Controls.Remove(addmenu);
                //    }
                //};


                //flow_menu.Controls.Add(menu);

                //countMenu++;
            };

            IconButton btn_addarea = new IconButton();
            btn_addarea.Dock = System.Windows.Forms.DockStyle.Top;
            btn_addarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_addarea.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_addarea.IconColor = System.Drawing.Color.Black;
            btn_addarea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addarea.IconSize = 36;
            btn_addarea.Location = new System.Drawing.Point(3, 3);
            btn_addarea.Size = new System.Drawing.Size(45, 43);
            btn_addarea.TabIndex = 0;
            btn_addarea.UseVisualStyleBackColor = true;
            btn_addarea.FlatAppearance.BorderSize = 0;
            btn_addarea.Click += (object sender, EventArgs e) =>
            {

                addArea();
            };



            Label lbtitle = new Label();
            lbtitle.Text = "Khu Vực";
            lbtitle.Dock = DockStyle.Top;

            Label lbtitle1 = new Label();
            lbtitle1.Text = "Thực Đơn";
            lbtitle1.Dock = DockStyle.Top;

            flow_area.Controls.Add(lbtitle);
            flow_menu.Controls.Add(lbtitle1);


            flow_menu.Controls.Add(btn_addmenu);
            flow_area.Controls.Add(btn_addarea);

        }

        void addMenu()
        {
            AddMenu menu = new AddMenu();
            menu.Tag = countMenu;
            var btn_delete = menu.Controls.OfType<IconButton>().ToList();

            btn_delete[0].Tag = countMenu;

            btn_delete[0].Click += (object sd, EventArgs events) =>
            {
                IconButton btn = sd as IconButton;
                //MessageBox.Show(btn.Tag.ToString());

                foreach (AddMenu addmenu in flow_menu.Controls.OfType<AddMenu>().ToList())
                {
                    if (addmenu.Tag.ToString() == btn.Tag.ToString())
                    {
                        flow_menu.Controls.Remove(addmenu);
                        countMenu--;
                    }
                        
                }
            };


            flow_menu.Controls.Add(menu);

            countMenu++;
        }

        void addArea()
        {
            AddArea area = new AddArea();
            area.Tag = countArea;
            var btn_delete = area.Controls.OfType<IconButton>().ToList();

            btn_delete[0].Tag = countArea;

            btn_delete[0].Click += (object sd, EventArgs events) =>
            {
                IconButton btn = sd as IconButton;
                //MessageBox.Show(btn.Tag.ToString());

                foreach (AddArea areaa in flow_area.Controls.OfType<AddArea>().ToList())
                {
                    if (areaa.Tag.ToString() == btn.Tag.ToString())
                    {
                        flow_area.Controls.Remove(area);
                        countArea--;
                    }
                        
                }
            };


            flow_area.Controls.Add(area);

            countArea++;

        }

        void loadBillOfDay(string time)
        {
            flow_billofday.Controls.Clear();

            List<BillOfDay> list = BookingPresenter.Instance.GetBillOfDay(time);


            foreach (BillOfDay bod in list)
            {
                bod.Size = new System.Drawing.Size(200, 300);
                //bod.AutoSize = true;
                bod.Padding = new Padding(15);
               // bod.AutoSize = true;
                //bod.Anchor = AnchorStyles.None;

                //MessageBox.Show(bod.Size.ToString());

                switch (bod.Status)
                {
                    case "Chưa diễn ra":
                        {
                            Button btn_start = new Button();
                            btn_start.Text = "Bắt đầu";
                            btn_start.AutoSize = true;
                            btn_start.Location = new Point(60, 230);
                            btn_start.BackColor = Color.FromArgb(102, 187, 106);
                            btn_start.Click += (object sender, EventArgs e) =>
                            {
                                btnstartClick(bod.Id);
                                load();

                            };

                            bod.Controls.Add(btn_start);



                            //Button btn_payment = new Button();
                            //btn_payment.Text = "Thanh Toán";
                            //btn_payment.AutoSize = true;
                            //btn_payment.Location = new Point(60, 260);
                            //btn_payment.BackColor = Color.FromArgb(52, 152, 219);
                            //btn_payment.Click += (object sender, EventArgs e) =>
                            //{
                            //    btnpaymentClick(bod.Id);
                            //    load();

                            //};
                            //bod.Controls.Add(btn_payment);



                            //Button btn_cancle = new Button();
                            //btn_cancle.Text = "Hủy";
                            //btn_cancle.AutoSize = true;
                            //btn_cancle.Location = new Point(130, 230);
                            //btn_cancle.BackColor = Color.FromArgb(229, 57, 53);
                            //btn_cancle.Click += (object sender, EventArgs e) =>
                            //{
                            //    btncancleClick(bod.Id);
                            //    load();

                            //};
                            //bod.Controls.Add(btn_cancle);

                        }
                        break;
                    case "Đang diễn ra":
                        {
                            Button btn_done = new Button();
                            btn_done.Text = "Hoàn Thành";
                            btn_done.AutoSize = true;
                            btn_done.Location = new Point(60, 230);
                            btn_done.BackColor = Color.FromArgb(102, 187, 106);
                            btn_done.Click += (object sender, EventArgs e) =>
                            {
                                btndoneClick(bod.Id);
                                load();

                            };
                            bod.Controls.Add(btn_done);


                            //Button btn_payment = new Button();
                            //btn_payment.Text = "Thanh Toán";
                            //btn_payment.AutoSize = true;
                            //btn_payment.Location = new Point(60, 260);
                            //btn_payment.BackColor = Color.FromArgb(52, 152, 219);
                            //btn_payment.Click += (object sender, EventArgs e) =>
                            //{
                            //    btnpaymentClick(bod.Id);
                            //    load();

                            //};
                            //bod.Controls.Add(btn_payment);

                        }
                        break;
                    case "Đã diễn ra":
                        {

                            //Button btn_payment = new Button();
                            //btn_payment.Text = "Thanh Toán";
                            //btn_payment.AutoSize = true;
                            //btn_payment.Location = new Point(60, 260);
                            //btn_payment.BackColor = Color.FromArgb(52, 152, 219);
                            //btn_payment.Click += (object sender, EventArgs e) =>
                            //{
                            //    btnpaymentClick(bod.Id);
                            //    load();

                            //};
                            //bod.Controls.Add(btn_payment);

                        }
                        break;
                }

                flow_billofday.Controls.Add(bod);
            }
        }

        void btnstartClick(string id)
        {
            string sql = "Update PhieuDatTiec Set PDT_TrangThai = 2 where PDT_Ma = " + id;
            DataProvider.Instance.ExcuteNonQuerry(sql);

        }

        void btndoneClick(string id)
        {
            string sql = "Update PhieuDatTiec Set PDT_TrangThai = 3 where PDT_Ma = " + id;
            DataProvider.Instance.ExcuteNonQuerry(sql);


        }

        

        void loadAreaOfDay(string time)
        {
            flow_areaofday.Controls.Clear();

            DataTable areas = DataProvider.Instance.ExcuteQuerry("Select KV_Ma,KV_Ten from KhuVuc");

            foreach (DataRow row in areas.Rows)
            {
                FlowLayoutPanel flow = new FlowLayoutPanel();
                flow.Name = "flow_" + row["KV_Ma"].ToString();
                flow.Size = new System.Drawing.Size(350, 200);
                flow.BackColor = Color.Gray;
                flow.Tag = row["KV_Ma"].ToString();
                flow.AutoScroll = true;
                flow.Anchor = AnchorStyles.None;
                //flow.AutoSize = true;
                

                Label label = new Label();
                label.Text = row["KV_Ten"].ToString();
                label.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
                label.Anchor = AnchorStyles.None;
                //label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Margin = new Padding(10);
                label.Size = new System.Drawing.Size(320, 20);
                flow.Controls.Add(label);

                List<Area> listarea = BookingPresenter.Instance.GetAreaOfDay(row["KV_Ma"].ToString(), time);

                foreach (Area areaa in listarea)
                {
                    flow.Controls.Add(areaa);
                }

                //Label lb = new Label();
                //lb.Text = "Aaaaaaaaaaaaaaa";
                //flow.Controls.Add(lb);



                flow_areaofday.Controls.Add(flow);


            }


            List<Area> list = new List<Area>();

            foreach (Area area in list)
            {
                flow_areaofday.Controls.Add(area);
            }
        }


        private void btn_booking_Click(object sender, EventArgs e)
        {
            if(flow_menu.Controls.OfType<AddMenu>().ToList().Count > 0 
                && flow_area.Controls.OfType<AddArea>().ToList().Count > 0
                && txt_fullname.Text != "" 
                && txt_phone.Text != ""
                && dt_date.Value > DateTime.Now
                && check_tt.Checked == true)
            {
                
                //kiem tra so luong cho ngoi va so luong khach
                double qttofarea = 0;
                double qttofmenu = 0;

                foreach (AddMenu menu in flow_menu.Controls.OfType<AddMenu>().ToList())
                {
                    qttofmenu = qttofmenu +  menu.Quantity*10;
                }


                foreach(AddArea area in flow_area.Controls.OfType<AddArea>().ToList())
                {
                    qttofarea += area.Quantity;
                }

                //check khuvuc

                if (qttofmenu <= qttofarea)
                {
                    //tong gia tri cua thuc don
                    int totalpice = 0;
                    foreach (AddMenu menu in flow_menu.Controls.OfType<AddMenu>().ToList())
                    {

                        int id = menu.Menu;

                        DataTable data = DataProvider.Instance.ExcuteQuerry("Select * from ThucDon, MonAn, ChiTietThucDon where ThucDon.TD_Ma = ChiTietThucDon.CTTD_MaTD and ChiTietThucDon.CTTD_MaMA = MonAn.MA_Ma and ThucDon.TD_Ma = " + id);

                        int priceofmenu = 0;

                        foreach (DataRow row in data.Rows)
                        {
                            priceofmenu += Convert.ToInt32(row["MA_Gia"].ToString());
                        }

                        totalpice += priceofmenu * menu.Quantity;

                        totalpice = totalpice + totalpice * 30 / 100;
                    }


                    string[] fullname = txt_fullname.Text.Split(' ');

                    string firstname = fullname[0];
                    string lastname = "";

                    for (int i = 1; i < fullname.Length; i++)
                    {
                        lastname = lastname + " " + fullname[i];

                    }

                    string phone = txt_phone.Text;
                    string date = dt_date.Value.ToString("yyyy-MM-dd");
                    string time = dt_time.Value.ToString("HH:mm");

                    string datetime = date + " " + time;

                    //check customer is already exists
                    DataTable check = DataProvider.Instance.ExcuteQuerry("Select * from KhachHang where KH_SDT = '" + phone + "'");
                    if (check.Rows.Count == 0)
                    {
                        //them khach hang moi
                        DataProvider.Instance.ExcuteNonQuerry("insert into KhachHang(KH_Ho, KH_Ten, KH_SDT) values( @fn , @ln , @sdt )", new object[] { firstname, lastname, phone });
                    }




                    //tao phieu dat tiec
                    string sqlpdt = "insert into PhieuDatTiec(PDT_ThoiGian, PDT_TongTien, PDT_SDTKH) values( @datetime , @total , @sdt )";

                    DataProvider.Instance.ExcuteNonQuerry(sqlpdt, new object[] { datetime, totalpice, phone });

                    int mapdt = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("Select PDT_Ma from PhieuDatTiec where PDT_SDTKH = '" + phone + "' and PDT_ThoiGian = '" + datetime + "' and PDT_TongTien = " + totalpice).Rows[0][0]);

                    //them thuc don cho phieu dat tiec
                    foreach (AddMenu menu in flow_menu.Controls.OfType<AddMenu>().ToList())
                    {
                        string sqlctpdt = "insert into ChiTietPhieuDatTiec values( @pdt , @td , @sluong )";

                        DataProvider.Instance.ExcuteNonQuerry(sqlctpdt, new object[] { mapdt, menu.Menu, menu.Quantity });
                    }

                    //them khu vuc cua phieu dat tiec
                    foreach (AddArea area in flow_area.Controls.OfType<AddArea>().ToList())
                    {
                        string sqlkvt = "insert into KhuVucTiec values( @pdt , @kv )";
                        DataProvider.Instance.ExcuteNonQuerry(sqlkvt, new object[] { mapdt, area.Id });
                    }


                    //them lich lam viec cho nhan vien

                    //Them nhan vien tao phieu dat tiec
                    int manv = Convert.ToInt32(this.Parent.Parent.Controls.Find("name_user", true)[0].Tag.ToString());
                    string sqlptt = "insert into PhuTrachTiec(PTT_MaNV, PTT_MaPDT) values ( @nv , @pdt )";
                    DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { manv, mapdt });

                    //them nhan vien bep phu trach tiec
                    //1ql
                    DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { 9, mapdt });
                    //1/100 to truong bep
                    DataTable listttbep = DataProvider.Instance.ExcuteQuerry("Execute getNV @datetimes , @bp , @cv", new object[] { datetime, 2, 2 });
                    //MessageBox.Show("To Truong Bep " +listtt.Rows.Count.ToString());
                    List<int> randomttbep = Random(Convert.ToInt32(Math.Round(qttofmenu / 100)), listttbep.Rows.Count);

                    foreach(int i in randomttbep)
                    {
                        //MessageBox.Show(listtt.Rows[i]["NV_Ma"].ToString());
                        DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { Convert.ToInt32(listttbep.Rows[i]["NV_Ma"].ToString()), mapdt });
                    }


                    //nhanvien 1/50
                    DataTable listnvbep = DataProvider.Instance.ExcuteQuerry("Execute getNV @datetimes , @bp , @cv", new object[] { datetime, 2 , 3 });
                    //MessageBox.Show("Nhan Vien Bep "+listnv.Rows.Count.ToString());
                    List<int> listrandomnvbep = Random(Convert.ToInt32(Math.Round(qttofmenu / 50)), listnvbep.Rows.Count);


                    
                    foreach (int i in listrandomnvbep)
                    {
                        //MessageBox.Show(listnv.Rows[i]["NV_Ma"].ToString());
                        DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { Convert.ToInt32(listnvbep.Rows[i]["NV_Ma"].ToString()), mapdt});
                    }
                    

                    



                    //them nhan vien phuc vu cho tiec
                    //1ql
                    DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] {37, mapdt });
                    //1totruong/100
                    DataTable listttpv = DataProvider.Instance.ExcuteQuerry("Execute getNV @datetimes , @bp , @cv", new object[] { datetime, 3, 2 });
                    List<int> randomttpv = Random(Convert.ToInt32(Math.Round(qttofmenu / 100)), listttpv.Rows.Count);
                    foreach (int i in randomttpv)
                    {
                        //MessageBox.Show(listttpv.Rows[i]["NV_Ma"].ToString());
                        DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { Convert.ToInt32(listttpv.Rows[i]["NV_Ma"].ToString()), mapdt });
                    }
                    //1nv/30khach
                    DataTable listnvpv = DataProvider.Instance.ExcuteQuerry("Execute getNV @datetimes , @bp , @cv", new object[] { datetime, 3, 3 });
                    List<int> listrandomnvpv = Random(Convert.ToInt32(Math.Round(qttofmenu / 30)), listnvpv.Rows.Count);

                    foreach (int i in listrandomnvpv)
                    {
                        //MessageBox.Show(listnvpv.Rows[i]["NV_Ma"].ToString());
                        DataProvider.Instance.ExcuteNonQuerry(sqlptt, new object[] { Convert.ToInt32(listnvpv.Rows[i]["NV_Ma"].ToString()), mapdt });
                    }

                    MessageBox.Show("Đặt thành công");

                    load();
                    clear();
                } 
                else
                {
                    MessageBox.Show("Vui lòng chọn khu vực lớn hơn!!!");

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

            }

            

            //MessageBox.Show(datetime);







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

            //string c = "";
            //foreach(int z in list)
            //{
            //    c = c + " " + z;
            //}

            //MessageBox.Show(c);


            return list;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Control[] ct = this.Parent.Parent.Controls.Find("name_user", true);
        //    if (ct != null)
        //    {
        //        MessageBox.Show(ct[0].Text);
        //    }
        //    //MessageBox.Show(this.Parent.Parent.Controls.Find("name_user"));
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {

            string time = dt_date.Value.ToString("yyyy-MM-dd");

            if(btn_checkkv.Text != "Hủy")
            {
                btn_checkkv.Text = "Hủy";
                //MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd"));
                loadAreaOfDay(time);
            }
            else
            {
                btn_checkkv.Text = "Xem Khu Vực";

                dt_date.Value = DateTime.Now;
                loadAreaOfDay(DateTime.Now.ToString("yyyy-MM-dd"));
                //loadAreaOfDay(time);
            }
        }

        private void ktraso(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;

        }


        private void clear()
        {
            txt_fullname.Text = string.Empty;
            txt_phone.Text = string.Empty;
            dt_date.Value = DateTime.Now;
            dt_time.Value = DateTime.Now;
            check_tt.Checked = false;
        }
    }
}
