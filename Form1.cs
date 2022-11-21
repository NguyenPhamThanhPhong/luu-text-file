using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luu_text_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            SinhVien sv = new SinhVien();
            sv.mssv = int.Parse(textbox_mssv_nhap.Text);
            sv.ten = textbox_hoten_nhap.Text;
            sv.ngaysinh = dateTimePicker_ngaysinh_nhap.Value;
            //debug_text.Text = dateTimePicker_ngaysinh_nhap.Value.ToString();
            sv.dtb = float.Parse(textbox_dtb_nhap.Text);
            dssv.Add(sv);
            MessageBox.Show(sv.ToString());
            try
            {
                string path = Application.StartupPath + "\\csdl.txt";
                bool check = LuuFiletext.LuuFile(dssv, path);
                if(check == true)
                {
                    MessageBox.Show("thêm mới thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_tim_kiem fTimKiem = new form_tim_kiem();
            fTimKiem.ShowDialog();
            this.Show();
        }

        private void textbox_mssv_nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbox_dtb_nhap_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textbox_hoten_nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
