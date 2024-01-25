using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views.Admin.Menu
{
    public partial class CardMenu : UserControl
    {
        private string menuName;
        private string food1;
        private string food2;
        private string food3;
        private string food4;
        private string food5;
        private string price;
        public CardMenu()
        {
            InitializeComponent();
        }
        [Category("CardMenu")]
        public string MenuName
        {
            get => menuName;
            set { menuName = value; label1.Text = value; }
        }

        [Category("CardMenu")]
        public string Food1
        {
            get => food1;
            set  { food1 = value; label2.Text = value; }
            }

        [Category("CardMenu")]
        public string Food2
        {
            get => food2;
            set { food2 = value; label3.Text = value; }
        }

        [Category("CardMenu")]
        public string Food3
        {
            get => food3;
            set { food3 = value; label4.Text = value; }
        }

        [Category("CardMenu")]
        public string Food4
        {
            get => food4;
            set { food4 = value; label5.Text = value; }
        }

        [Category("CardMenu")]
        public string Food5
        {
            get => food5;
            set { food5 = value; label6.Text = value; }
        }

        [Category("CardMenu")]
        public string Price
        {
            get => price;
            set { price = value; label8.Text = value; }
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void CardMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
