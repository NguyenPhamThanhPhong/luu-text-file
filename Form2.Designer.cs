namespace luu_text_file
{
    partial class form_tim_kiem
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
            this.label = new System.Windows.Forms.Label();
            this.textbox_mssv_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_tim_kiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_output_hoten = new System.Windows.Forms.Label();
            this.label_output_ngaysinh = new System.Windows.Forms.Label();
            this.label_output_dtb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(31, 71);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 25);
            this.label.TabIndex = 1;
            this.label.Text = "MSSV";
            // 
            // textbox_mssv_timkiem
            // 
            this.textbox_mssv_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_mssv_timkiem.Location = new System.Drawing.Point(132, 61);
            this.textbox_mssv_timkiem.Name = "textbox_mssv_timkiem";
            this.textbox_mssv_timkiem.Size = new System.Drawing.Size(299, 40);
            this.textbox_mssv_timkiem.TabIndex = 2;
            this.textbox_mssv_timkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_mssv_timkiem_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "tìm kiếm";
            // 
            // button_tim_kiem
            // 
            this.button_tim_kiem.Location = new System.Drawing.Point(574, 61);
            this.button_tim_kiem.Name = "button_tim_kiem";
            this.button_tim_kiem.Size = new System.Drawing.Size(163, 40);
            this.button_tim_kiem.TabIndex = 4;
            this.button_tim_kiem.Text = "tim kiem";
            this.button_tim_kiem.UseVisualStyleBackColor = true;
            this.button_tim_kiem.Click += new System.EventHandler(this.button_tim_kiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ho ten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ngay sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "dtb:";
            // 
            // label_output_hoten
            // 
            this.label_output_hoten.BackColor = System.Drawing.Color.White;
            this.label_output_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output_hoten.Location = new System.Drawing.Point(195, 145);
            this.label_output_hoten.Name = "label_output_hoten";
            this.label_output_hoten.Size = new System.Drawing.Size(236, 31);
            this.label_output_hoten.TabIndex = 8;
            // 
            // label_output_ngaysinh
            // 
            this.label_output_ngaysinh.BackColor = System.Drawing.Color.White;
            this.label_output_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output_ngaysinh.Location = new System.Drawing.Point(195, 208);
            this.label_output_ngaysinh.Name = "label_output_ngaysinh";
            this.label_output_ngaysinh.Size = new System.Drawing.Size(236, 31);
            this.label_output_ngaysinh.TabIndex = 9;
            // 
            // label_output_dtb
            // 
            this.label_output_dtb.BackColor = System.Drawing.Color.White;
            this.label_output_dtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output_dtb.Location = new System.Drawing.Point(195, 269);
            this.label_output_dtb.Name = "label_output_dtb";
            this.label_output_dtb.Size = new System.Drawing.Size(236, 31);
            this.label_output_dtb.TabIndex = 10;
            // 
            // form_tim_kiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_output_dtb);
            this.Controls.Add(this.label_output_ngaysinh);
            this.Controls.Add(this.label_output_hoten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_tim_kiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_mssv_timkiem);
            this.Controls.Add(this.label);
            this.Name = "form_tim_kiem";
            this.Text = "Form tìm kiếm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textbox_mssv_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_tim_kiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_output_hoten;
        private System.Windows.Forms.Label label_output_ngaysinh;
        private System.Windows.Forms.Label label_output_dtb;
    }
}