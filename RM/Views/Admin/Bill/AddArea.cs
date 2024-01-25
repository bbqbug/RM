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
    public partial class AddArea : UserControl
    {
        private string id;
        private int quantity;

        public AddArea()
        {
            InitializeComponent();
            Load();
        }

        public string Id 
        { 
            get => comboBox1.SelectedValue.ToString();
            set { id = value; comboBox1.SelectedValue = id; }
        }
        public int Quantity 
        { 
            get => quantity;
            set { quantity = value; label1.Text = Quantity.ToString(); }
        }

        void Load()
        {
            comboBox1.DataSource = DataProvider.Instance.ExcuteQuerry("Select KV_Ma, KV_Ten from KhuVuc");
            comboBox1.DisplayMember = "KV_Ten";
            comboBox1.ValueMember = "KV_Ma";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                label1.Text = DataProvider.Instance.ExcuteQuerry("select KV_SoLuongKhach from KhuVuc where KV_Ma = '" + comboBox1.SelectedValue.ToString() + "'").Rows[0][0].ToString();
                quantity = Convert.ToInt32(label1.Text);
                id = comboBox1.SelectedValue.ToString();
                //MessageBox.Show(id);
            }
                
        }
    }
}
