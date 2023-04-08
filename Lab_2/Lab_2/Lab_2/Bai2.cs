using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }


        private void btn_ReadFIle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fstr = new FileStream(dlg.FileName, FileMode.OpenOrCreate);

                StreamReader sr = new StreamReader(fstr);
                richtxt_show.Text = sr.ReadToEnd();
                fstr.Close();
                sr.Close();
                fstr = new FileStream(dlg.FileName, FileMode.OpenOrCreate);
                sr = new StreamReader(fstr);
                int lineCount = 0;
                while (sr.ReadLine() != null)
                {
                    lineCount++;
                }
                txt_LineCount.Text = lineCount.ToString();
                txt_FileName.Text = dlg.SafeFileName;
                FileInfo fileInfo = new FileInfo(dlg.FileName.ToString());
                txt_size.Text = fileInfo.Length.ToString();
                txt_URL.Text = dlg.FileName;
                fstr.Close();
                sr.Close();
                fstr = new FileStream(dlg.FileName, FileMode.OpenOrCreate);
                sr = new StreamReader(fstr);
                string str = sr.ReadToEnd();
                string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                txt_WordsCount.Text = words.Length.ToString();
                fstr.Close();
                txt_CharacterCount.Text = File.ReadAllText(dlg.FileName).Length.ToString();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
