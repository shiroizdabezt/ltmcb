using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void LayDSODia()
        {
            TreeNode NodeOdia;
            string[] DSODia = Directory.GetLogicalDrives();
            foreach(string s in DSODia)
            {
                NodeOdia = new TreeNode(s);

                tree_caythumuc.Nodes.Add(NodeOdia);

                NodeOdia.Nodes.Add("New Node");
            }    
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            LayDSODia();
        }

        private void tree_caythumuc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {   
            
            TreeNode treeNode = e.Node;

            treeNode.Nodes.Clear();

            string[] dsthumuc = Directory.GetDirectories(treeNode.FullPath);
            string[] dsfile = Directory.GetFiles(treeNode.FullPath);
            foreach(string s in dsthumuc)
            {
                TreeNode node = treeNode.Nodes.Add(Path.GetFileName(s));
                node.Nodes.Add("Node");
            }
            foreach (string s in dsfile)
            {
                if (s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                {
                    TreeNode node = treeNode.Nodes.Add(Path.GetFileName(s));
                    node.Tag = s; 
                }
            }
        }

        private void tree_caythumuc_DoubleClick(object sender, EventArgs e)
        {

        }
        private void tree_caythumuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (e.Node.Tag != null)
            {
                string filePath = e.Node.Tag.ToString();
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(filePath);
                pic.Height = 702;
                pic.Width = 702;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanel1.Controls.Add(pic);
            }
        }

    }
}
