using RM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views.Admin.Bill
{
    public partial class AddMenu : UserControl
    {
        private int menu;
        private int quantity;
        public AddMenu()
        {
            InitializeComponent();
            load();
        }

        public int Menu 
        { 
            get => menu;
            set { menu = value; cbb_menu.SelectedValue = menu; }
        }
        public int Quantity 
        { 
            get => quantity;
            set { quantity = value; numericUpDown1.Value = quantity; }
        }

        void load()
        {
            cbb_menu.DataSource = DataProvider.Instance.ExcuteQuerry("select TD_Ma, TD_Ten from ThucDon where TD_TrangThai = 1");
            cbb_menu.DisplayMember = "TD_Ten";
            cbb_menu.ValueMember = "TD_Ma";
        }

        private void cbb_menu_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbb_menu.SelectedValue.ToString() != "System.Data.DataRowView")
                menu = Convert.ToInt32(cbb_menu.SelectedValue);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
