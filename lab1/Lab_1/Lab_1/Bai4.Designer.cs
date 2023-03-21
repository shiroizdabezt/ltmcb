namespace Lab_1
{
    partial class Bai4
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sotiendoi = new System.Windows.Forms.TextBox();
            this.txt_sotiendadoi = new System.Windows.Forms.TextBox();
            this.txt_tygia = new System.Windows.Forms.TextBox();
            this.cmbb_loaitien = new System.Windows.Forms.ComboBox();
            this.btn_chuyendoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÀI 4 CHUYỂN TIỀN TỆ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền cần đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền đã đổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tỷ giá quy đổi";
            // 
            // txt_sotiendoi
            // 
            this.txt_sotiendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotiendoi.Location = new System.Drawing.Point(200, 80);
            this.txt_sotiendoi.Name = "txt_sotiendoi";
            this.txt_sotiendoi.Size = new System.Drawing.Size(211, 29);
            this.txt_sotiendoi.TabIndex = 4;
            // 
            // txt_sotiendadoi
            // 
            this.txt_sotiendadoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotiendadoi.Location = new System.Drawing.Point(200, 199);
            this.txt_sotiendadoi.Name = "txt_sotiendadoi";
            this.txt_sotiendadoi.Size = new System.Drawing.Size(143, 29);
            this.txt_sotiendadoi.TabIndex = 5;
            // 
            // txt_tygia
            // 
            this.txt_tygia.Enabled = false;
            this.txt_tygia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tygia.Location = new System.Drawing.Point(200, 325);
            this.txt_tygia.Name = "txt_tygia";
            this.txt_tygia.Size = new System.Drawing.Size(303, 29);
            this.txt_tygia.TabIndex = 6;
            // 
            // cmbb_loaitien
            // 
            this.cmbb_loaitien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbb_loaitien.FormattingEnabled = true;
            this.cmbb_loaitien.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.cmbb_loaitien.Location = new System.Drawing.Point(440, 77);
            this.cmbb_loaitien.Name = "cmbb_loaitien";
            this.cmbb_loaitien.Size = new System.Drawing.Size(121, 32);
            this.cmbb_loaitien.TabIndex = 7;
            // 
            // btn_chuyendoi
            // 
            this.btn_chuyendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyendoi.Location = new System.Drawing.Point(587, 139);
            this.btn_chuyendoi.Name = "btn_chuyendoi";
            this.btn_chuyendoi.Size = new System.Drawing.Size(141, 89);
            this.btn_chuyendoi.TabIndex = 8;
            this.btn_chuyendoi.Text = "Chuyển đổi";
            this.btn_chuyendoi.UseVisualStyleBackColor = true;
            this.btn_chuyendoi.Click += new System.EventHandler(this.btn_chuyendoi_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(587, 282);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(141, 89);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_chuyendoi);
            this.Controls.Add(this.cmbb_loaitien);
            this.Controls.Add(this.txt_tygia);
            this.Controls.Add(this.txt_sotiendadoi);
            this.Controls.Add(this.txt_sotiendoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sotiendoi;
        private System.Windows.Forms.TextBox txt_sotiendadoi;
        private System.Windows.Forms.TextBox txt_tygia;
        private System.Windows.Forms.ComboBox cmbb_loaitien;
        private System.Windows.Forms.Button btn_chuyendoi;
        private System.Windows.Forms.Button btn_thoat;
    }
}