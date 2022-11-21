using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luu_text_file
{
    public class SinhVien
    {
        public int mssv { get; set; }
        public string ten { get; set; }
        public DateTime ngaysinh {get; set; }
        public float dtb { get; set; }
        public override string ToString()
        {
            return mssv + " " + ten + " " + ngaysinh.ToString("dd/mm/yyyy")+ " " +dtb;

        }
        public bool so_sanh_mssv(SinhVien sv)
        {
            if (sv.mssv != this.mssv)
                return false;
            else
                return true;
                   
        }
    }
}
