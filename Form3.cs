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
        form_tim_kiem FF;
        public Form3(form_tim_kiem ff)
        {
            InitializeComponent();
            this.FF = ff;
        }
        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            string path = Application.StartupPath + "\\csdl.txt";

            if (LuuFiletext.Load_Du_Lieu_Len(out dssv, path))
            {
                foreach (SinhVien sv1 in dssv.ToList())
                {
                    if (this.FF.sv.mssv == sv1.mssv)
                    {
                        sv1.mssv = int.Parse(textBox_mssv_CapNhat.Text);
                        sv1.ten = textbox_Hoten_CapNhat.Text.Trim();
                        sv1.ngaysinh = dateTimePicker_NgaySinh_CapNhat.Value;
                        sv1.dtb = float.Parse(TextBox_dtb_CapNhat.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("khong tim thay");
            }

            try
            {
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
