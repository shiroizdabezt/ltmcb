using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Lab_2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_Doc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fstr = new FileStream(dlg.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fstr);
                richtxt_File.Text = sr.ReadToEnd();
            }    
            
        }

        private void btn_Ghi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(sfd.FileName))
                {
                    string upper = richtxt_File.Text;
                    upper = upper.ToUpper();
                    sr.WriteLine(upper);
                }
                MessageBox.Show("Viết hoa text thành công vào file: " + sfd.FileName.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);          }      
        }
    }
}
