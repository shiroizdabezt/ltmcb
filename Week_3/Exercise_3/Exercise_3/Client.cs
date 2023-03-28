using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    public partial class Client : Form
    {
        Socket socket;
        IPEndPoint ep;
        byte[] buffer = new byte[1024];
        public Client()
        {
            InitializeComponent();
        }
        byte[] Getbyte(string msg)
        {
            return Encoding.UTF8.GetBytes(msg);        
        }
        void Send()
        {
            byte[] data = Getbyte(txt_chat.Text);
            lsv_chatbox.Items.Add(new ListViewItem { Text = txt_chat.Text });
            socket.SendTo(data, ep);
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            Send();
            txt_chat.Clear();
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(txt_IP.Text, out ip))
                MessageBox.Show("Hãy nhập chính xác IP của người nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ep = new IPEndPoint(IPAddress.Parse(txt_IP.Text), Int32.Parse(txt_port.Text));
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                MessageBox.Show("Kết nối thành công", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
