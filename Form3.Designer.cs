using System.Runtime.CompilerServices;

namespace luu_text_file
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_Hoten_CapNhat = new System.Windows.Forms.TextBox();
            this.TextBox_dtb_CapNhat = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgaySinh_CapNhat = new System.Windows.Forms.DateTimePicker();
            this.button_CapNhat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mssv_CapNhat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "cập nhật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 39);
            this.label3.TabIndex = 2;
            this.label3.Tag = "";
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 39);
            this.label4.TabIndex = 3;
            this.label4.Tag = "";
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 39);
            this.label5.TabIndex = 4;
            this.label5.Tag = "";
            this.label5.Text = "Điểm trung bình:";
            // 
            // textbox_Hoten_CapNhat
            // 
            this.textbox_Hoten_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Hoten_CapNhat.Location = new System.Drawing.Point(346, 131);
            this.textbox_Hoten_CapNhat.Name = "textbox_Hoten_CapNhat";
            this.textbox_Hoten_CapNhat.Size = new System.Drawing.Size(228, 38);
            this.textbox_Hoten_CapNhat.TabIndex = 5;
            this.textbox_Hoten_CapNhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Hoten_CapNhat_KeyPress);
            // 
            // TextBox_dtb_CapNhat
            // 
            this.TextBox_dtb_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_dtb_CapNhat.Location = new System.Drawing.Point(346, 273);
            this.TextBox_dtb_CapNhat.Name = "TextBox_dtb_CapNhat";
            this.TextBox_dtb_CapNhat.Size = new System.Drawing.Size(228, 38);
            this.TextBox_dtb_CapNhat.TabIndex = 6;
            this.TextBox_dtb_CapNhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_dtb_CapNhat_KeyPress);
            // 
            // dateTimePicker_NgaySinh_CapNhat
            // 
            this.dateTimePicker_NgaySinh_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgaySinh_CapNhat.Location = new System.Drawing.Point(346, 205);
            this.dateTimePicker_NgaySinh_CapNhat.Name = "dateTimePicker_NgaySinh_CapNhat";
            this.dateTimePicker_NgaySinh_CapNhat.Size = new System.Drawing.Size(400, 31);
            this.dateTimePicker_NgaySinh_CapNhat.TabIndex = 7;
            // 
            // button_CapNhat
            // 
            this.button_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CapNhat.Location = new System.Drawing.Point(645, 303);
            this.button_CapNhat.Name = "button_CapNhat";
            this.button_CapNhat.Size = new System.Drawing.Size(133, 43);
            this.button_CapNhat.TabIndex = 8;
            this.button_CapNhat.Text = "cập nhật";
            this.button_CapNhat.UseVisualStyleBackColor = true;
            this.button_CapNhat.Click += new System.EventHandler(this.button_CapNhat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 39);
            this.label2.TabIndex = 9;
            this.label2.Tag = "";
            this.label2.Text = "MSSV:";
            // 
            // textBox_mssv_CapNhat
            // 
            this.textBox_mssv_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mssv_CapNhat.Location = new System.Drawing.Point(346, 61);
            this.textBox_mssv_CapNhat.Name = "textBox_mssv_CapNhat";
            this.textBox_mssv_CapNhat.Size = new System.Drawing.Size(260, 38);
            this.textBox_mssv_CapNhat.TabIndex = 10;
            this.textBox_mssv_CapNhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_mssv_CapNhat_KeyPress);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 354);
            this.Controls.Add(this.textBox_mssv_CapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_CapNhat);
            this.Controls.Add(this.dateTimePicker_NgaySinh_CapNhat);
            this.Controls.Add(this.TextBox_dtb_CapNhat);
            this.Controls.Add(this.textbox_Hoten_CapNhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_Hoten_CapNhat;
        private System.Windows.Forms.TextBox TextBox_dtb_CapNhat;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh_CapNhat;
        private System.Windows.Forms.Button button_CapNhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mssv_CapNhat;
    }
}