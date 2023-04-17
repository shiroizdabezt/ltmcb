namespace Lab_2
{
    partial class Bai3
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
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_Cal = new System.Windows.Forms.Button();
            this.rtxt_tinhtoan = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(12, 376);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(158, 72);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Đọc file";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_write
            // 
            this.btn_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.Location = new System.Drawing.Point(176, 376);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(158, 72);
            this.btn_write.TabIndex = 1;
            this.btn_write.Text = "Ghi file";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_Cal
            // 
            this.btn_Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cal.Location = new System.Drawing.Point(577, 376);
            this.btn_Cal.Name = "btn_Cal";
            this.btn_Cal.Size = new System.Drawing.Size(158, 72);
            this.btn_Cal.TabIndex = 2;
            this.btn_Cal.Text = "Tính toán";
            this.btn_Cal.UseVisualStyleBackColor = true;
            this.btn_Cal.Click += new System.EventHandler(this.btn_Cal_Click);
            // 
            // rtxt_tinhtoan
            // 
            this.rtxt_tinhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_tinhtoan.Location = new System.Drawing.Point(-1, 0);
            this.rtxt_tinhtoan.Name = "rtxt_tinhtoan";
            this.rtxt_tinhtoan.Size = new System.Drawing.Size(799, 370);
            this.rtxt_tinhtoan.TabIndex = 3;
            this.rtxt_tinhtoan.Text = "";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxt_tinhtoan);
            this.Controls.Add(this.btn_Cal);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_read);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_Cal;
        private System.Windows.Forms.RichTextBox rtxt_tinhtoan;
    }
}