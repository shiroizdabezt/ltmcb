namespace Lab_2
{
    partial class Bai1
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
            this.richtxt_File = new System.Windows.Forms.RichTextBox();
            this.btn_Doc = new System.Windows.Forms.Button();
            this.btn_Ghi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richtxt_File
            // 
            this.richtxt_File.Location = new System.Drawing.Point(12, 100);
            this.richtxt_File.Name = "richtxt_File";
            this.richtxt_File.Size = new System.Drawing.Size(776, 338);
            this.richtxt_File.TabIndex = 0;
            this.richtxt_File.Text = "";
            // 
            // btn_Doc
            // 
            this.btn_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Doc.Location = new System.Drawing.Point(129, 12);
            this.btn_Doc.Name = "btn_Doc";
            this.btn_Doc.Size = new System.Drawing.Size(162, 71);
            this.btn_Doc.TabIndex = 1;
            this.btn_Doc.Text = "Đọc FIle";
            this.btn_Doc.UseVisualStyleBackColor = true;
            this.btn_Doc.Click += new System.EventHandler(this.btn_Doc_Click);
            // 
            // btn_Ghi
            // 
            this.btn_Ghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ghi.Location = new System.Drawing.Point(484, 12);
            this.btn_Ghi.Name = "btn_Ghi";
            this.btn_Ghi.Size = new System.Drawing.Size(180, 71);
            this.btn_Ghi.TabIndex = 2;
            this.btn_Ghi.Text = "Ghi FIle";
            this.btn_Ghi.UseVisualStyleBackColor = true;
            this.btn_Ghi.Click += new System.EventHandler(this.btn_Ghi_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ghi);
            this.Controls.Add(this.btn_Doc);
            this.Controls.Add(this.richtxt_File);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxt_File;
        private System.Windows.Forms.Button btn_Doc;
        private System.Windows.Forms.Button btn_Ghi;
    }
}