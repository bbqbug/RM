using OfficeOpenXml;
using OfficeOpenXml.Style;
using RM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Windows.Resources;
using MessageBox = System.Windows.MessageBox;

namespace RM.Export
{
    public class ExportExcelFile
    {
        private static ExportExcelFile instance;

        public static ExportExcelFile Instance 
        {
            get
            {
                if(instance == null)
                    instance = new ExportExcelFile();
                return instance;
            }
            private set => instance = value; 
        }

        private ExportExcelFile() { }


        //make salary

        public async void MakeSalary(DateTime daystart, DateTime dayend)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            var file = new FileInfo("D:\\test\\Luong\\Luong_" + daystart.ToString("dd-MM-yyyy") + "_" + dayend.ToString("dd-MM-yyyy") + ".xlsx");

            string[,] people = GetSetupDataSalary(daystart.ToString("yyyy-MM-dd"), dayend.ToString("yyyy-MM-dd"));

            await SaveSalary(people, file, daystart.ToString("yyyy-MM-dd"), dayend.ToString("yyyy-MM-dd"));


            Thread.Sleep(1000);
            Process.Start(file.FullName);
        }

        private static string[,] GetSetupDataSalary(string daystart, string dayend)
        {
            DataTable listnv = DataProvider.Instance.ExcuteQuerry("Select NhanVien.NV_Ma, NhanVien.NV_Ho , NhanVien.NV_Ten, NhanVien.NV_Gioitinh, NhanVien.NV_SDT, BoPhan.BP_Ten, ChucVu.CV_Ten , BoPhan.BP_Luong, ChucVu.CV_HeSo from NhanVien, ChucVu, BoPhan where NhanVien.NV_MaBP = BoPhan.BP_Ma and NhanVien.NV_MaCV = ChucVu.CV_Ma");


            int hang = listnv.Rows.Count;
            int cot = listnv.Columns.Count + 2;


            //MessageBox.Show(" " + hang + cot);


            string[,] data = new string[hang,cot];

            string getsum = "Select * from NhanVien, PhuTrachTiec, PhieuDatTiec where NhanVien.NV_Ma = PhuTrachTiec.PTT_MaNV and PhuTrachTiec.PTT_MaPDT = PhieuDatTiec.PDT_Ma and NhanVien.NV_Ma = @manv and PhieuDatTiec.PDT_ThoiGian > '"+daystart+"'  and PhieuDatTiec.PDT_ThoiGian < '"+dayend+"'";

            string check = "";
            for (int i = 0; i  <hang ; i++ ) 
            {
                for(int j = 0; j < cot; j++)
                {
                    
                    int sum = DataProvider.Instance.ExcuteQuerry(getsum, new object[] { Convert.ToInt32(listnv.Rows[i]["NV_Ma"].ToString()) }).Rows.Count;
                    if (j == cot-1)
                    {
                        Double heso = Convert.ToDouble(listnv.Rows[i]["CV_HeSo"].ToString());
                        int luong = Convert.ToInt32(listnv.Rows[i]["BP_Luong"].ToString());

                        Double total = sum * heso * luong;

                        check += " " + total;

                        data[i, j] = total.ToString();

                    }
                    else
                    {
                        if(j == cot-2)
                            data[i, j] = sum.ToString();
                        else
                            data[i, j] = listnv.Rows[i][j].ToString();
                    }
                        
                }

            }

           //MessageBox.Show(check);


            return data;
        }

        private static async Task SaveSalary(string[,] data, FileInfo file, string daystart, string dayend)
        {
            DeleteIfExists(file);

            //tao ws

            using(var package = new ExcelPackage(file))
            {
                var ws = package.Workbook.Worksheets.Add("Lương " + daystart + "__" + dayend);

                int hang = data.GetLength(0);
                int cot = data.GetLength(1);

                ws.Cells[1, 1].Value = "Mã Nhân Viên";
                ws.Cells[1, 2].Value = "Họ Nhân Viên";
                ws.Cells[1, 3].Value = "Tên Nhân Viên";
                ws.Cells[1, 4].Value = "Giới Tính";
                ws.Cells[1, 5].Value = "Số Điện Thoại";
                ws.Cells[1, 6].Value = "Bộ Phận";
                ws.Cells[1, 7].Value = "Chức Vụ";
                ws.Cells[1, 8].Value = "Lương Cơ Bản";
                ws.Cells[1, 9].Value = "Hệ Số";
                ws.Cells[1, 10].Value = "Số Tiệc Đã Làm";
                ws.Cells[1,11].Value = "Lương Từ " + daystart +  "__"+ dayend;

                Color color = Color.FromArgb(108, 126, 225);
                Color colorcheck = Color.FromArgb(78, 176, 155);


                ws.Row(1).Style.Fill.PatternType = ExcelFillStyle.LightGray;
                ws.Row(1).Style.Fill.SetBackground(color);
                ws.Row(1).Style.Font.Color.SetColor(Color.White);
                ws.Row(1).Style.Font.Size = 18;


                int rowstart = 2;


                for(int i = rowstart; i<= hang; i++)
                {
                    for(int j = 1; j <= cot; j++)
                    {
                        ws.Cells[i, j].Value = data[i - 2, j-1];
                        ws.Column(j).AutoFit();

                    }

                    
                }

                await package.SaveAsync();

            }


        }



        //lich lam viec

        public async void ScheduleWork(DateTime daystart, DateTime dayend)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            var file = new FileInfo("D:\\test\\LLV\\Lich_Lam_Viec_"+daystart.ToString("dd-MM-yyyy")+"_"+dayend.ToString("dd-MM-yyyy")+".xlsx");

            string[,] people = GetSetupDataLLV(daystart.ToString("yyyy-MM-dd"), dayend.ToString("yyyy-MM-dd"));

            await SaveLLV(people, file, daystart.ToString("yyyy-MM-dd"), dayend.ToString("yyyy-MM-dd"));


            Thread.Sleep(1000);
            Process.Start(file.FullName);
        }

        private static string[,] GetSetupDataLLV(string daystart, string dayend)
        {
            DataTable listnv = DataProvider.Instance.ExcuteQuerry("Select NhanVien.NV_Ma, NhanVien.NV_Ho , NhanVien.NV_Ten, NhanVien.NV_Gioitinh, NhanVien.NV_SDT, BoPhan.BP_Ten, ChucVu.CV_Ten from NhanVien, ChucVu, BoPhan where NhanVien.NV_MaBP = BoPhan.BP_Ma and NhanVien.NV_MaCV = ChucVu.CV_Ma");


            DataTable listpdt = DataProvider.Instance.ExcuteQuerry("select PhieuDatTiec.PDT_Ma, PhuTrachTiec.PTT_MaNV from PhieuDatTiec, PhuTrachTiec where PhieuDatTiec.PDT_Ma = PhuTrachTiec.PTT_MaPDT and PhieuDatTiec.PDT_ThoiGian > '"+daystart+"'  and PhieuDatTiec.PDT_ThoiGian < '"+dayend+"'");

            //MessageBox.Show("" + listpdt.Rows.Count);
            //MessageBox.Show("" + listpdt.Rows[0][0].ToString());

            Dictionary<string, List<string>> mappdt = new Dictionary<string, List<string>>();
            string nv = "";
            string pdt = "";
            foreach(DataRow row in listpdt.Rows) {

                pdt = row["PDT_Ma"].ToString();
                nv = row["PTT_MaNV"].ToString();

                if (mappdt.ContainsKey(pdt))
                {
                    //MessageBox.Show(nv + " " + pdt);
                    mappdt[pdt].Add(nv);
                }
                else
                {
                    mappdt[pdt] = new List<string>();

                    mappdt[pdt].Add(nv);
                }
            }

            int size = mappdt.Keys.Count;
            //MessageBox.Show("" + size);

            int hang = listnv.Rows.Count;
            int cot = listnv.Columns.Count + size;

            string[,] data = new string[hang, cot];

            //MessageBox.Show("" + hang + cot);
            for ( int i = 0 ; i < hang; i++)
            {
                for(int j = 0 ; j < cot; j++)
                {
                    if(j <= 6)
                    {
                        data[i, j] = listnv.Rows[i][j].ToString();
                    }
                    else
                    {
                        foreach(List<string> map in mappdt.Values)
                        { 
                            if (map.Contains(listnv.Rows[i]["NV_Ma"].ToString()))
                            {
                                data[i, j] = "Có";
                                j++;
                            }
                            else
                            {
                                data[i, j] = "";
                                j++;
                            }    
                        }
                    }     
                }
            }
            return data;
        }


        private static async Task SaveLLV(string[,] data, FileInfo file, string daystart, string dayend)
        {
            DeleteIfExists(file);
            using (var package = new ExcelPackage(file))
            {
                //tao ws
                var ws = package.Workbook.Worksheets.Add("Test");

                int hang = data.GetLength(0);
                int cot = data.GetLength(1);

                DataTable listpdt = DataProvider.Instance.ExcuteQuerry("select distinct PhieuDatTiec.PDT_Ma, PhieuDatTiec.PDT_ThoiGian from PhieuDatTiec, PhuTrachTiec where PhieuDatTiec.PDT_Ma = PhuTrachTiec.PTT_MaPDT and PhieuDatTiec.PDT_ThoiGian > '" + daystart + "'  and PhieuDatTiec.PDT_ThoiGian < '" + dayend + "'");



                
                ws.Cells[1, 1].Value = "Mã Nhân Viên";
                ws.Cells[1, 2].Value = "Họ Nhân Viên";
                ws.Cells[1, 3].Value = "Tên Nhân Viên";
                ws.Cells[1, 4].Value = "Giới Tính";
                ws.Cells[1, 5].Value = "Số Điện Thoại";
                ws.Cells[1, 6].Value = "Bộ Phận";
                ws.Cells[1, 7].Value = "Chức Vụ";

                int col = 8;

                foreach(DataRow row in listpdt.Rows)
                {
                    ws.Cells[1,col].Value = "Tiệc " +row["PDT_Ma"].ToString() + " (" + row["PDT_ThoiGian"] + ")";
                    col++;
                }

                Color color = Color.FromArgb(108, 126, 225);
                Color colorcheck = Color.FromArgb(78, 176, 155);
                

                ws.Row(1).Style.Fill.PatternType = ExcelFillStyle.LightGray;
                ws.Row(1).Style.Fill.SetBackground(color);
                ws.Row(1).Style.Font.Color.SetColor(Color.White);
                ws.Row(1).Style.Font.Size = 18;
                

                int rowstart = 2;

                for (int i = rowstart; i <= hang; i++)
                {
                    for (int j = 1; j <= cot; j++)
                    {
                        ws.Cells[i, j].Value = data[i - 2, j - 1];

                        ws.Cells[i, j].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        ws.Column(j).AutoFit();
                        if(data[i - 2, j - 1] == "Có")
                        {
                            ws.Cells[i,j].Style.Fill.PatternType= ExcelFillStyle.DarkGray;
                            ws.Cells[i,j].Style.Fill.BackgroundColor.SetColor(colorcheck);
                        }
                            
                    }

                }

                await package.SaveAsync();
            }

        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }



        //thong ke doanh thu

        //public async void ThongKe(DateTime daystart, DateTime dayend)
        //{
        //    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        //    var file = new FileInfo("D:\\test\\DoanhThu\\Doanh_Thu_" + daystart.ToString("dd-MM-yyyy") + "_" + dayend.ToString("dd-MM-yyyy") + ".xlsx");

        //    string[,] people = GetSetupDataThongKe(daystart.ToString("yyyy-MM-dd"), dayend.ToString("yyyy-MM-dd"));

        //    await SaveThongKe(people, file, daystart.ToString("yyyy-MM-dd"), dayend.ToString("yyyy-MM-dd"));


        //    Thread.Sleep(1000);
        //    Process.Start(file.FullName);
        //}

        //private static async Task SaveThongKe(string[,] people, FileInfo file, string datestart, string dateend)
        //{
        //    throw new NotImplementedException();
        //}

        //private static string[,] GetSetupDataThongKe(string datestart, string dateend)
        //{
        //    string[,] data = new string[5, 5];




        //    return data;
        //}
    }


}

