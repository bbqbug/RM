using RM.Views.Admin.Food;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.DAL
{
    public class FoodPresenter
    {
        private static FoodPresenter instance;

        public static FoodPresenter Instance 
        {
            get
            {
                if (instance == null)
                    instance = new FoodPresenter();
                return instance;
            }
            private set => instance = value;
        }

        private FoodPresenter() { }



        public List<FoodCard> GetListFood(string keysearch = null)
        {
            List<FoodCard> list = new List<FoodCard>();

            if (keysearch != null)
            {
                string sql = "Select * from MonAn where MA_Ten like '%" + keysearch + "%'";

                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

                foreach (DataRow row in data.Rows)
                {

                    FoodCard card = new FoodCard(row);
                    list.Add(card);
                }

            }
            else
            {
                
                string sql = "Select * from MonAn";
                DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

                foreach (DataRow row in data.Rows)
                {

                    FoodCard card = new FoodCard(row);
                    list.Add(card);
                }
            }




            return list;
        }

        public List<FoodCard> loadfood(int n)
        {
            List<FoodCard> list = new List<FoodCard>();
            string sql = "";
            switch(n)
            {
                case 1:
                    {
                         sql = "Select * from MonAn Where MA_DanhMuc = N'Khai Vị'";
                    }
                    break;
                case 2:
                    {
                         sql = "Select * from MonAn Where MA_DanhMuc = N'Món Chính'";
                    }
                    break;
                case 3:
                    {
                         sql = "Select * from MonAn Where MA_DanhMuc = N'Tráng Miệng'";
                    }
                    break;
            }

            DataTable data = DataProvider.Instance.ExcuteQuerry(sql);

            foreach (DataRow row in data.Rows)
            {

                FoodCard card = new FoodCard(row);
                list.Add(card);
            }



            return list;
        }



    }
}
