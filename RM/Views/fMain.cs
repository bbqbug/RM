using FontAwesome.Sharp;
using Microsoft.Win32;
using RM.DAL;
using RM.Views.Admin;
using RM.Views.Admin.Bill;
using RM.Views.Admin.Food;
using RM.Views.Admin.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Application;
using MessageBox = System.Windows.MessageBox;

namespace RM.Views
{
    public partial class fMain : Form
    {
        private IconButton currbtn;
        private Panel borderleftbtn;
        private static string path = AppDomain.CurrentDomain.BaseDirectory + "\\Image\\";


        public fMain(int manv)
        {
            InitializeComponent();

            Authentication(manv);

            int cv = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("select NV_MaCV from NhanVien where NV_Ma = " + manv).Rows[0][0].ToString());
            int bp = Convert.ToInt32(DataProvider.Instance.ExcuteQuerry("select NV_MaBP from NhanVien where NV_Ma = " + manv).Rows[0][0].ToString());

            

            if(bp == 1 || bp == 2 || bp ==3)
            {
                if (cv == 3 || cv == 2)
                {
                    //btn_staff.ForeColor = Color.Red;
                    btn_staff.Enabled = false;

                    btn_menu.Enabled = false;

                    btn_food.Enabled = false;

                    //btn_bill.Enabled = false;

                }

                if(cv == 1)
                {
                    //btn_staff.Enabled = false;
                }

            }

            openChildForm(new fHome());

            
            borderleftbtn = new Panel();
            borderleftbtn.Size = new System.Drawing.Size(7, 60);
            panel1.Controls.Add(borderleftbtn);
        }

        private void Authentication(int manv)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuerry("Select * from NhanVien where NV_Ma = " + manv);

            
            name_user.Text = dt.Rows[0]["NV_Ho"].ToString() + " " + dt.Rows[0]["NV_Ten"].ToString();
            name_user.Tag = dt.Rows[0]["NV_Ma"].ToString();

           //MessageBox.Show(dt.Rows[0]["NV_HinhAnh"].ToString());
            img_user.Image = dt.Rows[0]["NV_HinhAnh"].ToString() == "" ? new Bitmap(Path.Combine(path, "user_default.png")) : new Bitmap(Path.Combine(path, dt.Rows[0]["NV_HinhAnh"].ToString()));
        }


        private struct RGBColor
        {
            public static Color color1 = Color.Yellow;
            

        };

        private void openChildForm(Form childform)
        {
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.TopLevel = false;
            childform.Top = 0;
            childform.Left = 0;
            //childform.Size = pn_main.Size;
            //pn_main.Controls.Add(childform);
            childform.MdiParent = this;
            childform.Dock = DockStyle.Fill;
            childform.Show();
            childform.BringToFront();
        }

        private void ActiveBtn(object senderbtn, Color color)
        {
            if(senderbtn != null)
            {
                Disablebtn(currbtn);

                currbtn = (IconButton)senderbtn;
                //currbtn.BackColor = color;
                currbtn.TextAlign = ContentAlignment.MiddleCenter;
                currbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currbtn.ImageAlign = ContentAlignment.MiddleRight;
                currbtn.ForeColor = color;
                currbtn.IconColor = color;
                currbtn.Font = new Font(currbtn.Font, System.Drawing.FontStyle.Bold);

                borderleftbtn.BackColor = color;
                borderleftbtn.Location = new System.Drawing.Point(0, currbtn.Location.Y);
                borderleftbtn.Visible = true;
                borderleftbtn.BringToFront();

                //
                lb_control.Text = currbtn.Text;
                lb_control.ForeColor = color;
                icon_control.IconChar = currbtn.IconChar;
                icon_control.ForeColor = color;
                lb_control.Font = new Font(lb_control.Font, System.Drawing.FontStyle.Bold);



            }
            

        }

        private void Disablebtn(object senderbtn)
        {
            if(senderbtn != null)
            {
                currbtn = (IconButton)senderbtn;
                currbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currbtn.ImageAlign = ContentAlignment.MiddleLeft;
                currbtn.TextAlign = ContentAlignment.MiddleLeft;
                currbtn.ForeColor = Color.White;
                currbtn.IconColor = Color.White;
                currbtn.Font = new Font(currbtn.Font, System.Drawing.FontStyle.Regular);

                borderleftbtn.Visible = false;

            }
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColor.color1);
            openChildForm(new fBooking());


        }

       
        private void btn_exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Minimized ? FormWindowState.Maximized : FormWindowState.Minimized;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColor.color1);
            
            openChildForm(new fMenu());
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColor.color1);
            openChildForm(new fStaff());
        }


        private void btn_admin_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColor.color1);
            openChildForm(new fBill());
        }


        private void icon_logo_Click(object sender, EventArgs e)
        {
            if(currbtn != null)
            {
                Disablebtn(currbtn);

                openChildForm(new fHome());

                lb_control.Text = "";
                icon_control.IconChar = IconChar.None;
            }
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender , RGBColor.color1);
            openChildForm(new fFood());
        }

        private void btn_staff_EnabledChanged(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;

            btn.ForeColor = Color.Red;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
