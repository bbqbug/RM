using RM.Views.Admin.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using RM.DAL;
using System.Threading;

namespace RM.Views.Admin
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
            load();
            loadFood();
            clear();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            load(txt_search.Text);

        }

        void clear()
        {
            txt_nameMenu.Text = "";
            txt_nameMenu.Tag = null;
            cbb_food1.SelectedIndex = -1;
            cbb_food2.SelectedIndex = -1;
            cbb_food3.SelectedIndex = -1;
            cbb_food4.SelectedIndex = -1;
            cbb_food5.SelectedIndex = -1;
            txt_mota.Text = "";

        }

        void bindsource(DataTable source, ComboBox cbb)
        {
            cbb.DataSource = source;
            cbb.DisplayMember = "MA_Ten";
            cbb.ValueMember = "MA_Ma";
        }

        void loadFood()
        {
            string khaivi ="Select MA_Ma, MA_Ten from MonAn where MA_DanhMuc = N'Khai Vị'";
            string monchinh = "Select MA_Ma, MA_Ten from MonAn where MA_DanhMuc = N'Món Chính'";
            string trangmieng = "Select MA_Ma, MA_Ten from MonAn where MA_DanhMuc = N'Tráng Miệng'";

            bindsource(DataProvider.Instance.ExcuteQuerry(khaivi), cbb_food1);
            bindsource(DataProvider.Instance.ExcuteQuerry(monchinh), cbb_food2);
            bindsource(DataProvider.Instance.ExcuteQuerry(monchinh), cbb_food3);
            bindsource(DataProvider.Instance.ExcuteQuerry(monchinh), cbb_food4);
            bindsource(DataProvider.Instance.ExcuteQuerry(trangmieng), cbb_food5);
            clear();
        }

        void load(string keysearch = null)
        {
            //listcard///
            flowLayoutPanel1.Controls.Clear();
            Thread.Sleep(50);

            if(keysearch != null)
            {
                List<CardMenu> listmenu = MenuPresenter.Instance.GetListCardMenu(keysearch);

                foreach (CardMenu item in listmenu)
                {
                    //event click menu
                    item.Click += (object sender, EventArgs e) =>
                    {

                        CardMenu x = sender as CardMenu;

                        btn_add.IconChar = IconChar.PlusSquare;
                        btn_stop.Visible = true;
                        btn_update.Visible = true;
                        btn_save.Visible = false;
                        panel2.Visible = true;

                        //
                        txt_nameMenu.Text = item.MenuName;
                        txt_nameMenu.Tag = item.Tag;
                        cbb_food1.Text = item.Food1;
                        cbb_food2.Text = item.Food2;
                        cbb_food3.Text = item.Food3;
                        cbb_food4.Text = item.Food4;
                        cbb_food5.Text = item.Food5;
                        txt_mota.Text = DataProvider.Instance.ExcuteQuerry("select TD_Mota from ThucDon where TD_Ma = " + x.Tag.ToString()).Rows[0][0].ToString();


                        int tttd = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("Select TD_TrangThai from ThucDon where TD_Ma = " + item.Tag.ToString()).Rows[0][0]);

                        if (tttd == 1)
                        {
                            btn_stop.Visible = true;
                            btn_active.Visible = false;
                        }
                        else
                        {
                            btn_active.Visible = true;
                            btn_stop.Visible = false;
                        }




                    };

                    //if (flowLayoutPanel1.Controls.Count < 0) flowLayoutPanel1.Controls.Clear();

                    //add cardmenu to FlowlayoutPanel
                    flowLayoutPanel1.Controls.Add(item);
                }

            } 
            else
            {
                List<CardMenu> listmenu = MenuPresenter.Instance.GetListCardMenu();

                foreach (CardMenu item in listmenu)
                {
                    //event click menu
                    item.Click += (object sender, EventArgs e) =>
                    {

                        CardMenu x = sender as CardMenu;

                        btn_add.IconChar = IconChar.PlusSquare;
                        btn_stop.Visible = true;
                        btn_update.Visible = true;
                        btn_save.Visible = false;
                        panel2.Visible = true;

                        //
                        txt_nameMenu.Text = x.MenuName;
                        txt_nameMenu.Tag = x.Tag;
                        cbb_food1.Text = x.Food1;
                        cbb_food2.Text = x.Food2;
                        cbb_food3.Text = x.Food3;
                        cbb_food4.Text = x.Food4;
                        cbb_food5.Text = x.Food5;
                        txt_mota.Text = DataProvider.Instance.ExcuteQuerry("select TD_Mota from ThucDon where TD_Ma = " + x.Tag.ToString()).Rows[0][0].ToString();


                        int tttd = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("Select TD_TrangThai from ThucDon where TD_Ma = " + item.Tag.ToString()).Rows[0][0]);

                        if (tttd == 1)
                        {
                            btn_stop.Visible = true;
                            btn_active.Visible = false;
                        }
                        else
                        {
                            btn_active.Visible = true;
                            btn_stop.Visible = false;
                        }

                    };

                    //if (flowLayoutPanel1.Controls.Count < 0) flowLayoutPanel1.Controls.Clear();

                    //add cardmenu to FlowlayoutPanel
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fMenu_Load(object sender, EventArgs e)
        {
            //load();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            if(btn_save.Visible == true)
            {

                btn_save.Visible = false;
                btn_add.IconChar = IconChar.PlusSquare;
                panel2.Visible = false;
                
            } 
            else
            {
                clear();

                txt_nameMenu.Text = "Thực đơn "+(Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("Select Max(TD_Ma) from ThucDon").Rows[0][0])+1).ToString(); 
                panel2.Visible = true;
                btn_update.Visible = false;
                btn_stop.Visible = false;
                btn_save.Visible = true;
                btn_add.IconChar = IconChar.Xmark;

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string nameMenu = txt_nameMenu.Text;
            

            string mota = txt_mota.Text;
            int food1 = Convert.ToInt32(cbb_food1.SelectedValue);
            int food2 = Convert.ToInt32(cbb_food2.SelectedValue);
            int food3 = Convert.ToInt32(cbb_food3.SelectedValue);
            int food4 = Convert.ToInt32(cbb_food4.SelectedValue);
            int food5 = Convert.ToInt32(cbb_food5.SelectedValue);
            if( food4 == food2 || food4 == food3 || food3 == food2)
            {
                MessageBox.Show("Vui lòng chọn các món chính khác nhau");
            } 
            else
            {
                string sql = "Execute AddMenu @ten , @mota , @food1 , @food2 , @food3 , @food4 , @food5";

                int kq = 0;
                kq = DataProvider.Instance.ExcuteNonQuerry(sql, new object[] {nameMenu, mota, food1, food2, food3, food4, food5 });
                
                if( kq >0 ) {
                    MessageBox.Show("Thêm thành công");
                    clear();
                    load();
                }

            }
            


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string nameMenu = txt_nameMenu.Text;
            int ma = Convert.ToInt32(txt_nameMenu.Tag);

            string mota = txt_mota.Text;
            int food1 = Convert.ToInt32(cbb_food1.SelectedValue);
            int food2 = Convert.ToInt32(cbb_food2.SelectedValue);
            int food3 = Convert.ToInt32(cbb_food3.SelectedValue);
            int food4 = Convert.ToInt32(cbb_food4.SelectedValue);
            int food5 = Convert.ToInt32(cbb_food5.SelectedValue);
            if (food4 == food2 || food4 == food3 || food3 == food2)
            {
                MessageBox.Show("Vui lòng chọn các món chính khác nhau");
            }
            else
            {
                string sql = "Execute UpdateMenu @ma , @ten , @mota , @food1 , @food2 , @food3 , @food4 , @food5";

                int kq = 0;
                kq = DataProvider.Instance.ExcuteNonQuerry(sql, new object[] {ma, nameMenu, mota, food1, food2, food3, food4, food5 });

                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    //clear();
                    load();
                }

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            string sql = "Update ThucDon set TD_TrangThai = 0 where TD_Ma = " + txt_nameMenu.Tag.ToString();

            if(DataProvider.Instance.ExcuteNonQuerry(sql) > 0)
            {
                MessageBox.Show("Đã tạm ngưng");
                load();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string sql = "Update ThucDon set TD_TrangThai = 1 where TD_Ma = " + txt_nameMenu.Tag.ToString();

            if (DataProvider.Instance.ExcuteNonQuerry(sql) > 0)
            {
                MessageBox.Show("Đã mở lại");
                load();
            }
        }
    }
}
