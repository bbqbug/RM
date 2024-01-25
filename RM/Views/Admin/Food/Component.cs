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

namespace RM.Views.Admin.Food
{
    public partial class Component : UserControl
    {
        private int idnl;
        private int quantity;
        private string dvt;
        public Component()
        {
            InitializeComponent();
            load();
        }

        [Category("Component")]
        public int Idnl 
        {
            get => idnl;
            set { idnl = value; comboBox1.SelectedValue = value; } 
        }

        [Category("Component")]
        public int Quantity 
        { 
            get => quantity;
            set { quantity = value; numericUpDown1.Value = value; }
        }

        [Category("Component")]
        public string Dvt 
        {
            get => dvt; 
            set { dvt = value; lb_dvt.Text = value; }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Idnl = (int)comboBox1.SelectedValue;
                Dvt = DataProvider.Instance.ExcuteQuerry("Select NL_DonViTinh from NguyenLieu where NL_Ma =" + Idnl).Rows[0][0].ToString();
            }
               
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)numericUpDown1.Value;
        }

        void load()
        {
            string sql = "Select NL_Ma, NL_Ten from NguyenLieu";
            DataTable dt = DataProvider.Instance.ExcuteQuerry(sql);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "NL_Ten";
            comboBox1.ValueMember = "NL_Ma";
            comboBox1 .SelectedIndex = 0;
        }
    }
}
