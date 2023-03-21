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
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }

        private void Bai_1_Load(object sender, EventArgs e)
        {

        }

        private void btn_TnhTong_Click(object sender, EventArgs e)
        {
            long sum;
            int n1, n2;
            string num1 = txt_SoThu1.Text;
            string num2 = txt_SoThu2.Text;
            bool check1 = int.TryParse(num1, out n1);
            bool check2 = int.TryParse(num2, out n2);
            if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2))
            {
                MessageBox.Show("Bạn phải điền vào ô trống", "Cảnh báo");
            }
            else
            {
                if (check1 == false || check2 == false)
                    MessageBox.Show("Bạn phải điền số nguyên vào ô ", "Cảnh báo");
                else
                {
                    sum = n1 + n2;
                    txt_Tong.Text = sum.ToString();
                }

            }
        }

        private void txt_SoThu1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
