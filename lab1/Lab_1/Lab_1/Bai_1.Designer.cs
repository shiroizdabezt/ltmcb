namespace Lab_1
{
    partial class Bai_1
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
            this.btn_TnhTong = new System.Windows.Forms.Button();
            this.txt_SoThu1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoThu2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Tong = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÀI 1 TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // btn_TnhTong
            // 
            this.btn_TnhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TnhTong.Location = new System.Drawing.Point(519, 149);
            this.btn_TnhTong.Name = "btn_TnhTong";
            this.btn_TnhTong.Size = new System.Drawing.Size(183, 105);
            this.btn_TnhTong.TabIndex = 1;
            this.btn_TnhTong.Text = "TÍNH";
            this.btn_TnhTong.UseVisualStyleBackColor = true;
            this.btn_TnhTong.Click += new System.EventHandler(this.btn_TnhTong_Click);
            // 
            // txt_SoThu1
            // 
            this.txt_SoThu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoThu1.Location = new System.Drawing.Point(341, 164);
            this.txt_SoThu1.Name = "txt_SoThu1";
            this.txt_SoThu1.Size = new System.Drawing.Size(100, 29);
            this.txt_SoThu1.TabIndex = 2;
            this.txt_SoThu1.TextChanged += new System.EventHandler(this.txt_SoThu1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "SỐ THỨ 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "SÓ THỨ 2";
            // 
            // txt_SoThu2
            // 
            this.txt_SoThu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoThu2.Location = new System.Drawing.Point(341, 227);
            this.txt_SoThu2.Name = "txt_SoThu2";
            this.txt_SoThu2.Size = new System.Drawing.Size(100, 29);
            this.txt_SoThu2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(222, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "TỔNG";
            // 
            // txt_Tong
            // 
            this.txt_Tong.Enabled = false;
            this.txt_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong.Location = new System.Drawing.Point(316, 354);
            this.txt_Tong.Name = "txt_Tong";
            this.txt_Tong.Size = new System.Drawing.Size(125, 29);
            this.txt_Tong.TabIndex = 7;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(519, 301);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(183, 86);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "THOÁT";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Bai_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txt_Tong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SoThu2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SoThu1);
            this.Controls.Add(this.btn_TnhTong);
            this.Controls.Add(this.label1);
            this.Name = "Bai_1";
            this.Text = "Bai_1";
            this.Load += new System.EventHandler(this.Bai_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TnhTong;
        private System.Windows.Forms.TextBox txt_SoThu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoThu2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Tong;
        private System.Windows.Forms.Button btn_Thoat;
    }
}