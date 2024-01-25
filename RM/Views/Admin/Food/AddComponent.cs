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
    public partial class AddComponent : UserControl
    {
        private string tennl;
        private string dvt;
        private int quantity;

        public AddComponent()
        {
            InitializeComponent();
        }
        public string Tennl
        { 
            get => tennl; 
            set { tennl = value; txt_name.Text = value; }
        }

        public string Dvt 
        { 
            get => dvt; 
            set { dvt = value; txt_dvt.Text = value; }
        }
        public int Quantity 
        { 
            get => quantity; 
            set { quantity = value; num_qtt.Value = value; }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            tennl = txt_name.Text;
        }

        private void txt_dvt_TextChanged(object sender, EventArgs e)
        {
            dvt = txt_dvt.Text;
        }

        private void num_qtt_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)num_qtt.Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
