using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace luu_text_file
{
    public partial class form_tim_kiem : Form
    {
        public form_tim_kiem()
        {
            InitializeComponent();
        }
        public SinhVien sv = new SinhVien();
        private void button_tim_kiem_Click(object sender, EventArgs e)
        {

            sv.mssv = int.Parse(textbox_mssv_timkiem.Text);
            try
            {
                string path = Application.StartupPath + "\\csdl.txt";
                bool check = LuuFiletext.TimDuLieu(sv, path);
                if (check == true)
                {
                    label_output_hoten.Text = sv.ten;
                    label_output_ngaysinh.Text = sv.ngaysinh.ToString();
                    label_output_dtb.Text = sv.dtb.ToString();
                    if(MessageBox.Show("tim kiem thanh cong. Ban co muon cap nhat", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Form3 f = new Form3(this);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
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

        private void textbox_mssv_timkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
