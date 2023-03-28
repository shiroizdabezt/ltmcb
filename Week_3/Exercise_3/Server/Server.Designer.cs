namespace Server
{
    partial class Server
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.lsv_chatbox = new System.Windows.Forms.ListView();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "IP Address";
            // 
            // txt_port
            // 
            this.txt_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_port.Location = new System.Drawing.Point(140, 390);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 26);
            this.txt_port.TabIndex = 19;
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IP
            // 
            this.txt_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.Location = new System.Drawing.Point(140, 354);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(100, 26);
            this.txt_IP.TabIndex = 18;
            this.txt_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lsv_chatbox
            // 
            this.lsv_chatbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_chatbox.HideSelection = false;
            this.lsv_chatbox.Location = new System.Drawing.Point(12, 12);
            this.lsv_chatbox.Name = "lsv_chatbox";
            this.lsv_chatbox.Size = new System.Drawing.Size(527, 336);
            this.lsv_chatbox.TabIndex = 15;
            this.lsv_chatbox.UseCompatibleStateImageBehavior = false;
            this.lsv_chatbox.View = System.Windows.Forms.View.List;
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(29, 430);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(211, 91);
            this.btn_create.TabIndex = 22;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(307, 432);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(199, 91);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 535);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.lsv_chatbox);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.ListView lsv_chatbox;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_exit;
    }
}

