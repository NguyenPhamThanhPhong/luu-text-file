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

namespace luu_text_file
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            List<SinhVien> dssv;
            string path = Application.StartupPath + "\\csdl.txt";

            if (LuuFiletext.Load_Du_Lieu_Len(out dssv,path))
            {
                foreach(SinhVien sv in dssv.ToList())
                {
                    if (sv.mssv == int.Parse(textBox_mssv_CapNhat.Text))
                    {
                        dssv.Remove(sv);
                    }
                }
            }
            else
            {
                MessageBox.Show("khong tim thay");
            }
            
            try
            {
                SinhVien sv1 = new SinhVien();
                sv1.mssv = int.Parse(textBox_mssv_CapNhat.Text);
                sv1.ten = textbox_Hoten_CapNhat.Text;
                sv1.ngaysinh = dateTimePicker_NgaySinh_CapNhat.Value;
                sv1.dtb = float.Parse(TextBox_dtb_CapNhat.Text);
                dssv.Add(sv1);
                bool check = LuuFiletext.UpdateDuLieu(dssv, path);
                if (check == true)
                {
                    MessageBox.Show("da update du lieu");
                }
                else
                {
                    MessageBox.Show("khong tim thay");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_mssv_CapNhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbox_Hoten_CapNhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_dtb_CapNhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chi cho phep nhap vao so float:
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
