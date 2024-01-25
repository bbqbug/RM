using FontAwesome.Sharp;
using RM.DAL;
using RM.Views.Admin.Bill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views.Admin.Food
{
    public partial class fFood : Form
    {
        private static string src = AppDomain.CurrentDomain.BaseDirectory + "Image\\";
        private int countComponent = 0;
        private int countComponentAdd = 0;
        public fFood()
        {
            InitializeComponent();
            load();
            loadBtnAdd();
            loaddanhmuc();
            loadCount();
        }

        void load(string keysearch = null)
        {
            flow_food.Controls.Clear();
            //flow_component.Controls.Clear();
            List<FoodCard> list;

            if(keysearch != null) {

                list = FoodPresenter.Instance.GetListFood(keysearch);
                foreach(FoodCard card in list)
                {
                    //card.BackColor = Color.Black;
                    card.BorderStyle = BorderStyle.FixedSingle;

                    //card.ForeColor = Color.White;
                    foodClick(card);
                    flow_food.Controls.Add(card);
                }
            
            }
            else
            {
                list = FoodPresenter.Instance.GetListFood();
                //MessageBox.Show(list.Count.ToString());

                foreach(FoodCard card in list)
                {
                    //card.BackColor = Color.Black;
                    card.BorderStyle = BorderStyle.FixedSingle;
                   // card.ForeColor = Color.White;
                    foodClick(card);
                    flow_food.Controls.Add(card);
                }
            }


        }

        void loaddanhmuc()
        {
            cbb_dm.DataSource = DataProvider.Instance.ExcuteQuerry("select distinct MA_DanhMuc from MonAn");
            cbb_dm.DisplayMember = "MA_DanhMuc";
        }

        void foodClick(FoodCard food)
        {
            food.Click += (object sd, EventArgs e) =>
            {
                flow_component.Controls.Clear();
                flow_componentAdd.Controls.Clear();
                countComponent = 0;
                countComponentAdd = 0;
                loadBtnAdd();

                string sqlfood = "Select * from MonAn where MA_Ma = " + food.Tag.ToString();

                DataTable datafood = DataProvider.Instance.ExcuteQuerry(sqlfood);

                txt_name.Text = datafood.Rows[0]["MA_Ten"].ToString();
                txt_name.Tag = datafood.Rows[0]["MA_Ma"].ToString();
                txt_dvt.Text = datafood.Rows[0]["MA_DVT"].ToString();
                txt_price.Text = datafood.Rows[0]["MA_Gia"].ToString();
                cbb_dm.Text = datafood.Rows[0]["MA_DanhMuc"].ToString();

                if(datafood.Rows[0]["MA_HinhAnh"].ToString() != "")
                    img_food.Image = new Bitmap(src + datafood.Rows[0]["MA_HinhAnh"].ToString());
                else
                    img_food.Image = new Bitmap(src + "default_img.png");

                string sqlComponent = "Select * from MonAn, ChiTietCongThuc, NguyenLieu where MonAn.MA_Ma = ChiTietCongThuc.CTCT_MaMA and ChiTietCongThuc.CTCT_MaNL = NguyenLieu.NL_Ma and MonAn.MA_Ma = "+food.Tag;

                DataTable dataComponent = DataProvider.Instance.ExcuteQuerry(sqlComponent);

                foreach(DataRow row in dataComponent.Rows)
                {
                    Component component = new Component();
                    component.Idnl = Convert.ToInt32(row["NL_Ma"].ToString());
                    component.Quantity = Convert.ToInt32(row["CTCT_SoLuong"].ToString());
                    component.Tag = countComponent;

                    IconButton btndelete = component.Controls.OfType<IconButton>().ToList()[0];

                    btndelete.Tag = countComponent;

                    btndelete.Click += (object sder, EventArgs events) =>
                    {
                        deleteComponent(sder);
                    };

                    flow_component.Controls.Add(component);
                    countComponent++;
                }
            };
        }

        void loadBtnAdd()
        {
            //IconButton iconAdd = new IconButton();
            //iconAdd.IconChar = IconChar.PlusSquare;
            IconButton btn_add = new IconButton();
            btn_add.Text = "Nguyên liệu:";
            btn_add.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_add.IconColor = System.Drawing.Color.Black;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.IconSize = 36;
            btn_add.Location = new System.Drawing.Point(3, 3);
            btn_add.Size = new System.Drawing.Size(45, 43);
            btn_add.TabIndex = 0;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.AutoSize = true;
            btn_add.Click += (object sd, EventArgs e) =>
            {
                addComponent();
            };

            IconButton btn_addComponent = new IconButton();
            btn_addComponent.Text = "Nguyên liệu mới:";
            btn_addComponent.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_addComponent.Dock = System.Windows.Forms.DockStyle.Top;
            btn_addComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_addComponent.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_addComponent.IconColor = System.Drawing.Color.Black;
            btn_addComponent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addComponent.IconSize = 36;
            btn_addComponent.Location = new System.Drawing.Point(3, 3);
            btn_addComponent.Size = new System.Drawing.Size(45, 43);
            btn_addComponent.TabIndex = 0;
            btn_addComponent.UseVisualStyleBackColor = true;
            btn_addComponent.FlatAppearance.BorderSize = 0;
            btn_addComponent.AutoSize = true;
            btn_addComponent.Click += (object sd, EventArgs e) =>
            {
                addNewComponent();
            };

            flow_componentAdd.Controls.Add(btn_addComponent);
            flow_component.Controls.Add(btn_add);

        }

        void addComponent()
        {
            Component cpn = new Component();
            cpn.Dock = DockStyle.Top;

            cpn.Tag = countComponent;

            IconButton btndelete = cpn.Controls.OfType<IconButton>().ToList()[0];

            btndelete.Tag = countComponent;

            btndelete.Click += (object sd, EventArgs e) =>
            {
                deleteComponent(sd);
            };
            
            flow_component.Controls.Add(cpn);
            countComponent++;

        }

        void deleteComponent(object sd)
        {
            IconButton btn = sd as IconButton;

            foreach(Component cpn in flow_component.Controls.OfType<Component>().ToList())
            {
                if(cpn.Tag.ToString() == btn.Tag.ToString())
                {
                    flow_component.Controls.Remove(cpn);
                }
            }
        }


        void addNewComponent()
        {

            AddComponent newcpn = new AddComponent();

            newcpn.Tag = countComponentAdd;

            IconButton btndelete = newcpn.Controls.OfType<IconButton>().ToList()[0];
            btndelete.Tag = countComponentAdd;

            btndelete.Click += (object sd, EventArgs e) =>
            {
                deleteNewComponent(sd);
            };

            flow_componentAdd.Controls.Add(newcpn);
            countComponentAdd++;

        }

        void deleteNewComponent(object sd)
        {
            IconButton btn = sd as IconButton;

            foreach(AddComponent addcpn in flow_componentAdd.Controls.OfType<AddComponent>().ToList())
            {
                if(addcpn.Tag.ToString() == btn.Tag.ToString())
                {
                    flow_componentAdd.Controls.Remove(addcpn);
                }
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(btn_save.Visible == true)
            {
                btn_save.Visible = false;
                btn_add.IconChar = IconChar.PlusSquare;
                flow_component.Controls.Clear();
                flow_componentAdd.Controls.Clear();
                clearinfor();
                loadBtnAdd();
            }
            else
            {
                btn_save.Visible = true;
                btn_add.IconChar = IconChar.Xmark;
                flow_component.Controls.Clear();
                flow_componentAdd.Controls.Clear();
                clearinfor();
                loadBtnAdd();

            }
        }

        void clearinfor()
        {
            txt_name.Text = "";
            txt_dvt.Text = "";
            txt_price.Text = "";
            cbb_dm.Text = "";

            lb_srcimage.Tag = null;

            img_food.Image = new Bitmap(src + "default_img.png");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            load(txt_search.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
            //MessageBox.Show(src + lb_srcimage.Tag);

            //MessageBox.Show((img_food.Image == null).ToString());
            string name = txt_name.Text;
            string dvt = txt_dvt.Text;
            string price = txt_price.Text;
            string danhmuc = cbb_dm.Text;

            if (checkAddNew(name))
            {
                

                int add = 0;
                
                //them mon an
                if(lb_srcimage.Tag != null)
                {

                    string image = lb_srcimage.Tag.ToString();

                    string sql = "insert into MonAn(MA_Ten, MA_DVT, MA_Gia, MA_DanhMuc, MA_HinhAnh) values ( @ten , @dvt , @gia , @dm , @anh )";

                    add = DataProvider.Instance.ExcuteNonQuerry(sql, new object[] { name, dvt, price, danhmuc, image });

                    File.Copy(lb_srcimage.Text, src + lb_srcimage.Tag);

                }
                else
                {
                    string sql = "insert into MonAn(MA_Ten, MA_DVT, MA_Gia, MA_DanhMuc) values ( @ten , @dvt , @gia , @dm )";
                    add =DataProvider.Instance.ExcuteNonQuerry(sql, new object[] { name, dvt, price, danhmuc});

                }


                //them ctct

                int maMonAn = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("Select MA_Ma from MonAn where MA_Ten = N'" + name + "'").Rows[0][0].ToString());

                string sqlcomponent = "insert into ChiTietCongThuc(CTCT_MaMA , CTCT_MaNL, CTCT_SoLuong) values ( @ma , @nl , @sl )";

                if (flow_component.Controls.OfType<Component>().ToList().Count > 0)
                {
                    
                    foreach(Component cponent in flow_component.Controls.OfType<Component>().ToList())
                    {
                        DataProvider.Instance.ExcuteNonQuerry(sqlcomponent, new object[] { maMonAn, cponent.Idnl, cponent.Quantity });
                    }
                }

                if (flow_componentAdd.Controls.OfType<AddComponent>().ToList().Count > 0)
                {

                    string sqladd = "insert into NguyenLieu(NL_Ten, NL_DonViTinh) values ( @name , @dvt )";

                    foreach(AddComponent cponent in flow_componentAdd.Controls.OfType<AddComponent>().ToList())
                    {
                        DataProvider.Instance.ExcuteNonQuerry(sqladd, new object[] { cponent.Tennl, cponent.Dvt });

                        int manl = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("Select NL_Ma from NguyenLieu where NL_Ten = N'" + cponent.Tennl + "'").Rows[0][0].ToString());

                        DataProvider.Instance.ExcuteNonQuerry(sqlcomponent, new object[] { maMonAn, manl, cponent.Quantity });
                    }
                    
                }

                if (add > 0)
                {
                    MessageBox.Show("Thêm thành công!!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }


                load();
                clearinfor();
                //File.Copy(lb_srcimage.Text, src + lb_srcimage.Tag);




            }

        }

        private bool checkAddNew(string name)
        {
            DataTable monan = DataProvider.Instance.ExcuteQuerry("Select * from MonAn where MA_Ten = '" + name + "'");
           if(monan.Rows.Count ==  0)
            {
                if (flow_component.Controls.OfType<Component>().ToList().Count > 0 || flow_componentAdd.Controls.OfType<AddComponent>().ToList().Count > 0)
                    return true;
                else
                {
                    MessageBox.Show("Hãy thêm công thức cho món ăn!!!");
                    return false;
                }
                   
            }
           else
            {
                MessageBox.Show("Món ăn đã tồn tại");
                return false;
            }
        }

        private void btn_loadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                img_food.Image = new Bitmap(open.FileName);

                lb_srcimage.Text = open.FileName;
                lb_srcimage.Tag = Path.GetFileName(open.FileName);

            }
        }

        void loadfood(int n)
        {
            flow_food.Controls.Clear();
            List<FoodCard> list = FoodPresenter.Instance.loadfood(n);

            foreach (FoodCard card in list)
            {
                //card.BackColor = Color.Black;
                card.BorderStyle = BorderStyle.FixedSingle;
                // card.ForeColor = Color.White;
                foodClick(card);
                flow_food.Controls.Add(card);
            }
        }
        
        private void pn_monchinh_Click(object sender, EventArgs e)
        {
            loadfood(2);
        }

        private void pn_khaivi_Click(object sender, EventArgs e)
        {
            loadfood(1);
        }

        private void pn_trangmieng_Click(object sender, EventArgs e)
        {
            loadfood(3);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string dvt = txt_dvt.Text;
            string price = txt_price.Text;
            string danhmuc = cbb_dm.Text;
            int idFood = Convert.ToInt32(txt_name.Tag.ToString());
            int update = 0;

            if(flow_component.Controls.OfType<Component>().ToList().Count > 0 || flow_componentAdd.Controls.OfType<AddComponent>().ToList().Count > 0)
            {

                //update MonAn
                if (lb_srcimage.Tag != null)
                {
                    string anh = lb_srcimage.Tag.ToString();
                    string sqlupdate = "Update MonAn Set MA_Ten = @ten , MA_DVT = @dvt , MA_Gia = @gia , MA_DanhMuc = @dm , MA_HinhAnh = @anh Where MA_Ma = @id";

                    update = DataProvider.Instance.ExcuteNonQuerry(sqlupdate, new object[] { name, dvt, price, danhmuc, anh, idFood });

                    string checkimg = DataProvider.Instance.ExcuteQuerry("Select MA_HinhAnh from MonAn where MA_Ma = " + idFood).Rows[0][0].ToString();

                    if(checkimg != "")
                    {
                        File.Delete(checkimg);
                    }

                    File.Copy(lb_srcimage.Text, src + lb_srcimage.Tag);

                    

                }
                else
                {
                    string sqlupdate = "Update MonAn Set MA_Ten = @ten , MA_DVT = @dvt , MA_Gia = @gia , MA_DanhMuc = @dm Where MA_Ma = @id";

                    update = DataProvider.Instance.ExcuteNonQuerry(sqlupdate, new object[] { name, dvt, price, danhmuc, idFood });
                }


                //xoa ctct va them ctct moi
                DataProvider.Instance.ExcuteNonQuerry("Delete from ChiTietCongThuc where CTCT_MaMA = " + idFood);
                string sqlcomponent = "insert into ChiTietCongThuc(CTCT_MaMA , CTCT_MaNL, CTCT_SoLuong) values ( @ma , @nl , @sl )";

                if (flow_component.Controls.OfType<Component>().ToList().Count > 0)
                {

                    foreach (Component cponent in flow_component.Controls.OfType<Component>().ToList())
                    {
                        DataProvider.Instance.ExcuteNonQuerry(sqlcomponent, new object[] { idFood, cponent.Idnl, cponent.Quantity });
                    }
                }

                if (flow_componentAdd.Controls.OfType<AddComponent>().ToList().Count > 0)
                {

                    string sqladd = "insert into NguyenLieu(NL_Ten, NL_DonViTinh) values ( @name , @dvt )";

                    foreach (AddComponent cponent in flow_componentAdd.Controls.OfType<AddComponent>().ToList())
                    {
                        DataProvider.Instance.ExcuteNonQuerry(sqladd, new object[] { cponent.Tennl, cponent.Dvt });

                        int manl = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("Select NL_Ma from NguyenLieu where NL_Ten = N'" + cponent.Tennl + "'").Rows[0][0].ToString());

                        DataProvider.Instance.ExcuteNonQuerry(sqlcomponent, new object[] { idFood, manl, cponent.Quantity });
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập công thức món ăn!!!", "Warning" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            if(update > 0) {
                MessageBox.Show("Sửa Thành Công!!!");
                load();
                loadCount();
            }
        }

        void loadCount()
        {
            lb_khaivi.Text = DataProvider.Instance.ExcuteQuerry("Select * from MonAn where MA_DanhMuc = N'Khai Vị'").Rows.Count.ToString();
            lb_monchinh.Text = DataProvider.Instance.ExcuteQuerry("Select * from MonAn where MA_DanhMuc = N'Món Chính'").Rows.Count.ToString();
            lb_trangmieng.Text = DataProvider.Instance.ExcuteQuerry("Select * from MonAn where MA_DanhMuc = N'Tráng Miệng'").Rows.Count.ToString();
            lb_total.Text = DataProvider.Instance.ExcuteQuerry("Select * from MonAn").Rows.Count.ToString();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(txt_name.Tag.ToString());

            int checkFoodExistsInMenu = DataProvider.Instance.ExcuteQuerry("Select * from ChiTietThucDon where CTTD_MaMA = " + idFood).Rows.Count;

            if(checkFoodExistsInMenu == 0)
            {
                string sqlctct = "Delete from ChiTietCongThuc where CTCT_MaMA = " + idFood;

                DataProvider.Instance.ExcuteNonQuerry(sqlctct);

                if(DataProvider.Instance.ExcuteNonQuerry("Delete from MonAn where MA_Ma = " + idFood) > 0)
                {
                    MessageBox.Show("Xóa Món Ăn Thành Công");
                    loadCount();
                    load();
                }
            }
            else
            {
                MessageBox.Show("Món ăn đang có trong thực đơn. Nếu muốn xóa món ăn thì hãy chỉnh sửa lại thực đơn trước!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }


}
