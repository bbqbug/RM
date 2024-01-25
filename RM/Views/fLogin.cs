using FontAwesome.Sharp;
using RM.DAL;
using RM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RM
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            DataTable data = DataProvider.Instance.ExcuteQuerry("Select * from NhanVien where NV_SDT = @username and NV_MatKhau = @pwd ", new object[] { txt_username.Text, txt_pwd.Text });

            if (data.Rows.Count > 0)
            {
                fMain fm = new fMain(Convert.ToInt32(data.Rows[0]["NV_Ma"].ToString()));
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng nhập lại!!!");
            }



        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
