using RM.Views.Admin.Menu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.DAL
{
    public class MenuPresenter
    {

        //singleton
        private static MenuPresenter instance;

        public static MenuPresenter Instance 
        { 
            get { if (instance == null) instance = new MenuPresenter(); return instance; }
            private set => instance = value; 
        }
        private MenuPresenter() { }

        //get list menu
        public List<CardMenu> GetListCardMenu(string keysearch = null)
        {

            List<CardMenu> list = new List<CardMenu>();

            if (keysearch != null)
            {
                string sql = "select distinct TD_Ma, TD_Ten from ThucDon, ChiTietThucDon, MonAn where ThucDon.TD_Ma = ChiTietThucDon.CTTD_MaTD and ChiTietThucDon.CTTD_MaMA = MonAn.MA_Ma and MonAn.MA_Ten like  N'%"+keysearch+"%'";

                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

                foreach (DataRow row in data.Rows)
                {
                    DataTable menu = DataProvider.Instance.ExcuteQuerry("Execute GetDetailMenuByID @id", new object[] { row["TD_Ma"].ToString() });
                    CardMenu item = new CardMenu();
                    item.MenuName = row["TD_Ten"].ToString();
                    //MessageBox.Show(row["TD_Ten"].ToString());
                    item.Food1 = menu.Rows[0]["MA_Ten"].ToString();
                    item.Food2 = menu.Rows[1]["MA_Ten"].ToString();
                    item.Food3 = menu.Rows[2]["MA_Ten"].ToString();
                    item.Food4 = menu.Rows[3]["MA_Ten"].ToString();
                    item.Food5 = menu.Rows[4]["MA_Ten"].ToString();
                    int price = (Convert.ToInt32(menu.Rows[0]["MA_Gia"].ToString()) + Convert.ToInt32(menu.Rows[1]["MA_Gia"].ToString()) + Convert.ToInt32(menu.Rows[2]["MA_Gia"].ToString()) + Convert.ToInt32(menu.Rows[3]["MA_Gia"].ToString()) + Convert.ToInt32(menu.Rows[4]["MA_Gia"].ToString()));
                    item.Price = (price + price / 5).ToString();
                    item.AutoSize = true;
                    item.BackColor = Color.FromArgb(152, 190, 198);
                    item.ForeColor = Color.FromArgb(74, 38, 171);

                    //tag id menu
                    item.Tag = row["TD_Ma"].ToString();
                    list.Add(item);
                }

            }
            else
            {
                string sql = "Execute GetListMenu";

                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

                foreach (DataRow row in data.Rows)
                {
                    DataTable menu = DataProvider.Instance.ExcuteQuerry("Execute GetDetailMenuByID @id", new object[] { row["TD_Ma"].ToString() });
                    CardMenu item = new CardMenu();
                    item.MenuName = row["TD_Ten"].ToString();
                    item.Food1 = menu.Rows[0]["MA_Ten"].ToString();
                    item.Food2 = menu.Rows[1]["MA_Ten"].ToString();
                    item.Food3 = menu.Rows[2]["MA_Ten"].ToString();
                    item.Food4 = menu.Rows[3]["MA_Ten"].ToString();
                    item.Food5 = menu.Rows[4]["MA_Ten"].ToString();
                    int price = (Convert.ToInt32(menu.Rows[0]["MA_Gia"].ToString()) + Convert.ToInt32(menu.Rows[1]["MA_Gia"].ToString()) + Convert.ToInt32(menu.Rows[2]["MA_Gia"].ToString()) + Convert.ToInt32(menu.Rows[3]["MA_Gia"].ToString()) + Convert.ToInt32(menu.Rows[4]["MA_Gia"].ToString()));
                    item.Price = (price + price / 5).ToString();
                    item.AutoSize = true;
                    item.BackColor = Color.FromArgb(152, 190, 198);
                    item.ForeColor = Color.FromArgb(74, 38, 171);

                    //tag id menu
                    item.Tag = row["TD_Ma"].ToString();
                    list.Add(item);
                }

            }
           
            return list;
        }
    }
}
