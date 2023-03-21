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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            int n1, n2;
            string num1 = txt_nhapA.Text;
            string num2 = txt_nhapB.Text;
            bool check1 = int.TryParse(num1, out n1);
            bool check2 = int.TryParse(num2, out n2);
            if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2) )
            {
                MessageBox.Show("Bạn phải điền vào ô trống", "Cảnh báo");
            }
            else
            {
                if (check1 == false || check2 == false)
                {
                    MessageBox.Show("Bạn phải điền số vào ô ", "Cảnh báo");
                }
                else if ( n1 < 0 || n2 < 0)
                {
                    txt_Agiaithua.Text = "A! Không tồn tại";
                    txt_Bgiaithua.Text = "B! Không tồn tại";
                }    
                else
                {
                    long Agiaithua = 1, Bgiaithua = 1;
                    for (int i = 1; i <= n1; i++)
                    {
                        Agiaithua *= i;
                    }
                    for (int i = 1; i <= n2; i++)
                    {
                        Bgiaithua *= i;
                    }
                    txt_Agiaithua.Text = "A! = " + Agiaithua.ToString();
                    txt_Bgiaithua.Text = "B! = " + Bgiaithua.ToString();
                    long S1 = 0, S2 = 0;
                    double S3 = 0;
                    string strS1, strS2, strS3;
                    for (int i = 1; i <= n1; i++)
                        S1 += i;
                    for (int i = 1; i <= n2; i++)
                        S2 += i;
                    for (int i = 1; i <= n2; i++)
                        S3 += Math.Pow(n1, i);
                    strS1 = "S1 = 1 + 2 + 3 + 4 + ... + A = " + S1;
                    strS2 = "S2 = 1 + 2 + 3 + 4 + ... + A = " + S2;
                    strS3 = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = " + S3;
                    txt_s1.Text = strS1.ToString();
                    txt_s2.Text = strS2.ToString();
                    txt_s3.Text = strS3.ToString();
                }    

            }
                
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_nhapA.Text = string.Empty;
            txt_nhapB.Text = string.Empty;
            txt_Agiaithua.Text = string.Empty; 
            txt_Bgiaithua.Text= string.Empty;
            txt_s1.Text= string.Empty;
            txt_s2.Text= string.Empty;
            txt_s3.Text= string.Empty;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
