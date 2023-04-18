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
using System.Diagnostics;

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
            TreeNodeCollection nodes = treeNode.Nodes;
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
                /*if (s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    TreeNode node = treeNode.Nodes.Add(Path.GetFileName(s));
                    node.Tag = s; 
                }*/
                TreeNode node = new TreeNode(Path.GetFileName(s));
                nodes.Add(node);
            }
        }

        private void tree_caythumuc_DoubleClick(object sender, EventArgs e)
        {

        }
        private void tree_caythumuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pictureBox1.Image = null;
            richTextBox1.Clear();
            string filePath = e.Node.FullPath;
            if(File.Exists(filePath)) {
                if (e.Node.Tag != null && (e.Node.Tag.ToString().ToLower().EndsWith(".jpg") || e.Node.Tag.ToString().ToLower().EndsWith(".jpeg") || e.Node.Tag.ToString().ToLower().EndsWith(".png") || e.Node.Tag.ToString().ToLower().EndsWith(".bmp") || e.Node.Tag.ToString().ToLower().EndsWith(".gif")))
                {
                    pictureBox1.Visible = true;

                    richTextBox1.Visible = false;

                    Image image = Image.FromFile(filePath);
                    pictureBox1.Image = image;

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (e.Node.Tag != null && e.Node.Tag.ToString().ToLower().EndsWith(".txt"))
                {
                    pictureBox1.Visible = false;

                    richTextBox1.Visible = true;

                    string text = File.ReadAllText(filePath);
                    richTextBox1.Text += text;
                }
                else
                {
                    pictureBox1.Image = null;
                    richTextBox1.Clear();
                    Process.Start(filePath);
                }
            }
            
        }
    }
}
