namespace Client
{
    partial class Client
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
            this.txt_chat = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.lsv_chatbox = new System.Windows.Forms.ListView();
            this.btn_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "IP Address";
            // 
            // txt_port
            // 
            this.txt_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_port.Location = new System.Drawing.Point(140, 350);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 26);
            this.txt_port.TabIndex = 26;
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IP
            // 
            this.txt_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.Location = new System.Drawing.Point(140, 315);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(100, 26);
            this.txt_IP.TabIndex = 25;
            this.txt_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_chat
            // 
            this.txt_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chat.Location = new System.Drawing.Point(12, 413);
            this.txt_chat.Multiline = true;
            this.txt_chat.Name = "txt_chat";
            this.txt_chat.Size = new System.Drawing.Size(527, 110);
            this.txt_chat.TabIndex = 24;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(404, 353);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(135, 54);
            this.btn_send.TabIndex = 23;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lsv_chatbox
            // 
            this.lsv_chatbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_chatbox.HideSelection = false;
            this.lsv_chatbox.Location = new System.Drawing.Point(12, 12);
            this.lsv_chatbox.Name = "lsv_chatbox";
            this.lsv_chatbox.Size = new System.Drawing.Size(527, 283);
            this.lsv_chatbox.TabIndex = 22;
            this.lsv_chatbox.UseCompatibleStateImageBehavior = false;
            this.lsv_chatbox.View = System.Windows.Forms.View.List;
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(269, 352);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(129, 55);
            this.btn_connect.TabIndex = 29;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 535);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.txt_chat);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lsv_chatbox);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_chat;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListView lsv_chatbox;
        private System.Windows.Forms.Button btn_connect;
    }
}

