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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void txt_sothunhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sothuhai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            string num1 = txt_sothunhat.Text;
            string num2 = txt_sothuhai.Text;
            string num3 = txt_sothuba.Text;
            bool check1 = int.TryParse(num1, out n1);
            bool check2 = int.TryParse(num2, out n2);
            bool check3 = int.TryParse(num3, out n3);
            if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2) || string.IsNullOrEmpty(num3))
            {
                MessageBox.Show("Bạn phải điền vào ô trống", "Cảnh báo");
            }
            else
            {
                if (check1 == false || check2 == false || check3 == false)
                    MessageBox.Show("Bạn phải điền số nguyên vào ô ", "Cảnh báo");
                else
                {
                    int max = 0, min = 0;
                    if (n1 >= n2 && n1 >= n3)
                        max = n1;
                    else if (n2 >= n1 && n2 >= n3)
                        max = n2;
                    else if (n3 >= n1 && n3 >= n2)
                        max = n3;
                    txt_solonnhat.Text = max.ToString();

                    if (n1 <= n2 && n1 <= n3)
                        min = n1;
                    else if (n2 <= n1 && n2 <= n3)
                        min = n2;
                    else if (n3 <= n1 && n3 <= n2)
                        min = n3;
                    txt_sonhonhat.Text = min.ToString();
                }
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_solonnhat.Text = string.Empty;
            txt_sonhonhat.Text = string.Empty;
            txt_sothunhat.Text = string.Empty;
            txt_sothuhai.Text = string.Empty;
            txt_sothuba.Text = string.Empty;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
