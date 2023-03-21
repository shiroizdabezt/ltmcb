using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            Bai_1 bai_1 = new Bai_1();
            bai_1.ShowDialog();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            Bai2 bai_1 = new Bai2();
            bai_1.ShowDialog();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            Bai3 bai_1 = new Bai3();
            bai_1.ShowDialog();
        }

        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            Bai4 bai_1 = new Bai4();
            bai_1.ShowDialog();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            Bai5 bai_1 = new Bai5();
            bai_1.ShowDialog();
        }
    }
}
