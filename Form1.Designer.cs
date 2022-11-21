namespace luu_text_file
{
    partial class Form1
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
            this.textbox_mssv_nhap = new System.Windows.Forms.TextBox();
            this.textbox_hoten_nhap = new System.Windows.Forms.TextBox();
            this.textbox_dtb_nhap = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngaysinh_nhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_nhap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.debug_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox_mssv_nhap
            // 
            this.textbox_mssv_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_mssv_nhap.Location = new System.Drawing.Point(304, 72);
            this.textbox_mssv_nhap.Multiline = true;
            this.textbox_mssv_nhap.Name = "textbox_mssv_nhap";
            this.textbox_mssv_nhap.Size = new System.Drawing.Size(262, 43);
            this.textbox_mssv_nhap.TabIndex = 0;
            this.textbox_mssv_nhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_mssv_nhap_KeyPress);
            // 
            // textbox_hoten_nhap
            // 
            this.textbox_hoten_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_hoten_nhap.Location = new System.Drawing.Point(304, 148);
            this.textbox_hoten_nhap.Multiline = true;
            this.textbox_hoten_nhap.Name = "textbox_hoten_nhap";
            this.textbox_hoten_nhap.Size = new System.Drawing.Size(262, 43);
            this.textbox_hoten_nhap.TabIndex = 3;
            this.textbox_hoten_nhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_hoten_nhap_KeyPress);
            // 
            // textbox_dtb_nhap
            // 
            this.textbox_dtb_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_dtb_nhap.Location = new System.Drawing.Point(304, 294);
            this.textbox_dtb_nhap.Multiline = true;
            this.textbox_dtb_nhap.Name = "textbox_dtb_nhap";
            this.textbox_dtb_nhap.Size = new System.Drawing.Size(262, 43);
            this.textbox_dtb_nhap.TabIndex = 4;
            this.textbox_dtb_nhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_dtb_nhap_KeyPress);
            // 
            // dateTimePicker_ngaysinh_nhap
            // 
            this.dateTimePicker_ngaysinh_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngaysinh_nhap.Location = new System.Drawing.Point(304, 224);
            this.dateTimePicker_ngaysinh_nhap.Name = "dateTimePicker_ngaysinh_nhap";
            this.dateTimePicker_ngaysinh_nhap.Size = new System.Drawing.Size(360, 31);
            this.dateTimePicker_ngaysinh_nhap.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "MSSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điểm trung bình:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(666, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Đi tới tìm kiếm:";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_nhap
            // 
            this.Button_nhap.Location = new System.Drawing.Point(619, 357);
            this.Button_nhap.Name = "Button_nhap";
            this.Button_nhap.Size = new System.Drawing.Size(129, 58);
            this.Button_nhap.TabIndex = 11;
            this.Button_nhap.Text = "Nhập";
            this.Button_nhap.UseVisualStyleBackColor = true;
            this.Button_nhap.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập dữ liệu mới:";
            // 
            // debug_text
            // 
            this.debug_text.AutoSize = true;
            this.debug_text.Location = new System.Drawing.Point(699, 166);
            this.debug_text.Name = "debug_text";
            this.debug_text.Size = new System.Drawing.Size(0, 13);
            this.debug_text.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 427);
            this.Controls.Add(this.debug_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_nhap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_ngaysinh_nhap);
            this.Controls.Add(this.textbox_dtb_nhap);
            this.Controls.Add(this.textbox_hoten_nhap);
            this.Controls.Add(this.textbox_mssv_nhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_mssv_nhap;
        private System.Windows.Forms.TextBox textbox_hoten_nhap;
        private System.Windows.Forms.TextBox textbox_dtb_nhap;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh_nhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_nhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label debug_text;
    }
}

