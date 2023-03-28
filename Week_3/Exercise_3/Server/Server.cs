using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
        }

        Socket socket;
        IPEndPoint IPep;
        const int bufferSize = 1024;
        State state = new State();
        AsyncCallback recv = null;
        EndPoint epF = new IPEndPoint(IPAddress.Any, 0);
        public class State
        {
            public byte[] buffer = new byte[bufferSize];
        }
        void Create()
        {         
            IPEndPoint IPep = new IPEndPoint(IPAddress.Parse(txt_IP.Text), Int32.Parse(txt_port.Text));
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(IPep);
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Receive()
        {
            while (true)
            {               
                string received_data;
                socket.ReceiveFrom(state.buffer, 0, bufferSize, SocketFlags.None, ref epF);
                received_data = Encoding.UTF8.GetString(state.buffer);
                lsv_chatbox.Items.Add(new ListViewItem { Text = "Client: " + received_data });
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {

        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Create();
            MessageBox.Show("Tạo thành công", "Create successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
