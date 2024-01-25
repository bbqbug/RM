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
    public partial class FoodCard : UserControl
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory +"\\Image\\";

        private string urlimage;
        private string name;
        private string price;
        public FoodCard()
        {
            InitializeComponent();
        }

        [Category("FoodCard")]
        public string Urlimage
        {
            get => urlimage;
            set { urlimage = value; pictureBox1.Image = new Bitmap(Path.Combine(path, value)); }/*pictureBox1;*/
        }

        [Category("FoodCard")]
        public string NameFood
        {
            get => name;
            set { name = value; lb_name.Text = value; }
        }

        [Category("FoodCard")]
        public string Price
        {
            get => price;
            set { price = value; lb_price.Text = value; }
        }

        public FoodCard(DataRow row)
        {
            InitializeComponent();
            //MessageBox.Show((row["MA_HinhAnh"].ToString() == "").ToString());
            this.Urlimage = row["MA_HinhAnh"].ToString() == "" ?  "default_img.png" : row["MA_HinhAnh"].ToString();
            this.NameFood = row["MA_Ten"].ToString();
            this.Price = row["Ma_Gia"].ToString();
            this.Tag = row["MA_Ma"].ToString();


        }

    }
}
