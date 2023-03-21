namespace Lab_1
{
    partial class Bai5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_nhapA = new System.Windows.Forms.TextBox();
            this.txt_nhapB = new System.Windows.Forms.TextBox();
            this.grp_Ketqua = new System.Windows.Forms.GroupBox();
            this.txt_Agiaithua = new System.Windows.Forms.TextBox();
            this.txt_Bgiaithua = new System.Windows.Forms.TextBox();
            this.txt_s1 = new System.Windows.Forms.TextBox();
            this.txt_s2 = new System.Windows.Forms.TextBox();
            this.txt_s3 = new System.Windows.Forms.TextBox();
            this.grp_Ketqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÀI 5 NHẬP VÀ TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập B";
            // 
            // btn_tinh
            // 
            this.btn_tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinh.Location = new System.Drawing.Point(31, 126);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(185, 52);
            this.btn_tinh.TabIndex = 3;
            this.btn_tinh.Text = "Tính các giá trị";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(313, 126);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 52);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(506, 126);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(92, 52);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_nhapA
            // 
            this.txt_nhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapA.Location = new System.Drawing.Point(128, 69);
            this.txt_nhapA.Name = "txt_nhapA";
            this.txt_nhapA.Size = new System.Drawing.Size(139, 29);
            this.txt_nhapA.TabIndex = 6;
            // 
            // txt_nhapB
            // 
            this.txt_nhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapB.Location = new System.Drawing.Point(523, 72);
            this.txt_nhapB.Name = "txt_nhapB";
            this.txt_nhapB.Size = new System.Drawing.Size(146, 29);
            this.txt_nhapB.TabIndex = 7;
            // 
            // grp_Ketqua
            // 
            this.grp_Ketqua.Controls.Add(this.txt_s3);
            this.grp_Ketqua.Controls.Add(this.txt_s2);
            this.grp_Ketqua.Controls.Add(this.txt_s1);
            this.grp_Ketqua.Controls.Add(this.txt_Bgiaithua);
            this.grp_Ketqua.Controls.Add(this.txt_Agiaithua);
            this.grp_Ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Ketqua.Location = new System.Drawing.Point(1, 184);
            this.grp_Ketqua.Name = "grp_Ketqua";
            this.grp_Ketqua.Size = new System.Drawing.Size(787, 254);
            this.grp_Ketqua.TabIndex = 8;
            this.grp_Ketqua.TabStop = false;
            this.grp_Ketqua.Text = "Kết quả";
            // 
            // txt_Agiaithua
            // 
            this.txt_Agiaithua.Enabled = false;
            this.txt_Agiaithua.Location = new System.Drawing.Point(21, 40);
            this.txt_Agiaithua.Name = "txt_Agiaithua";
            this.txt_Agiaithua.Size = new System.Drawing.Size(262, 29);
            this.txt_Agiaithua.TabIndex = 0;
            // 
            // txt_Bgiaithua
            // 
            this.txt_Bgiaithua.Enabled = false;
            this.txt_Bgiaithua.Location = new System.Drawing.Point(391, 40);
            this.txt_Bgiaithua.Name = "txt_Bgiaithua";
            this.txt_Bgiaithua.Size = new System.Drawing.Size(337, 29);
            this.txt_Bgiaithua.TabIndex = 1;
            // 
            // txt_s1
            // 
            this.txt_s1.Enabled = false;
            this.txt_s1.Location = new System.Drawing.Point(21, 96);
            this.txt_s1.Name = "txt_s1";
            this.txt_s1.Size = new System.Drawing.Size(354, 29);
            this.txt_s1.TabIndex = 2;
            // 
            // txt_s2
            // 
            this.txt_s2.Enabled = false;
            this.txt_s2.Location = new System.Drawing.Point(21, 149);
            this.txt_s2.Name = "txt_s2";
            this.txt_s2.Size = new System.Drawing.Size(354, 29);
            this.txt_s2.TabIndex = 3;
            // 
            // txt_s3
            // 
            this.txt_s3.Enabled = false;
            this.txt_s3.Location = new System.Drawing.Point(21, 210);
            this.txt_s3.Name = "txt_s3";
            this.txt_s3.Size = new System.Drawing.Size(586, 29);
            this.txt_s3.TabIndex = 4;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_Ketqua);
            this.Controls.Add(this.txt_nhapB);
            this.Controls.Add(this.txt_nhapA);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.grp_Ketqua.ResumeLayout(false);
            this.grp_Ketqua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_nhapA;
        private System.Windows.Forms.TextBox txt_nhapB;
        private System.Windows.Forms.GroupBox grp_Ketqua;
        private System.Windows.Forms.TextBox txt_s3;
        private System.Windows.Forms.TextBox txt_s2;
        private System.Windows.Forms.TextBox txt_s1;
        private System.Windows.Forms.TextBox txt_Bgiaithua;
        private System.Windows.Forms.TextBox txt_Agiaithua;
    }
}