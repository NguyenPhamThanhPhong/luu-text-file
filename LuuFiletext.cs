using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace luu_text_file
{
    internal class LuuFiletext
    {
        public static bool LuuFile(List<SinhVien> dssv , string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8);
                
                foreach(SinhVien sv in dssv)
                {
                    string info = sv.mssv.ToString() + ";" + sv.ten + ";" + sv.ngaysinh.ToString() + ";" + sv.dtb.ToString();
                    sw.WriteLine(info);
                   
                }
                sw.Close();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static bool TimDuLieu(SinhVien sv, string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream )
                {
                    string line = sr.ReadLine();
                    string[] arr = line.Split(';');
                    if (arr.Length == 4)
                    {
                        if (sv.mssv == int.Parse(arr[0].Trim()))
                        {
                            sv.ten = arr[1].Trim();
                            sv.ngaysinh = DateTime.Parse(arr[2].Trim());
                            sv.dtb = float.Parse(arr[3].Trim());
                        }
                    }
                }
                sr.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Load_Du_Lieu_Len(out List<SinhVien> dssv, string path)
        {
            try
            {
                dssv = new List<SinhVien>();
                StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    SinhVien sv = new SinhVien();
                    string line = sr.ReadLine();
                    string[] arr = line.Split(';');
                    sv.mssv = int.Parse(arr[0].Trim());
                    sv.ten = arr[1].Trim();
                    sv.ngaysinh = DateTime.Parse(arr[2].Trim());
                    sv.dtb = float.Parse(arr[3].Trim());
                    dssv.Add(sv);
                }
                sr.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool UpdateDuLieu(List<SinhVien> dssv, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);

                foreach (SinhVien sv in dssv.ToList())
                {
                    string info = sv.mssv.ToString() + ";" + sv.ten + ";" + sv.ngaysinh.ToString() + ";" + sv.dtb.ToString();
                    sw.WriteLine(info);

                }
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
